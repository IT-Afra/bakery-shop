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

            builder.Property(s => s.Name).HasMaxLength(100);
            builder.Property(s => s.PhotoGuid).HasMaxLength(100);
        }

        public void Configure(EntityTypeBuilder<bksSchadule> builder)
        {
            builder.ToTable("bksSchadule");

            builder.HasKey(b => b.Id);

            builder.Property(s => s.OrderDate).HasMaxLength(10);
            builder.Property(s => s.OrderTime).HasMaxLength(10);
        }
    }
}
