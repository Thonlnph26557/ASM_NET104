using ASM.DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM.DB.EF.Configurations
{
    public class BillDetailConfiguration : IEntityTypeConfiguration<BillDetail>
    {
        public void Configure(EntityTypeBuilder<BillDetail> builder)
        {
            builder.ToTable("BillDetail");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Quantity);
            builder.Property(x => x.Price);

            builder.HasOne(x => x.Bill).WithMany(x => x.BillDetail).HasForeignKey(x => x.BillId);
            builder.HasOne(x => x.Product).WithMany(x => x.BillDetail).HasForeignKey(x => x.ProductId);
        }
    }
}
