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
    public class bksSchaduleDetailConfiguration : IEntityTypeConfiguration<bksSchaduleDetail>
    {
        public void Configure(EntityTypeBuilder<bksSchaduleDetail> builder)
        {
            builder.ToTable("bksSchaduleDetail");

            builder.HasKey(b => b.Id);

            builder.Property(s => s.Price).HasMaxLength(18).IsRequired();

            builder.Property(s => s.Amount).IsRequired();

            builder.Property(s => s.IsActive).IsRequired();

            builder.HasOne(s => s.Schadule)
                .WithMany(s => s.SchaduleDetails)
                .HasForeignKey(s => s.SchaduleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(s => s.TypeBread)
                .WithMany()
                .HasForeignKey(s => s.TypeBreadId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}