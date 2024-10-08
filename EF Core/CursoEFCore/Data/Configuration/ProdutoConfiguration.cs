using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CursoEFCore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursoEFCore.Data.Configuration
{

    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
                        builder.ToTable("Produtos");
                        builder.HasKey(p => p.Id);
                        builder.Property(p => p.CodigoBarras).HasColumnType("VARCHAR(14)").IsRequired();
                        builder.Property(p => p.Descricao).HasColumnType("VARCHAR(60)");
                        builder.Property(p => p.Valor).IsRequired();
                        builder.Property(p => p.TipoProduto).HasConversion<string>(); //O Tipo produto é informada como uma String
        }
    }
}