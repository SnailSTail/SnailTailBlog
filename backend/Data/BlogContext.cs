using Microsoft.EntityFrameworkCore;
using SnailTailBlog.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnailTailBlog.WebApi.Data
{
    public class BlogContext: DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticleLabel>().HasKey(c => new { c.ArticleID, c.LabelID });

            modelBuilder.Entity<ArticleLabel>()
                .HasOne(c => c.Article)
                .WithMany(o => o.ArticleLabels)
                .HasForeignKey(c => c.ArticleID);

            modelBuilder.Entity<ArticleLabel>()
                .HasOne(c => c.Label)
                .WithMany(o => o.ArticleLabels)
                .HasForeignKey(c => c.LabelID);

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Label> Labels { get; set; }
    }
}
