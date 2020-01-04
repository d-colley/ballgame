using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BallGame.Model
{
    public class BallGameDBContext : DbContext
    {
        public BallGameDBContext(DbContextOptions<BallGameDBContext> options) : base(options) { }
        public DbSet<Environ> Environs { get; set; }
        public DbSet<Player> Players { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }


    }
}
