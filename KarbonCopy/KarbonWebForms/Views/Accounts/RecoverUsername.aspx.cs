using System;
using KarbonWebForms.Sql;
using KarbonWebForms.Email;
using System.Diagnostics;
using static KarbonWebForms.Validators;

namespace KarbonWebForms.Views.Accounts
{
    public partial class RecoverUsername : System.Web.UI.Page
    {
        private readonly AccountSql accountSql = new AccountSql();
        private readonly EmailTool email = new EmailTool();

        protected async void RecoverMyUsername(object sender, EventArgs e)
        {
            string ErrorMessage = string.Empty;
            Account account = accountSql.GetWithEmail(EmailEnter.Text);
            if (account != null)
            {
                if (await email.SendEmail(account, "Username Recovery", $"Hello {account.FirstName},\n" +
                    $"you karbon username is {account.Username}.\n"))
                {
                    Debug.WriteLine("Email was sent to user email address.");
                    Session["Success"] = "Please check your email address for Username Recovery";
                    Response.Redirect("~/Views/Accounts/Login", false);
                }
                else
                {
                    Debug.WriteLine("Email FAILED to send");
                    ErrorMessage += $"Email FAILED to send {LineBreak}";
                }
            }
            else
            {
                Debug.WriteLine($"Account with the email {EmailEnter.Text} does not exist");
                ErrorMessage += $"Account with the email {EmailEnter.Text} does not exist {LineBreak}";

            }
            RecoveryUsernameError.Text = PreFormatError(ErrorMessage);
        }
    }
}