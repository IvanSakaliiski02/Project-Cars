using Microsoft.EntityFrameworkCore;
using Project_Cars.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Cars.Data
{
    public class Score : DbContext
    {
        public Score()
        {

        }

        public Score(DbContextOptions options) 
             :base(options) 
        {

        }
        public DbSet<ScoreTable> RankingScore { get; set; } 
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
