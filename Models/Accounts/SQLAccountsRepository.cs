using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    /// <summary>
    /// Accounts Methods for use with SQL Server     Creator: Nicholas Jones
    /// </summary>
    public class SQLAccountsRepository : IAccountsRepository
    {
        private readonly AppDbContext context;

        /// <summary>
        /// Adds DbCOntext to Accounts Repository
        /// </summary>
        /// <param name="context"></param>
        public SQLAccountsRepository(AppDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Adds Accounts to Database
        /// </summary>
        /// <param name="Accounts"></param>
        /// <returns></returns>
        public Accounts Add(Accounts Accounts)
        {
            context.Accounts.Add(Accounts);
            context.SaveChanges();
            return Accounts;
        }

        /// <summary>
        /// Deletes Accounts in Database
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Accounts Delete(string username)
        {
            Accounts Accounts = context.Accounts.Find(username);
            if (Accounts != null)
            {
                context.Accounts.Remove(Accounts);
                context.SaveChanges();
            }
            return Accounts;
        }

        /// <summary>
        /// Gets Employee by Username in Database
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Accounts Get(string username)
        {
            return context.Accounts.Find(username);
        }

        /// <summary>
        /// Gets All Accountss from Database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Accounts> GetAll()
        {
            return context.Accounts;
        }

        /// <summary>
        /// Updates an Accounts in Database
        /// </summary>
        /// <param name="AccountsChanges"></param>
        /// <returns></returns>
        public Accounts Update(Accounts AccountsChanges)
        {
            var Accounts = context.Accounts.Attach(AccountsChanges);
            Accounts.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return AccountsChanges;
        }
    }
}
