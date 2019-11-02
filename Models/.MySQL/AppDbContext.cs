using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Accounts> Organizations { get; set; }
        public DbSet<Accounts> Projects { get; set; }
        public DbSet<Accounts> Tasks { get; set; }
        public DbSet<Accounts> Parents { get; set; }
        public DbSet<Accounts> OrganizationAbilities { get; set; }
        public DbSet<Accounts> ProjectAbilities { get; set; }
        public DbSet<Accounts> TaskAbilities { get; set; }

        /// <summary>
        /// Overrides the EntityFrameworkCore OnModelCreating Method to Include Compound Keys.. Creator: Nicholas Jones
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Assign Primary Keys and Compound Keys
            modelBuilder.Entity<Accounts>().HasKey(c => new { c.Username, c.Email });
            modelBuilder.Entity<Organizations>().HasKey(c => new { c.Name });
            modelBuilder.Entity<Projects>().HasKey(c => new { c.ProjectId });
            modelBuilder.Entity<Tasks>().HasKey(c => new { c.TaskId });
            modelBuilder.Entity<Parents>().HasKey(c => new { c.ParentId });
            modelBuilder.Entity<OrganizationAbilities>().HasKey(c => new { c.Username, c.Email, c.Name });
            modelBuilder.Entity<ProjectAbilities>().HasKey(c => new { c.Username, c.Email, c.ProjectId });
            modelBuilder.Entity<TaskAbilities>().HasKey(c => new { c.Username, c.Email, c.TaskId });

        }
        
    }
}
