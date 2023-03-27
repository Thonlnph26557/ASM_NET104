using ASM.DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM.DB.EF.Configurations
{
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.ToTable("Bill");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreateDate);
            builder.Property(x => x.Status);

            builder.HasOne(x => x.User).WithMany(x => x.Bill).HasForeignKey(x => x.UserId);
        }
    }
}
