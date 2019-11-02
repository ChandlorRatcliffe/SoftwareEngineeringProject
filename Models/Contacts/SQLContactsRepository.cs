using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    /// <summary>
    /// Contacts Methods for use with SQL Server,  Creator: Nicholas Jones
    /// </summary>
    public class SQLContactsRepository : IContactsRepository
    {
        private readonly AppDbContext context;

        /// <summary>
        /// Adds DbCOntext to Contacts Repository
        /// </summary>
        /// <param name="context"></param>
        public SQLContactsRepository(AppDbContext context)
        {
            this.context = context;
        }


    }
}
