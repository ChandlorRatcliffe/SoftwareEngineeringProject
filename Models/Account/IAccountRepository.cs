using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NimbleWeb.Models
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAll();
        Account Get(int Id);
        Account Add(Account acount);
    }
}
