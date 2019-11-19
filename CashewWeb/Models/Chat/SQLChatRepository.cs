using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    /// <summary>
    /// Chat Methods for use with SQL Server,  Creator: Nicholas Jones
    /// </summary>
    public class SQLChatRepository : IChatRepository
    {
        private readonly AppDbContext context;

        /// <summary>
        /// Adds DbCOntext to Chat Repository
        /// </summary>
        /// <param name="context"></param>
        public SQLChatRepository(AppDbContext context)
        {
            this.context = context;
        }


    }
}
