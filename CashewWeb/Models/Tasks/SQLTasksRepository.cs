using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    /// <summary>
    /// Tasks Methods for use with SQL Server,  Creator: Nicholas Jones
    /// </summary>
    public class SQLTasksRepository : ITasksRepository
    {
        private readonly AppDbContext context;

        /// <summary>
        /// Adds DbCOntext to Tasks Repository
        /// </summary>
        /// <param name="context"></param>
        public SQLTasksRepository(AppDbContext context)
        {
            this.context = context;
        }


    }
}
