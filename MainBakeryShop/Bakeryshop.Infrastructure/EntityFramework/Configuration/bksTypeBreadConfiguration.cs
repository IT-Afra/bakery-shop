using Bakeryshop.Infrastructure.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bakeryshop.Infrastructure.EntityFramework.Configuration
{
    public class bksTypeBreadConfiguration : IEntityTypeConfiguration<bksTypeBread>
    {
        public void Configure(EntityTypeBuilder<bksTypeBread> builder)
        {
            builder.ToTable("bksTypeBread");
           
            builder.HasKey(b => b.Id);

            builder.Property(s => s.Name).HasMaxLength(100).IsRequired();
            builder.Property(s => s.PhotoGuid).HasMaxLength(100).IsRequired();
            builder.Property(s => s.IsActive).IsRequired();
        }
    }
}
