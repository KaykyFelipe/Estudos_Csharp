using CursoEFCore.Domain;
using Microsoft.EntityFrameworkCore;


namespace CursoEFCore.Data
{


    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SQLSERVER2022;Database=CursoEF;Trusted_Connection=True;");// Qual Banco estamos usando e qual string de conexao
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(p =>
                    {
                        p.ToTable("Clientes");
                        p.HasKey(p => p.Id);//Cria a Chave Primaria Id
                        p.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();//Cria a Coluna Nome
                        p.Property(p => p.Telefone).HasColumnType("CHAR(11)");//Cria a Coluna Telefone
                        p.Property(p => p.CEP).HasColumnType("CHAR(8)").IsRequired();//Cria a Coluna CEP
                        p.Property(p => p.Estado).HasColumnType("CHAR(2)").IsRequired(); //Cria a Coluna Estado
                        p.Property(p => p.Cidade).HasMaxLength(60).IsRequired();

                        p.HasIndex(i => i.Telefone).HasName("idx_cliente_telefone"); //Cria um Indice para Telefone
                    });

            modelBuilder.Entity<Produto>(p =>
                    {
                        p.ToTable("Produtos");
                        p.HasKey(p => p.Id);
                        p.Property(p => p.CodigoBarras).HasColumnType("VARCHAR(14)").IsRequired();
                        p.Property(p => p.Descricao).HasColumnType("VARCHAR(60)");
                        p.Property(p => p.Valor).IsRequired();
                        p.Property(p => p.TipoProduto).HasConversion<string>(); //O Tipo produto é informada como uma String
                    });

            modelBuilder.Entity<Pedido>(p =>
                    {
                        p.ToTable("Pedidos");
                        p.HasKey(p => p.Id);
                        p.Property(p => p.IniciadoEm).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();//quando for efetuado o Insert ele executa o comando "GETDATE()" para colher a data atual 
                        p.Property(p => p.Status).HasConversion<string>();
                        p.Property(p => p.TipoFrete).HasConversion<int>();//O Tipo Frete (Enums) quando convertido a INT ele efetua um ID para cada Enum exemplo: CIF (1)  FOB(2)  SemFrete(3)
                        p.Property(p => p.Observacao).HasColumnType("VARCHAR(512)");

                        p.HasMany(p => p.Itens) //Especifica que a entidade Pedido tem muitos Itens.
                            .WithOne(p => p.Pedido) //Especifica que cada Item está associado a um Pedido.
                            .OnDelete(DeleteBehavior.Cascade); //Configura a exclusão em cascata, ou seja, se um Pedido for excluído, todos os Itens relacionados também serão excluídos.
                    });
        }
    }



}









