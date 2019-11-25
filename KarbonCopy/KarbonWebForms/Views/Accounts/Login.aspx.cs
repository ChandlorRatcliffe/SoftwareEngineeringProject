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

namespace CashewWebForms
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignIn_Command(object sender, CommandEventArgs e)
        {
            //Web.config contains the connection string so it doesn't have to be initialized every time. the below is how to access it
            var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
            conn.Open();
            var command = new MySqlCommand("Select Username, Email, Password From Account Where (Username = @user AND Password = @pass);", conn);
            command.Parameters.Add(new MySqlParameter("user", MySqlDbType.VarChar) { Value = EnterUsername.Text });
            command.Parameters.Add(new MySqlParameter("pass", MySqlDbType.VarChar) { Value = EnterPassword.Text });
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            if (dt.Rows != null){ // the account with username/password exists and it matches
                Session["Username"] = EnterUsername.Text;
                Session["Email"] = dt.Rows[0][1]; // first row, second index because 0 = Username, 1 = Email, 2 = Password
                Response.Redirect("~/Views/Projects/Projects");
            } else {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alert", "Your Message", true);
            }
        }
    }
}