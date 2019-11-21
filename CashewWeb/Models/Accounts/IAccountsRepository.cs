using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    /// <summary>
    /// User Accounts Interface Creator: Nicholas Jones
    /// </summary>
    public interface IAccountsRepository
    {
        Accounts Get(string username, string email);

        IEnumerable<Accounts> GetAll();

        Accounts Add(Accounts acount);

        Accounts Update(Accounts AccountsChanges);

        Accounts Delete(string username, string email);
    }
}
