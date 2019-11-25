using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KarbonWebForms.Sql;

namespace KarbonWebForms.Views.Accounts
{
    public partial class Create : Page
    {
        private readonly AccountSql accountSql = new AccountSql();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateAccount(object sender, EventArgs e)
        {
            if (Password.Text == ConfirmPassword.Text)
            {
                Account account = new Account
                {
                    Username = Username.Text,
                    Email = Email.Text,
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    Password = Password.Text
                };
                accountSql.Insert(account);
                //Redirect to Email Verfication Page NOT Implemented
                Debug.WriteLine("Redirect to Email Page Not Implemented");
                Response.Redirect("~/Views/Accounts/Login");
            }
            else
            {
                //Validate Error Passwords don't match
            }
        }

    }
}
