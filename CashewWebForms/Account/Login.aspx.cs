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
            var command = new MySqlCommand("Select Username From Account Where (Username = @user)", conn);
            command.Parameters.Add(new MySqlParameter("user", MySqlDataType.VarChar) { ValueType = EnterUsername.Text });
            DataTable dt = new DataTable(command.ExecuteReader().ToString());
            foreach (DataRow row in dt.Rows) {
                Debug.WriteLine(row["Username"].ToString());
            }
        }
    }
}