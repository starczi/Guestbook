using System;
using Microsoft.EntityFrameworkCore;

namespace Guestbook.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Record> Records { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Record>().HasData(new Record { RecordId = 1, Nick = "starczi", DatePosted = DateTime.Now, Comment = "first comment", Country = "poland", Email = "xxx@gmail.com" });
            modelBuilder.Entity<Record>().HasData(new Record { RecordId = 2, Nick = "starczi1", DatePosted = DateTime.Now, Comment = "second comment", Country = "universe", Email = "yyy@gmail.com" });
            modelBuilder.Entity<Record>().HasData(new Record { RecordId = 3, Nick = "starczi2", DatePosted = DateTime.Now, Comment = "third comment", Country = "europe", Email = "zzz@gmail.com" });
        }
    }
}