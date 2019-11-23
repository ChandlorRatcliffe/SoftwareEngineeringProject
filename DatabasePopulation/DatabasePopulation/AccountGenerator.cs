using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasePopulation
{
    class AccountGenerator
    {
        WordListManager words;
        public AccountGenerator()
        {
            words = new WordListManager();
        }
        public AccountGenerator(WordListManager words)
        {
            this.words = words;
        }
        public Account newAccount()
        {
            string firstName = words.getName();
            string lastName = words.getName();
            string password = words.getName();
            return new Account(firstName, lastName, password);
        }
        public List<Account> generateAccounts(int number)
        {
            List<Account> accounts = new List<Account>();
            for(int i = 0; i < number; i++)
            {
                accounts.Add(newAccount());
            }
            return accounts;
        }
    }
}
