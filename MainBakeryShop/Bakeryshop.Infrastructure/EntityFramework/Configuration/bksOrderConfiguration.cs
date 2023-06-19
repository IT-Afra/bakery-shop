using Bakeryshop.Infrastructure.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bakeryshop.Infrastructure.EntityFramework.Configuration
{
    public class bksOrderConfiguration : IEntityTypeConfiguration<bksOrder>
    {
        public void Configure(EntityTypeBuilder<bksOrder> builder)
        {
            builder.ToTable(nameof(bksOrder));

            builder.HasKey(b => b.Id);
            builder.Property(s => s.RegisterDateTime).HasMaxLength(21).IsRequired();
            builder.Property(s => s.RegisterDateTimeL).IsRequired();
            builder.Property(s => s.DeliveryDateTime).HasMaxLength(21);
            builder.Property(s => s.TotalPrice).HasMaxLength(18).IsRequired();

            builder.HasOne(s=>s.User)
                         .WithMany()
                         .HasForeignKey(s => s.UserId)
                         .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(s => s.Schadule)
                         .WithMany()
                         .HasForeignKey(s => s.SchaduleId)
                         .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
