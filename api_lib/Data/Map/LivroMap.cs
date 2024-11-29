using api_lib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_lib.Data.Map
{
    public class LivroMap : IEntityTypeConfiguration<LivroModel>
    {
        public void Configure(EntityTypeBuilder<LivroModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TituloLivro).IsRequired().HasMaxLength(255);
            builder.Property(x => x.AutorLivro).IsRequired().HasMaxLength(150);
            builder.Property(x => x.QuantidadeDisponivel).IsRequired().HasMaxLength(10);
            builder.Property(x => x.AnoLancamento).IsRequired().HasMaxLength(4);
        }
    }
}
