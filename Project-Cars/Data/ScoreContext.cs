using Microsoft.EntityFrameworkCore;
using Project_Cars.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Cars.Data
{
    public class ScoreContext : DbContext
    {
        public ScoreContext()
        {

        }

        public ScoreContext(DbContextOptions options) 
             :base(options) 
        {

        }
        public virtual DbSet<User> users { get; set; }
        public virtual DbSet<ScoreTable> rankingscore { get; set; } 
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating
            (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
