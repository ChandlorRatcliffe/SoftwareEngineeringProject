using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Diagnostics;

namespace KarbonWebForms.Views.Tasks
{
    public partial class TaskPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TaskContent_PreRender(object sender, EventArgs e)
        {
            try
            {
                //Web.config contains the connection string so it doesn't have to be initialized every time. the below is how to access it
                var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
                var command = new MySqlCommand("Select TaskId, TaskDescription, TaskDeadline From Task Where (TaskId=@TId);", conn);
                command.Parameters.Add(new MySqlParameter("TId", MySqlDbType.VarChar) { Value = Session["TaskId"] });
                DataTable dt = new DataTable();
                conn.Open();
                dt.Load(command.ExecuteReader());
                if (dt.Rows.Count != 0)
                { // the account with username/password exists and it matches
                    Description.InnerText = dt.Rows[0][1].ToString(); // [1] is TaskDescription
                    Deadline.InnerText = dt.Rows[0][2].ToString(); // [2] is TaskDeadline
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alert", "Task information could not be loaded.", true);
                }
                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.StackTrace);
            }
        }

        protected void editModal_PreRender(object sender, EventArgs e)
        {
            try
            {
                var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
                var command = new MySqlCommand("Select TaskId, TaskDescription, TaskDeadline From Task Where (TaskId=@TId);", conn);
                command.Parameters.Add(new MySqlParameter("TId", MySqlDbType.VarChar) { Value = Session["TaskId"] });
                DataTable dt = new DataTable();
                conn.Open();
                dt.Load(command.ExecuteReader());
                if (dt.Rows.Count != 0)
                {
                    editModalDL.Text = dt.Rows[0]["TaskDeadline"].ToString();
                    editModalDesc.Text = dt.Rows[0]["TaskDescription"].ToString();
                }
                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.StackTrace);
            }
        }

        protected void editModalSave_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
                var command = new MySqlCommand("Update Task Set TaskDescription=@TDesc, TaskDeadline=@TDL Where (TaskId=@TId);", conn);
                command.Parameters.Add(new MySqlParameter("TId", MySqlDbType.VarChar) { Value = Session["TaskId"] });
                command.Parameters.Add(new MySqlParameter("TDesc", MySqlDbType.VarChar) { Value = editModalDesc.Text });
                command.Parameters.Add(new MySqlParameter("TDL", MySqlDbType.DateTime) { Value = DateTime.Parse(editModalDL.Text) });
                conn.Open();
                command.ExecuteNonQuery(); // execute command
                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.StackTrace);
            }
        }

        protected void noteModalSave_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
                var command = new MySqlCommand("Insert INTO NotesPosted (Text, TimeStamp, Username, Email, TaskId) VALUES @noteBody, @TS, @user, @email, @TId;", conn);
                command.Parameters.Add(new MySqlParameter("noteBody", MySqlDbType.VarChar) { Value = noteModalBody.Text });
                command.Parameters.Add(new MySqlParameter("TS", MySqlDbType.DateTime) { Value = DateTime.Now });
                command.Parameters.Add(new MySqlParameter("user", MySqlDbType.VarChar) { Value = Session["Username"] });
                command.Parameters.Add(new MySqlParameter("email", MySqlDbType.VarChar) { Value = Session["Email"] });
                command.Parameters.Add(new MySqlParameter("TId", MySqlDbType.VarChar) { Value = Session["TaskId"] });
                conn.Open();
                command.ExecuteNonQuery(); // execute command
                conn.Close();
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.StackTrace);
            }
        }
    }
}