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
    /// <summary>
    /// Accounts Repository ... Been Migrated to SQL: Nicholas Jones
    /// </summary>
    public class AccountsRepository : IAccountsRepository
    {
        public AccountsRepository()
        {

        }

        /// <summary>
        /// Gets Accounts Information from Database Creator: Nicholas Jones
        /// </summary>
        /// <param name="username">The username of the user you wish to retrieve</param>
        /// <returns>Accounts Object blank if errors</returns>
        public Accounts Get(string username)
        {
            return new Accounts();
        }

        /// <summary>
        /// Gets All Accountss from the user Database Table Creator: Nicholas Jones
        /// </summary>
        /// <returns>IEnumerable Accounts</returns>
        public IEnumerable<Accounts> GetAll()
        {
            return null;
        }

        /// <summary>
        /// Adds Accounts to Database
        /// </summary>
        /// <param name="Accounts">Accounts Object to Store</param>
        /// <returns>Accounts for Reference or null if unsuccessful</returns>
        public Accounts Add(Accounts Accounts)
        {
            return Accounts;
        }

        public Accounts Update(Accounts AccountsChanges)
        {
            return AccountsChanges;
        }

        public Accounts Delete(string username)
        {
            return new Accounts();
        }

    }
}
