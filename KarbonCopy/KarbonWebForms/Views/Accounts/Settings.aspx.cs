using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KarbonWebForms.Views.Accounts
{
    public partial class Settings : System.Web.UI.Page
    {
        protected void dark_Click(object sender, EventArgs e)
        {
            var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
            conn.Open();
            string qRun = "UPDATE `account` SET `Theme`='dark' WHERE `Username`='" + Session["Username"].ToString() + "';";
            var command = new MySqlCommand(qRun, conn);
            command.ExecuteReader();
            conn.Close();
            Session["Theme"] = "dark";
            Response.Redirect("/Views/Accounts/Settings.aspx");
        }

        protected void light_Click(object sender, EventArgs e)
        {
            var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
            conn.Open();
            string qRun = "UPDATE `account` SET `Theme`='light' WHERE `Username`='" + Session["Username"].ToString() + "';";
            var command = new MySqlCommand(qRun, conn);
            command.ExecuteReader();
            conn.Close();
            Session["Theme"] = "light";
            Response.Redirect("/Views/Accounts/Settings.aspx");
        }
		
		protected void changeUsername(object sender, EventArgs e)
		{
			var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
            conn.Open();
            string qRun = "UPDATE `account` SET `Username`=@newUser WHERE `Username`='" + Session["Username"].ToString() + "';";
            var command = new MySqlCommand(qRun, conn);
			command.Parameters.Add(new MySqlParameter("newUser", MySqlDbType.VarChar) { Value = changeUser.Text });
            command.ExecuteReader();
            conn.Close();
		}
		
		protected void changeEmail(object sender, EventArgs e)
		{
			var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
            conn.Open();
            string qRun = "UPDATE `account` SET `Email`=@email WHERE `Username`='" + Session["Username"].ToString() + "';";
            var command = new MySqlCommand(qRun, conn);
			command.Parameters.Add(new MySqlParameter("email", MySqlDbType.VarChar) { Value = changeEmail.Text });
            command.ExecuteReader();
            conn.Close();
		}
		
		protected void changePassword(object sender, EventArgs e)
		{
			if (confirmPassword.Text == changePassword.Text)
			{
				var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
				conn.Open();
				string qRun = "UPDATE `account` SET `Password`=@pw WHERE `Username`='" + Session["Username"].ToString() + "';";
				var command = new MySqlCommand(qRun, conn);
				command.Parameters.Add(new MySqlParameter("pw", MySqlDbType.VarChar) { Value = changePassword.Text });
				command.ExecuteReader();
				conn.Close();
			}
		}
    }
}