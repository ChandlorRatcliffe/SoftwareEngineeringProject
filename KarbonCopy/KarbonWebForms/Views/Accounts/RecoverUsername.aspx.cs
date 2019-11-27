using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KarbonWebForms.Sql;
using KarbonWebForms.Email;
using System.Diagnostics;

namespace KarbonWebForms.Views.Accounts
{
    public partial class RecoverUsername : System.Web.UI.Page
    {
        private readonly AccountSql accountSql = new AccountSql();
        private readonly MySqlFunctions sqlFunctions = new MySqlFunctions();
        private readonly EmailTool email = new EmailTool();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void Recover(object sender, EventArgs e)
        {
            if (accountSql.ExistsWithEmail(EmailEnter.Text))
            {
                Debug.WriteLine("Email Exists.");
                Account account = accountSql.GetWithEmail(EmailEnter.Text);
                await email.SendEmail(account, "Username Recovery", $"Hello {account.FirstName},\n" +
                    $"you karbon username is {account.Username}.\n");
                Debug.WriteLine("Email was sent to users email address.");
                Response.Redirect("~/Views/Accounts/Login");
            }
            else
            {
                Debug.WriteLine("Account with the email {EmailEnter.Text} does not exists. Redirected to Login.. Needs Validation.");
                Response.Redirect("~/Views/Accounts/Login");
            }

        }
    }
}