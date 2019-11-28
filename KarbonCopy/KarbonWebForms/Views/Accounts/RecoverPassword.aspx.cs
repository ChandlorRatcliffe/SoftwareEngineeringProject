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
    public partial class RecoverPassword : System.Web.UI.Page
    {
        private readonly AccountSql accountSql = new AccountSql();
        private readonly EmailTool email = new EmailTool();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void RecoverMyPassword(object sender, EventArgs e)
        {
            string passwordRecoveryToken = "{Needs to be Implemented}";


            if (string.IsNullOrWhiteSpace(EmailEnter.Text))
            {
                Account account = accountSql.Get(UsernameEnter.Text);
                if (account != null)
                {
                    if (await email.SendEmail(account, "Password Recovery", $"Hello {account.FirstName},\n" +
                        $"you karbon password recovery token is is {passwordRecoveryToken}.\n"))
                    {
                        Debug.WriteLine("Email was sent to user email address.");
                        Response.Redirect("~/Views/Accounts/Login", false);
                    }
                    else
                    {
                        Debug.WriteLine("Email has FAILED send to user email address.");
                        Response.Redirect("~/Views/Accounts/Login", false);
                    }
                }
                else
                {
                    Debug.WriteLine($"Account with the email {EmailEnter.Text} does not exists. Redirected to Login.. Needs Validation.");
                    Response.Redirect("~/Views/Accounts/Login", false);
                }
            }
            else
            {
                Account account = accountSql.GetWithEmail(EmailEnter.Text);
                if (account != null)
                {
                    await email.SendEmail(account, "Password Recovery", $"Hello {account.FirstName},\n" +
                        $"you karbon password recovery token is is {passwordRecoveryToken}.\n");
                    Debug.WriteLine("Email was sent to users email address.");
                    Response.Redirect("~/Views/Accounts/Login", false);
                }
                else
                {
                    Debug.WriteLine($"Account with the email {EmailEnter.Text} does not exists. Redirected to Login.. Needs Validation.");
                    Response.Redirect("~/Views/Accounts/Login", false);
                }
            }
        }
    }
}