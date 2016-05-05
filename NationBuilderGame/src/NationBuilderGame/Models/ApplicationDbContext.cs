using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace NationBuilderGame.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Geography> Geographies { get; set; }
        public DbSet<Economy> Economies { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Government> Governments { get; set; }
        public DbSet<Nation> Nations { get; set; }
    }
}
