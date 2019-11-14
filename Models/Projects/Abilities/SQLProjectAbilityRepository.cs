using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    /// <summary>
    /// Notes Methods for use with SQL Server,  Creator: Nicholas Jones
    /// </summary>
    public class SQLProjectAbilityRepository : IProjectAbilityRepository
    {
        private readonly AppDbContext context;

        /// <summary>
        /// Adds DbCOntext to Notes Repository
        /// </summary>
        /// <param name="context"></param>
        public SQLProjectAbilityRepository(AppDbContext context)
        {
            this.context = context;
        }


    }
}
