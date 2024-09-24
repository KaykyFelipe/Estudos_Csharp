using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CursoEFCore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursoEFCore.Data.Configuration
{

    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedidos");
                        builder.HasKey(p => p.Id);
                        builder.Property(p => p.IniciadoEm).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();//quando for efetuado o Insert ele executa o comando "GETDATE()" para colher a data atual 
                        builder.Property(p => p.Status).HasConversion<string>();
                        builder.Property(p => p.TipoFrete).HasConversion<int>();//O Tipo Frete (Enums) quando convertido a INT ele efetua um ID para cada Enum exemplo: CIF (1)  FOB(2)  SemFrete(3)
                        builder.Property(p => p.Observacao).HasColumnType("VARCHAR(512)");

                        builder.HasMany(p => p.Itens) //Especifica que a entidade Pedido tem muitos Itens.
                            .WithOne(p => p.Pedido) //Especifica que cada Item está associado a um Pedido.
                            .OnDelete(DeleteBehavior.Cascade); //Configura a exclusão em cascata, ou seja, se um Pedido for excluído, todos os Itens relacionados também serão excluídos.
        }
    }
}