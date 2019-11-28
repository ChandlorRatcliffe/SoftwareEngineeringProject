using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KarbonWebForms.Sql;
using KarbonWebForms.Email;
using System.Text.RegularExpressions;
using static KarbonWebForms.Validators;

namespace KarbonWebForms.Views.Accounts
{
    public partial class Create : Page
    {
        private readonly AccountSql accountSql = new AccountSql();
        private readonly EmailTool emailTool = new EmailTool();
        //make dynamic
        private readonly string verfToken = "38749384";
        private readonly string LineBreak = "&#013;&#010;";

        protected async void CreateAccount(object sender, EventArgs e)
        {
            //make dynamic
            string URL = $"https://{Request.Url.Host}:{Request.Url.Port}/Views/Accounts/Verification";
            string ErrorMessage = "";
            if (IsValidName(FirstName.Text))
                ErrorMessage += $"First Name should only contain characters {LineBreak}";
            if (IsValidName(LastName.Text))
                ErrorMessage += $"Last Name should only contain characters {LineBreak}";
            if (IsValidUsername(Username.Text))
                ErrorMessage += $"Invalid Username format {LineBreak}";
            if (IsValidEmail(Email.Text))
                ErrorMessage += $"Invalid Email Format {LineBreak}";
            if (IsValidPassword(Password.Text))
                ErrorMessage += $"Invalid Password Format {LineBreak}";

            Debug.WriteLine(ErrorMessage);

            if (Password.Text == ConfirmPassword.Text && string.IsNullOrEmpty(ErrorMessage))
            {
                Account account = new Account
                {
                    Username = Username.Text,
                    Email = Email.Text,
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    Password = Password.Text,
                    Skills = "false" //Not Verified
                };
                if (await emailTool.SendEmail(account, "Account Verification", "",
                    $"Hello {account.FirstName}, <br> your karbon activation token is {verfToken} <br> {URL}"))
                {
                    accountSql.Insert(account);
                    Debug.WriteLine("Verfication Token successfully sent and account added.");
                    Response.Redirect("~/Views/Accounts/Login", false);
                }
                else
                {
                    CreateError.Text += "Error: unable to send email";
                    Debug.WriteLine("Error: unable to send email");
                }
            }
            else
            {
                CreateError.Text += "Error: passwords did not match.";
                Debug.WriteLine("Error: passwords did not match");
            }

            ErrorMessage = $"<pre class=\"text-danger\">{ErrorMessage}</pre>";
            CreateError.Text = ErrorMessage;
        }

    }
}
