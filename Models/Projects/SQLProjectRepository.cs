using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    /// <summary>
    /// Projects Methods for use with SQL Server,  Creator: Nicholas Jones
    /// </summary>
    public class SQLProjectRepository : IProjectRepository
    {
        private readonly AppDbContext context;

        /// <summary>
        /// Adds DbCOntext to Projects Repository
        /// </summary>
        /// <param name="context"></param>
        public SQLProjectRepository(AppDbContext context)
        {
            this.context = context;
        }


    }
}
