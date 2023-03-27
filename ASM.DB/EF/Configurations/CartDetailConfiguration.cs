using ASM.DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM.DB.EF.Configurations
{
    public class CartDetailConfiguration : IEntityTypeConfiguration<CartDetail>
    {
        public void Configure(EntityTypeBuilder<CartDetail> builder)
        {
            builder.ToTable("CartDetail");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Quantity);

            builder.HasOne(x => x.Cart).WithMany(x => x.CartDetail).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Product).WithMany(x => x.CartDetail).HasForeignKey(x => x.ProductId);
        }
    }
}
