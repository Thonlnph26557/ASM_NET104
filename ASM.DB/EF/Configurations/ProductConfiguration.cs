using ASM.DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM.DB.EF.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name);
            builder.Property(x => x.Price);
            builder.Property(x => x.AvaiableQuantity);
            builder.Property(x => x.Status);
            builder.Property(x => x.Supplier);
            builder.Property(x => x.Description);
            builder.Property(x => x.ImageUrl);
        }
    }
}
