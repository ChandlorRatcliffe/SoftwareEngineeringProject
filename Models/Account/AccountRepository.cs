using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NimbleWeb.Models
{
    public class AccountRepository : IAccountRepository
    {
        private readonly List<Account> _accountList;

        public AccountRepository()
        {
            _accountList = new List<Account>()
            {
                new Account() { Id = 1 },
                new Account() { Id = 2 },
                new Account() { Id = 3 },
            };
        }

        public IEnumerable<Account> GetAll()
        {
            return _accountList;
        }

        public Account Get(int Id)
        {
            return _accountList.FirstOrDefault(e => e.Id == Id);
        }

        public Account Add(Account account)
        {
            account.Id = _accountList.Max(e => e.Id) + 1;
            _accountList.Add(account);
            return account;
        }


    }
}
