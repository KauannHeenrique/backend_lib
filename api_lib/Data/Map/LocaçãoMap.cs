using api_lib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_lib.Data.Map
{
    public class LocaçãoMap : IEntityTypeConfiguration<LocaçãoModel>
    {
        public void Configure(EntityTypeBuilder<LocaçãoModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NomeLocatario).IsRequired().HasMaxLength(255);
            builder.Property(x => x.AnoNascimento).IsRequired().HasMaxLength(4);
            
        }
    }
}
