using Pomelo.EntityFrameworkCore.MySql;
using Microsoft.EntityFrameworkCore;
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

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationAbility> OrganizationAbilities { get; set; }
        public DbSet<ProjectAbility> ProjectAbilities { get; set; }
        public DbSet<TaskAbility> TaskAbilities { get; set; }
               
        //Eventually remove this as its in appsettings.json
        public static readonly string SqlDatabase = "server=shsuse.mysql.database.azure.com;user=cashewclub@shsuse;database=shsuse;port=3306;password=D1ipDan*gDelux5e;";
       
        protected override void OnModelCreating(ModelBuilder modelBuilder) { // adds the composite key Username,Email to the Account model
            modelBuilder.Entity<Account>().HasKey(a => new { a.Username, a.Email});
        }
    }
}
