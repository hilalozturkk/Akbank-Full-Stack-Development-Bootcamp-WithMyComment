using DIDemoAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemoAPI.Data
{
    public class MiniDBContext : DbContext // EF core - code first
    {
        //class to communicate with db 
        // 1 create products table
        public DbSet<Product> Products { get; set; }
        public MiniDBContext(DbContextOptions<MiniDBContext> options):base(options)
        {
            //EF works independently of the database

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Description).IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.Description).HasMaxLength(150);
            modelBuilder.Entity<Product>().Property(p => p.Price).IsRequired();
        }

    }
}
