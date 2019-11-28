using KarbonWebForms.Sql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KarbonWebForms.Views.Tasks
{
    public partial class Index : System.Web.UI.Page
    {
        private readonly TaskSql taskSql = new TaskSql();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void TaskCardRptr_Click(object sender, EventArgs e) {
            Session["TaskId"] = ((LinkButton)sender).Attributes["param"];
            Response.Redirect("/Views/Tasks/TaskPage");
        }

        protected void TaskCardRptr_PreRender(object sender, EventArgs e)
        {
            var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
            var command = new MySqlCommand("Select *" +
            " From builton INNER JOIN project ON builton.ProjectId=@PId INNER JOIN Task ON builton.TaskId=@TId" +
            " Order By Task.TaskId Asc;", conn);
            command.Parameters.Add(new MySqlParameter("PId", MySqlDbType.VarChar) { Value = Session["ProjectId"] });
            command.Parameters.Add(new MySqlParameter("TId", MySqlDbType.VarChar) { Value = Session["TaskId"] });
            DataTable dt = new DataTable();
            conn.Open();
            dt.Load(command.ExecuteReader());
            conn.Close();
            // PrjCardRptr will now be assigned tuples from the database to repeat on, received from DataTable dt
            // Repeater hasn't been initialized yet: data has to be retrieved before it's loaded to actually have data to repeat on
            TaskCardRptr.DataSource = dt;
            // Data has to be bound to the repeater before finishing the assignment of data to the repeater
            TaskCardRptr.DataBind();
        }
    }
}