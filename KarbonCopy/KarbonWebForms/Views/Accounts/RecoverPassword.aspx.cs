using System;
using KarbonWebForms.Sql;
using KarbonWebForms.Email;
using System.Diagnostics;
using static KarbonWebForms.Validators;

namespace KarbonWebForms.Views.Accounts
{
    public partial class RecoverPassword : System.Web.UI.Page
    {
        private readonly AccountSql accountSql = new AccountSql();
        private readonly EmailTool emailTool = new EmailTool();

        protected async void RecoverMyPassword(object sender, EventArgs e)
        {
            string PasswordVerficationUrl = $"https://{Request.Url.Host}:{Request.Url.Port}/Views/Accounts/ChangePasswordVerification";
            string ErrorMessage = string.Empty;
            if (string.IsNullOrWhiteSpace(EmailEnter.Text))
            {
                Account account = accountSql.Get(UsernameEnter.Text);
                if (account != null)
                {
                    if (await emailTool.SendEmail(account, "Password Change Request", "",
                    $"Hello {account.FirstName}, <br> your karbon password change token is {passwordRecoveryToken} <br> {PasswordVerficationUrl}"))
                    {
                        Debug.WriteLine("Email was sent to user email address.");
                        Session["Success"] = "Please check your email address for Password Recovery";
                        Response.Redirect("~/Views/Accounts/Login", false);
                    }
                    else
                    {
                        Debug.WriteLine("Email FAILED to send");
                        ErrorMessage += $"Email FAILED to send {LineBreak}";
                        Response.Redirect("~/Views/Accounts/Login", false);
                    }
                }
                else
                {
                    Debug.WriteLine($"Account with the username {UsernameEnter.Text} does not exist");
                    ErrorMessage += $"Account with the username {UsernameEnter.Text} does not exist {LineBreak}";
                }
            }
            else
            {
                Account account = accountSql.GetWithEmail(EmailEnter.Text);
                if (account != null)
                {
                    await emailTool.SendEmail(account, "Password Recovery", "", $"Hello {account.FirstName},\n" +
                        $"you karbon password recovery token is is {passwordRecoveryToken} <br> {PasswordVerficationUrl}\n");
                    Debug.WriteLine("Email was sent to users email address.");
                    Response.Redirect("~/Views/Accounts/Login", false);
                }
                else
                {
                    Debug.WriteLine($"Account with the email {EmailEnter.Text} does not exist");
                    ErrorMessage += $"Account with the email {EmailEnter.Text} does not exist {LineBreak}";

                }
            }
            RecoveryPasswordError.Text = PreFormatError(ErrorMessage);
        }
    }
}