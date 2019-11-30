using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using KarbonWebForms.Sql;
using static KarbonWebForms.Validators;
using System;

namespace KarbonWebForms.Views.Accounts
{
    public partial class Login : Page
    {
        private readonly AccountSql accountSql = new AccountSql();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Session["Success"] as string))
            {
                LoginSuccess.Text = Session["Success"].ToString();
            }
        }

        protected void SignIn_Command(object sender, CommandEventArgs e)
        {
            if (accountSql.Authenticate(EnterUsername.Text, EnterPassword.Text))
            {
                Debug.WriteLine("Account was able to authenticate");
                Account account = accountSql.Get(EnterUsername.Text);

                if (account.Skills.Contains("false"))
                {
                    LoginError.Text = PreFormatError("Please verify your email address");
                }
                else
                {
                    Debug.WriteLine("Email Verified");
                    Session["Username"] = account.Username;
                    Session["Email"] = account.Email;
                    Response.Redirect("/Views/Projects/Projects");
                }
            }
            else
            {
                LoginError.Text = PreFormatError("Unable to Authenticate");
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "alert", "Your Message", true);
            }
        }
    }
}