using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    /// <summary>
    /// Tasks Methods for use with SQL Server,  Creator: Nicholas Jones
    /// </summary>
    public class SQLTaskRepository : ITaskRepository
    {
        private readonly AppDbContext context;

        /// <summary>
        /// Adds DbCOntext to Tasks Repository
        /// </summary>
        /// <param name="context"></param>
        public SQLTaskRepository(AppDbContext context)
        {
            this.context = context;
        }


    }
}
