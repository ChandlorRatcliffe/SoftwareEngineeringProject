using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    /// <summary>
    /// Home Methods for use with SQL Server,  Creator: Nicholas Jones
    /// </summary>
    public class SQLHomeRepository : IHomeRepository
    {
        private readonly AppDbContext context;

        /// <summary>
        /// Adds DbCOntext to Home Repository
        /// </summary>
        /// <param name="context"></param>
        public SQLHomeRepository(AppDbContext context)
        {
            this.context = context;
        }

       
    }
}
