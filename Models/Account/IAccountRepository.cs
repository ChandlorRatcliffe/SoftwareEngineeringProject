using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    /// <summary>
    /// User Account Interface Creator: Nicholas Jones
    /// </summary>
    public interface IAccountRepository
    {
        Account Get(string username);

        IEnumerable<Account> GetAll();

        Account Add(Account acount);

        Account Update(Account accountChanges);

        Account Delete(string username);
    }
}
