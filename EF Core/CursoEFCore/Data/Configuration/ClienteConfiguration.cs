using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CursoEFCore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursoEFCore.Data.Configuration
{

    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
                        builder.HasKey(p => p.Id);//Cria a Chave Primaria Id
                        builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();//Cria a Coluna Nome
                        builder.Property(p => p.Telefone).HasColumnType("CHAR(11)");//Cria a Coluna Telefone
                        builder.Property(p => p.CEP).HasColumnType("CHAR(8)").IsRequired();//Cria a Coluna CEP
                        builder.Property(p => p.Estado).HasColumnType("CHAR(2)").IsRequired(); //Cria a Coluna Estado
                        builder.Property(p => p.Cidade).HasMaxLength(60).IsRequired();

                        builder.HasIndex(i => i.Telefone).HasName("idx_cliente_telefone"); //Cria um Indice para Telefone
        }
    }
}