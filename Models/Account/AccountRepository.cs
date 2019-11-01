using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CashewWeb.Models.AppDbContext;

using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace CashewWeb.Models
{
    public class AccountRepository : IAccountRepository
    {
        public AccountRepository()
        {

        }

        /// <summary>
        /// Gets Account Information from Database Creator: Nicholas Jones
        /// </summary>
        /// <param name="username">The username of the user you wish to retrieve</param>
        /// <returns>Account Object blank if errors</returns>
        public Account Get(string username)
        {
            return new Account();
        }

        /// <summary>
        /// Gets All Accounts from the user Database Table Creator: Nicholas Jones
        /// </summary>
        /// <returns>IEnumerable Account</returns>
        public IEnumerable<Account> GetAll()
        {
            return null;
        }

        /// <summary>
        /// Adds Account to Database
        /// </summary>
        /// <param name="account">Account Object to Store</param>
        /// <returns>Account for Reference or null if unsuccessful</returns>
        public Account Add(Account account)
        {
            return account;
        }

        public Account Update(Account accountChanges)
        {
            return accountChanges;
        }

        public Account Delete(string username)
        {
            return new Account();
        }

    }
}
