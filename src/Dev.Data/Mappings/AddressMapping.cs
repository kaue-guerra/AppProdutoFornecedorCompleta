using Dev.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dev.Data.Mappings
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.AddressName).IsRequired().HasColumnType("varchar(200)");
            builder.Property(a => a.Number).IsRequired().HasColumnType("varchar(50)");
            builder.Property(a => a.ZipCode).IsRequired().HasColumnType("varchar(8)");
            builder.Property(a => a.Complement).IsRequired().HasColumnType("varchar(250)");
            builder.Property(a => a.District).IsRequired().HasColumnType("varchar(100)");
            builder.Property(a => a.City).IsRequired().HasColumnType("varchar(100)");
            builder.Property(a => a.State).IsRequired().HasColumnType("varchar(50)");




            builder.ToTable("Addresses");
        }
    }
}
