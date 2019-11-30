using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
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
            try
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
            catch (Exception exc)
            {
                Debug.WriteLine(exc.StackTrace);
            }
        }

        protected void light_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception exc)
            {
                Debug.WriteLine(exc.StackTrace);
            }
        }

        protected void changeUsername_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
                conn.Open();
                var trans = conn.BeginTransaction();
                string qRun = "UPDATE `account` SET `Username`=@newUser WHERE `Username`='" + Session["Username"].ToString() + "';";
                var command = new MySqlCommand(qRun, conn);
                command.Parameters.Add(new MySqlParameter("newUser", MySqlDbType.VarChar) { Value = changeUser.Text });
                command.ExecuteNonQuery();
                qRun = "UPDATE `Creates` SET `Username`=@newUser WHERE `Username`='" + Session["Username"].ToString() + "';";
                command = new MySqlCommand(qRun, conn);
                command.Parameters.Add(new MySqlParameter("newUser", MySqlDbType.VarChar) { Value = changeUser.Text });
                command.ExecuteNonQuery();
                qRun = "UPDATE `NotesPosted` SET `Username`=@newUser WHERE `Username`='" + Session["Username"].ToString() + "';";
                command = new MySqlCommand(qRun, conn);
                command.Parameters.Add(new MySqlParameter("newUser", MySqlDbType.VarChar) { Value = changeUser.Text });
                command.ExecuteNonQuery();
                qRun = "UPDATE `OrganizationAbilities` SET `Username`=@newUser WHERE `Username`='" + Session["Username"].ToString() + "';";
                command = new MySqlCommand(qRun, conn);
                command.Parameters.Add(new MySqlParameter("newUser", MySqlDbType.VarChar) { Value = changeUser.Text });
                command.ExecuteNonQuery();
                qRun = "UPDATE `ProjectAbilities` SET `Username`=@newUser WHERE `Username`='" + Session["Username"].ToString() + "';";
                command = new MySqlCommand(qRun, conn);
                command.Parameters.Add(new MySqlParameter("newUser", MySqlDbType.VarChar) { Value = changeUser.Text });
                command.ExecuteNonQuery();
                qRun = "UPDATE `ProjectAssigned` SET `Username`=@newUser WHERE `Username`='" + Session["Username"].ToString() + "';";
                command = new MySqlCommand(qRun, conn);
                command.Parameters.Add(new MySqlParameter("newUser", MySqlDbType.VarChar) { Value = changeUser.Text });
                command.ExecuteNonQuery();
                qRun = "UPDATE `TaskAbilities` SET `Username`=@newUser WHERE `Username`='" + Session["Username"].ToString() + "';";
                command = new MySqlCommand(qRun, conn);
                command.Parameters.Add(new MySqlParameter("newUser", MySqlDbType.VarChar) { Value = changeUser.Text });
                command.ExecuteNonQuery();
                qRun = "UPDATE `TaskAssigned` SET `Username`=@newUser WHERE `Username`='" + Session["Username"].ToString() + "';";
                command = new MySqlCommand(qRun, conn);
                command.Parameters.Add(new MySqlParameter("newUser", MySqlDbType.VarChar) { Value = changeUser.Text });
                command.ExecuteNonQuery();
                trans.Commit();
                conn.Close();
                Session["Username"] = changeUser.Text;
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.StackTrace);
            }
        }

        protected void changeEmail_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
                conn.Open();
                string qRun = "UPDATE `account` SET `Email`=@email WHERE `Username`='" + Session["Username"].ToString() + "';";
                var command = new MySqlCommand(qRun, conn);
                command.Parameters.Add(new MySqlParameter("email", MySqlDbType.VarChar) { Value = changeEmail.Text });
                command.ExecuteReader();
                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.StackTrace);
            }
        }

        protected void changePassword_Click(object sender, EventArgs e)
        {
            if (confirmPassword.Text == changePassword.Text)
            {
                try
                {
                    var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
                    conn.Open();
                    string qRun = "UPDATE `account` SET `Password`=@pw WHERE `Username`='" + Session["Username"].ToString() + "';";
                    var command = new MySqlCommand(qRun, conn);
                    command.Parameters.Add(new MySqlParameter("pw", MySqlDbType.VarChar) { Value = changePassword.Text });
                    command.ExecuteReader();
                    conn.Close();
                }
                catch (Exception exc)
                {
                    Debug.WriteLine(exc.StackTrace);
                }
            }
        }
    }
}