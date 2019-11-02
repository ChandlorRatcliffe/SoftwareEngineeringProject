using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    /// <summary>
    /// Search Methods for use with SQL Server,  Creator: Nicholas Jones
    /// </summary>
    public class SQLSearchRepository : ISearchRepository
    {
        private readonly AppDbContext context;

        /// <summary>
        /// Adds DbCOntext to Search Repository
        /// </summary>
        /// <param name="context"></param>
        public SQLSearchRepository(AppDbContext context)
        {
            this.context = context;
        }


    }
}
