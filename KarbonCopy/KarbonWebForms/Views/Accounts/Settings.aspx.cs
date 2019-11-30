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
            string qRun = "UPDATE `account` SET `Theme`='dark' WHERE `Username`='" + Session["Username"].ToString() + "'";
            var command = new MySqlCommand(qRun, conn);
            command.ExecuteReader();
            conn.Close();
            Session["Theme"] = "dark";
            Response.Redirect("~/Views/Accounts/Settings.aspx");
        }

        protected void light_Click(object sender, EventArgs e)
        {
            var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
            conn.Open();
            string qRun = "UPDATE `account` SET `Theme`='light' WHERE `Username`='" + Session["Username"].ToString() + "'";
            var command = new MySqlCommand(qRun, conn);
            command.ExecuteReader();
            conn.Close();
            Session["Theme"] = "light";
            Response.Redirect("~/Views/Accounts/Settings.aspx");
        }

    }
}