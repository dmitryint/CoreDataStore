﻿using Microsoft.EntityFrameworkCore;
using SimpleBloggingApp.Entities;

namespace SimpleBloggingApp
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options): base(options) { }

        public BloggingContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./coredatastore.sqlite");
        }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>(entity =>
            {
                entity.Property(e => e.Title).HasColumnType("varchar(128)");
                entity.Property(e => e.Url).HasColumnType("varchar(128)");
            });

        }

        public virtual DbSet<Blog> Blogs { get; set; }

        //public DbSet<Post> Posts { get; set; }
    }
}