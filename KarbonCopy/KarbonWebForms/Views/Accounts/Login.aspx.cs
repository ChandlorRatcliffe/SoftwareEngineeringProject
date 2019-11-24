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

namespace CashewWebForms
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly AccountSql accountSql = new AccountSql();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Keep all SQL within MySqlFunctions with try/catch block.. if new function needed add to Functions Library
        protected void SignIn_Command(object sender, CommandEventArgs e)
        {
            //Web.config contains the connection string so it doesn't have to be initialized every time. the below is how to access it
            var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
            conn.Open();
            var command = new MySqlCommand("Select Username From Account Where (Username = @user)", conn);
            command.Parameters.Add(new MySqlParameter("user", MySqlDbType.VarChar) { Value = EnterUsername.Text });
            DataTable dt = new DataTable(command.ExecuteReader().ToString());
            foreach (DataRow row in dt.Rows) {
                Debug.WriteLine(row["Username"].ToString());
            }
        }

        protected void SignIn_Command2(object sender, CommandEventArgs e)
        {
            if(accountSql.Authenicate(EnterUsername.Text, EnterPassword.Text))
            {
                //If AUthenication SUccessful redirect to Dashboard
                Debug.WriteLine("SignIn_Command: Authenication Successful");
            }
            else
            {
                //Generate Validation Error
                Debug.WriteLine("SignIn_Command: Authenication Failed");
            }
        }

    }
}