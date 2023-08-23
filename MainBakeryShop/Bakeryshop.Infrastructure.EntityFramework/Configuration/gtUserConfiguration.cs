using Bakeryshop.Infrastructure.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bakeryshop.Infrastructure.EntityFramework.Configuration
{
    public class gtUserConfiguration : IEntityTypeConfiguration<gtUser>
    {
        public void Configure(EntityTypeBuilder<gtUser> builder)
        {
            builder.ToTable(nameof(gtUser));
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name).HasMaxLength(100);
            builder.Property(s => s.UserName).HasMaxLength(100);
            builder.Property(s => s.Password).HasMaxLength(256);
            builder.Property(s => s.RoleName).HasMaxLength(50);
            builder.Property(s => s.IsActive);
        }
    }
}
