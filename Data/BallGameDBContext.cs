using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BallGameMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BallGameMVC.Data
{
    public class BallGameDBContext : DbContext
    {
        public BallGameDBContext(DbContextOptions<BallGameDBContext> options) : base(options) { }
        public DbSet<Environ> Environs { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Environ>().ToTable("Environ");
            modelBuilder.Entity<Player>().ToTable("Player");
        }

    }
}
