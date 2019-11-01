using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    /// <summary>
    /// Account Methods for use with SQL Server     Creator: Nicholas Jones
    /// </summary>
    public class SQLAccountRepository : IAccountRepository
    {
        private readonly AppDbContext context;

        /// <summary>
        /// Adds DbCOntext to Account Repository
        /// </summary>
        /// <param name="context"></param>
        public SQLAccountRepository(AppDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Adds Account to Database
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public Account Add(Account account)
        {
            context.Account.Add(account);
            context.SaveChanges();
            return account;
        }

        /// <summary>
        /// Deletes Account in Database
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Account Delete(string username)
        {
            Account account = context.Account.Find(username);
            if (account != null)
            {
                context.Account.Remove(account);
                context.SaveChanges();
            }
            return account;
        }

        /// <summary>
        /// Gets Employee by Username in Database
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public Account Get(string username)
        {
            return context.Account.Find(username);
        }

        /// <summary>
        /// Gets All Accounts from Database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Account> GetAll()
        {
            return context.Account;
        }

        /// <summary>
        /// Updates an account in Database
        /// </summary>
        /// <param name="accountChanges"></param>
        /// <returns></returns>
        public Account Update(Account accountChanges)
        {
            var account = context.Account.Attach(accountChanges);
            account.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return accountChanges;
        }
    }
}
