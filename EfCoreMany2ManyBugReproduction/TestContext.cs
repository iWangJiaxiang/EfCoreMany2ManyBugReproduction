using EfCoreMany2ManyBugReproduction.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreMany2ManyBugReproduction
{
   public class TestContext:DbContext
    {
        public DbSet<BookA> BookAs { get; set; }
        public DbSet<BookB> BookBs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BookTag> BookTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookTag>()
                .HasKey(x => new { x.BookAId, x.TagId });

            modelBuilder.Entity<BookTag>()
                .HasOne<Tag>(x => x.Tag)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.TagId);

            modelBuilder.Entity<BookTag>()
                .HasOne<BookA>(x => x.BookA)
                .WithMany(x => x.Tags)
                .HasForeignKey(x => x.BookAId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=test.db");
        }
    }
}
