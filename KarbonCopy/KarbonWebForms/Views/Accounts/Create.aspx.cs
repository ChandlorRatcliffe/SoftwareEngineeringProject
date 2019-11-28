using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using KarbonWebForms.Sql;

namespace KarbonWebForms.Views.Accounts
{
    public partial class Create : Page
    {
        private readonly AccountSql accountSql = new AccountSql();
        private readonly EmailTool emailTool = new EmailTool();
        //make dynamic
        private readonly string verfToken = "38749384";


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateAccount(object sender, EventArgs e)
        {
            //make dynamic
            string URL = $"https://{Request.Url.Host}:{Request.Url.Port}/Views/Accounts/Verification";

            if (Password.Text == ConfirmPassword.Text)
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
                    Debug.WriteLine("Unable to send Email. Account not added.");
                    Response.Redirect("~/Views/Accounts/Login", false);
                }
            }
            else
            {
                //Validate Error Passwords don't match
                Response.Redirect("~/Views/Accounts/Login", false);
            }
        }

    }
}
