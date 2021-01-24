using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PCC.Data.Models;
using PCC.Data.Models.Parts;

namespace PCC.Data
{
    public class PCCDbContext : IdentityDbContext<PCCUser, IdentityRole, string>
    {
        public DbSet<Setting> Settings { get; set; }

        public DbSet<ParameterSettings> ParameterSettings { get; set; }

        public DbSet<Software> Softwares { get; set; }

        public DbSet<GPU> GPUs { get; set; }

        public DbSet<HardDisk> HardDisks { get; set; }
        
        public DbSet<Motherboard> Motherboards { get; set; }
        
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        
        public DbSet<Processor> Processors { get; set; }

        public DbSet<RAM> RAMs { get; set; }

        public PCCDbContext(DbContextOptions<PCCDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
