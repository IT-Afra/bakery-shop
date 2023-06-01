using Bakeryshop.Infrastructure.EntityFramework.Configuration;
using Bakeryshop.Infrastructure.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bakeryshop.Infrastructure.EntityFramework
{
    public class BakershopContext : DbContext
    {
        public virtual DbSet<bksTypeBread> bksTypeBreads { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new bksTypeBreadConfiguration());
        }

    }
}
