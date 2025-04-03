using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SacrementPlanner.Models;

namespace SacrementPlanner.Data
{
    public class SacrementPlannerContext : DbContext
    {
        public SacrementPlannerContext (DbContextOptions<SacrementPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<SacrementPlanner.Models.Meeting> Meeting { get; set; } = default!;
        public DbSet<SacrementPlanner.Models.Speaker> Speakers { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SacrementPlanner.Models.Meeting>().ToTable("Meeting");
            modelBuilder.Entity<SacrementPlanner.Models.Speaker>().ToTable("Speaker");
        }
    }
}
