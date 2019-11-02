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

        public DbSet<Accounts> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>().HasKey(c => new { c.Username, c.Email });
            modelBuilder.Entity<Organizations>().HasKey(c => new { c.Name });
            modelBuilder.Entity<Projects>().HasKey(c => new { c.ProjectId });
            modelBuilder.Entity<Tasks>().HasKey(c => new { c.TaskId });
            modelBuilder.Entity<Parents>().HasKey(c => new { c.ParentId });
            modelBuilder.Entity<OrganizationAbilities>().HasKey(c => new { c.Username, c.Email, c.Name });
            modelBuilder.Entity<ProjectAbilities>().HasKey(c => new { c.Username, c.Email, c.ProjectId });
            modelBuilder.Entity<TaskAbilities>().HasKey(c => new { c.Username, c.Email, c.TaskId });

        }

        //Eventually remove this as its in appsettings.json
        public static readonly string SqlDatabase = "server=shsuse.mysql.database.azure.com;user=cashewclub@shsuse;database=shsuse;port=3306;password=D1ipDan*gDelux5e;";
    }
}
