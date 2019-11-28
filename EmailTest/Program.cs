using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailTest.Email;
using EmailTest.Sql;

namespace EmailTest
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailTool emailTool = new EmailTool();
            Account account = new Account("username", "armyjonesn@gmail.com", "fname", "lname", "password", "");
            emailTool.SendEmail(account, "test", "test1234").Wait();
        }
    }
}
