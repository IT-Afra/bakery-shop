using Bakeryshop.Infrastructure.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bakeryshop.Infrastructure.EntityFramework.Configuration
{
    public class bksOrderDetailConfiguration : IEntityTypeConfiguration<bksOrderDetail>
    {
        public void Configure(EntityTypeBuilder<bksOrderDetail> builder)
        {
            builder.ToTable(nameof(bksOrderDetail));
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Price).HasMaxLength(18).IsRequired();
            builder.Property(s => s.Amount).IsRequired();

            builder.HasOne(s => s.Order)
                .WithMany(d => d.OrderDetails)
                .HasForeignKey(s => s.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(s => s.TypeBread)
                .WithMany()
                .HasForeignKey(s => s.TypeBreadId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(s => s.TypeBread)
                 .WithMany()
                 .HasForeignKey(s => s.TypeBreadId)
                 .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
