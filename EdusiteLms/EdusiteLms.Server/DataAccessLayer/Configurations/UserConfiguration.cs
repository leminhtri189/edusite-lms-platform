using EdusiteLms.Server.BusinessObject.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EdusiteLms.Server.DataAccessLayer.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");


            builder.Property(u => u.Email)
                   .HasColumnName("email")
                   .IsRequired();
            builder.Property(u => u.PasswordHash)
                .HasColumnName("password_hash")
                     .IsRequired();

            builder.Property(u => u.Phone)
                  .HasColumnName("phone")
                  .IsRequired(false);

            builder.Property(u => u.Avatar)
                    .HasColumnName("avatar")
                    .IsRequired(false);

            builder.Property(u => u.Role)
                    .HasColumnName("role")
                   .IsRequired();



        }
    }
}
