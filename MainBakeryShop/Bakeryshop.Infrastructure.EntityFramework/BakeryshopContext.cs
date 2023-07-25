using Bakeryshop.Infrastructure.EntityFramework.Configuration;
using Bakeryshop.Infrastructure.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bakeryshop.Infrastructure.EntityFramework
{
    
    
    public class BakeryshopContext : DbContext
    {

        public BakeryshopContext(DbContextOptions<BakeryshopContext> options) : base(options)
        {

        }

        public virtual DbSet<bksOrder> bksOrders { get; set; } = null!;
        public virtual DbSet<bksOrderDetail> bksOrderDetails { get; set; } = null!;
        public virtual DbSet<bksSchadule> bksSchadules { get; set; } = null!;
        public virtual DbSet<bksSchaduleDetail> bksSchaduleDetails { get; set; } = null!;
        public virtual DbSet<bksTypeBread> bksTypeBreads { get; set; } = null!;
        public virtual DbSet<gtUser> gtUsers { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new bksOrderConfiguration());
            modelBuilder.ApplyConfiguration(new bksOrderConfiguration());
            modelBuilder.ApplyConfiguration(new bksSchaduleConfiguration());
            modelBuilder.ApplyConfiguration(new bksSchaduleDetailConfiguration());
            modelBuilder.ApplyConfiguration(new bksTypeBreadConfiguration());
            modelBuilder.ApplyConfiguration(new gtUserConfiguration());
        }



    }
}
