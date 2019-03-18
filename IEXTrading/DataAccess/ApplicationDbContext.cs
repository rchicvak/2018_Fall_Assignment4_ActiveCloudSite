using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IEXTrading.Models;

namespace IEXTrading.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Equity> Equities { get; set; }
        public DbSet<Top> Tops { get; set; }
        public DbSet<Financial> Financials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Financial>()
                .HasKey(c => new { c.symbol, c.reportDate });
        }

    }
}
