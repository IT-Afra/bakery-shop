using Bakeryshop.Infrastructure.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakeryshop.Infrastructure.EntityFramework.Configuration
{
    public class bksOrderConfiguration : IEntityTypeConfiguration<bksOrder>
    {
        public void Configure(EntityTypeBuilder<bksOrder> builder)
        {
            builder.ToTable("bksOrder");

            builder.HasKey(b => b.Id);

            builder.Property(s => s.RegisterDateTime).HasMaxLength(21).IsRequired();
            
            builder.Property(s => s.RegisterDateTimeL).IsRequired();

            builder.Property(s => s.DeliveryDateTime).HasMaxLength(21);

            builder.Property(s => s.TotalPrice).HasMaxLength(18).IsRequired();

            builder.HasOne(s=>s.User)
                         .WithMany()
                         .HasForeignKey(s => s.UserId)
                         .OnDelete(DeleteBehavior.Cascade);



        }
    }
}
