﻿using Bakeryshop.Infrastructure.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bakeryshop.Infrastructure.EntityFramework.Configuration
{
    public class bksPersonConfiguration : IEntityTypeConfiguration<bksPerson>
    {
        public void Configure(EntityTypeBuilder<bksPerson> builder)
        {
            builder.ToTable(nameof(bksPerson));
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Title).HasMaxLength(150);
            builder.Property(s => s.Name).HasMaxLength(100);
            builder.Property(s => s.Family).HasMaxLength(100);
            builder.Property(s => s.BirthDate).HasMaxLength(10);
            builder.Property(s => s.InfoConfirmed).IsRequired();
            builder.Property(s => s.PhoneNumber).HasMaxLength(15).IsRequired();
            builder.Property(s => s.PhoneNumberConfirmed).IsRequired();
            builder.Property(s => s.Address).HasMaxLength(250).IsRequired();
            builder.Property(s => s.Email).HasMaxLength(150).IsRequired();
            builder.Property(s => s.EmailConfirmed).IsRequired();
            builder.Property(s => s.Password).HasMaxLength(256).IsRequired();
            builder.Property(s => s.LockoutEnabled).IsRequired();
            builder.Property(s => s.AccessFailedCount).IsRequired();
            builder.Property(s => s.NotificationCount).IsRequired();
            builder.Property(s => s.MessageCount).IsRequired();
            builder.Property(s => s.PhotoGuid).HasMaxLength(50);
            builder.Property(s => s.IsMessageBlocked).IsRequired();
            builder.Property(s => s.IsActive).IsRequired();
        }
    }
}
