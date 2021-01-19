using CarWash.Web.Infrastructures.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Data
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options)
            : base(options)
        {
        }


        public DbSet<Group> Groups { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Booking> Bookings { get; set; }


        public DbSet<Service> Services { get; set; }
        public DbSet<Contact> Contacts { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<UserGroup>().ToTable("UserGroup");
            modelBuilder.Entity<UserRole>().ToTable("UserRole");
    

            modelBuilder.Entity<Service>().ToTable("Service");
            modelBuilder.Entity<Booking>().ToTable("Booking");
            modelBuilder.Entity<Contact>().ToTable("Contact");
        }
    }
}