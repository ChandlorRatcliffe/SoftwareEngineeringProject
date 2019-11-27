using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Diagnostics;
using KarbonWebForms.Sql;

namespace KarbonWebForms.Views.Accounts
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly AccountSql accountSql = new AccountSql();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignIn_Command(object sender, CommandEventArgs e)
        {
            if (accountSql.Authenticate(EnterUsername.Text, EnterPassword.Text))
            {
                Debug.WriteLine("Account was able to authenticate");
                Account account = accountSql.Get(EnterUsername.Text);

                if (account.Skills.Contains("false"))
                {
                    Debug.WriteLine("Email Not Verified");
                    Response.Redirect("/Views/Accounts/Login", false);
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
                Debug.WriteLine("Account unable to authenticate");
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "alert", "Your Message", true);
            }
        }



        /*
            //Web.config contains the connection string so it doesn't have to be initialized every time. the below is how to access it
            var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
            conn.Open();
            var command = new MySqlCommand("Select Username, Email, Password, Theme From Account Where (Username = @user AND Password = @pass);", conn);
            command.Parameters.Add(new MySqlParameter("user", MySqlDbType.VarChar) { Value = EnterUsername.Text });
            command.Parameters.Add(new MySqlParameter("pass", MySqlDbType.VarChar) { Value = EnterPassword.Text });
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            if (dt.Rows.Count != 0){ // the account with username/password exists and it matches
                Session["Username"] = EnterUsername.Text;
                Session["Email"] = dt.Rows[0][1]; // first row, second index because 0 = Username, 1 = Email, 2 = Password
                Session["Theme"] = dt.Rows[0][3];
                Response.Redirect("~/Views/Projects/Projects");
            } else {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alert", "Your Message", true);
            }
            */
    }
}