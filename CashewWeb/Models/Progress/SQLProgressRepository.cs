using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    /// <summary>
    /// Progress Methods for use with SQL Server,  Creator: Nicholas Jones
    /// </summary>
    public class SQLProgressRepository : IProgressRepository
    {
        private readonly AppDbContext context;

        /// <summary>
        /// Adds DbCOntext to Progress Repository
        /// </summary>
        /// <param name="context"></param>
        public SQLProgressRepository(AppDbContext context)
        {
            this.context = context;
        }


    }
}
