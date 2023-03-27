using ASM.DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASM.DB.EF.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.UserName);
            builder.Property(x => x.Password);
            builder.Property(x => x.Status);

            builder.HasOne(x => x.Role).WithMany(x => x.User).HasForeignKey(x => x.RoleId);
        }
    }
}
