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

        public DbSet<Account> Account { get; set; }




        //Eventually remove this as its in appsettings.json
        public static readonly string SqlDatabase = "server=shsuse.mysql.database.azure.com;user=cashewclub@shsuse;database=shsuse;port=3306;password=D1ipDan*gDelux5e;";
    }
}
