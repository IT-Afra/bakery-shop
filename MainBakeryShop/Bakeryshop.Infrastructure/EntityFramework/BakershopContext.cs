using Bakeryshop.Infrastructure.EntityFramework.Configuration;
using Bakeryshop.Infrastructure.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bakeryshop.Infrastructure.EntityFramework
{
    
    
    public class BakershopContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Data Source=.;Initial Catalog=Bakeryshop;Integrated Security=True");
        }
        public virtual DbSet<bksTypeBread> bksTypeBreads { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new bksSchaduleConfiguration());
            modelBuilder.ApplyConfiguration(new bksSchaduleDetailConfiguration());
            modelBuilder.ApplyConfiguration(new bksTypeBreadConfiguration());
        }

    }
}
