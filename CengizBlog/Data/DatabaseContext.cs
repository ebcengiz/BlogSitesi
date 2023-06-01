﻿using CengizBlog.Entites;
using Microsoft.EntityFrameworkCore;

namespace CengizBlog.Data
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        } // ctor
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Genel",
                    IsActive = true
                });
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    IsActive = true,
                    IsAdmin = true,
                    Name = "Admin",
                    Surname = "User",
                    Email = "admin@blogger.com",
                    Password = "123",
                    UserName = "Admin"
                });
            base.OnModelCreating(modelBuilder);
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=ENESBUGRACENGİZ; database=CengizBlog; integrated security=true");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
