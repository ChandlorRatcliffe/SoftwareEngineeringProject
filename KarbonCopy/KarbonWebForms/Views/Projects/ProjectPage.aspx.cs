using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace KarbonWebForms.Views.Projects
{
    public partial class ProjectPage : System.Web.UI.Page
    {
        protected void MemberRptr_PreRender(object sender, EventArgs e)
        {
            var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
            var command = new MySqlCommand("Select Username From ProjectAssigned Where (ProjectId=@PId AND Username<>@user);", conn);
            command.Parameters.Add(new MySqlParameter("PId", MySqlDbType.VarChar) { Value = Session["ProjectId"] });
            command.Parameters.Add(new MySqlParameter("user", MySqlDbType.VarChar) { Value = Session["Username"] });
            DataTable dt = new DataTable();
            conn.Open();
            dt.Load(command.ExecuteReader());
            if (dt.Rows.Count != 0)
            {
                // MemberRptr will now be assigned tuples from the database to repeat on, received from DataTable dt
                // Repeater hasn't been initialized yet: data has to be retrieved before it's loaded to actually have data to repeat on
                MemberRptr.DataSource = dt;
                // Data has to be bound to the repeater before finishing the assignment of data to the repeater
                MemberRptr.DataBind();
            }
            conn.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Web.config contains the connection string so it doesn't have to be initialized every time. the below is how to access it
            var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
            var command = new MySqlCommand("Select ProjectId, ProjectDescription, ProjectDeadline From Project Where (ProjectId=@PId);", conn);
            command.Parameters.Add(new MySqlParameter("PId", MySqlDbType.VarChar) { Value = Session["ProjectId"] });
            DataTable dt = new DataTable();
            conn.Open();
            dt.Load(command.ExecuteReader());
            if (dt.Rows[0] != null)
            { // the account with username/password exists and it matches
                Description.InnerText = dt.Rows[0][1].ToString(); // [1] is ProjectDescription
                Deadline.InnerText = dt.Rows[0][2].ToString(); // [2] is ProjectDeadline
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alert", "Your Message", true);
            }
            conn.Close();
        }

        protected void UpdateBtn_Clicked(object sender, EventArgs e){
            
        }
    }
}