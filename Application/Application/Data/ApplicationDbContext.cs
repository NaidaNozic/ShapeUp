using Application.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Day> Day { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Program1> Program1 { get; set; }
        public DbSet<DayVeza> DayVeza { get; set; }
        public DbSet<FollowingVeza> FollowingVeza { get; set; }
        public DbSet<ProgramVeza> ProgramVeza { get; set; }
        public DbSet<SavedVeza> SavedVeza { get; set; }
        public DbSet<Workout> Workout { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Day>().ToTable("Day");
            modelBuilder.Entity<ApplicationUser>().ToTable("ApplicationUser");
            modelBuilder.Entity<Program1>().ToTable("Program1");
            modelBuilder.Entity<DayVeza>().ToTable("DayVeza");
            modelBuilder.Entity<FollowingVeza>().ToTable("FollowingVeza");
            modelBuilder.Entity<ProgramVeza>().ToTable("ProgramVeza");
            modelBuilder.Entity<SavedVeza>().ToTable("SavedVeza");
            modelBuilder.Entity<Workout>().ToTable("Workout");
        
            base.OnModelCreating(modelBuilder);
        }
    }
}
