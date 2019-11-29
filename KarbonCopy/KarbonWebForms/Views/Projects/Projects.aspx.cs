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

namespace KarbonWebForms.Views.Projects
{
    public partial class Projects : System.Web.UI.Page
    {
        private readonly AccountSql accountSql = new AccountSql();
        public string activeproj = "0";

        protected void projRun()
        {
            ProjectAbilitiesSql projectAbilitiesSql = new ProjectAbilitiesSql();
            ProjectAssignedSql projectAssignedSql = new ProjectAssignedSql();

            try
            {
                var projAbility = projectAbilitiesSql.Get(Session["Username"].ToString());
                var projAssigned = projectAssignedSql.GetAll();

                //Determine if the user can create new project
                int createProj = projAbility.CreateProject;
                if (createProj == 1)
                    newProj.Enabled = true;
                else
                    newProj.Enabled = false;

                //Determine the amount of active proj (TO BE DONE)
            }
            catch
            {
                newProj.Enabled = false;
            }
        }
        protected void PrjCardRptr_Click(object sender, EventArgs e)
        {
            // Session object needs to be updated to include the ProjectId for navigation to the individual project page
            // Just "index" the Session object to add or reference a value in the Session object
            // The sender object is expected to be an HtmlAnchor because it's the only element with a link in it
            // that we need a code-behind method for.
            // HtmlElements in C# have an Attributes member. Indexing it at "param" means I need an attribute tag in the frontend
            // named "param"
            Session["ProjectId"] = ((LinkButton)sender).Attributes["param"];
            Response.Redirect("/Views/Projects/ProjectPage");
        }
        protected void PrjCardRptr_PreRender(object sender, EventArgs e)
        { 
            // test to see if the query will work appropriately
            var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
            var command = new MySqlCommand("Select *" +
            " From (ProjectAssigned LEFT OUTER JOIN Project ON ProjectAssigned.ProjectId=Project.ProjectId)" +
            " Where (Username = @user AND Email = @email)" +
            " Order By ProjectAssigned.ProjectId Asc;", conn);
            command.Parameters.Add(new MySqlParameter("user", MySqlDbType.VarChar) { Value = Session["Username"] });
            command.Parameters.Add(new MySqlParameter("email", MySqlDbType.VarChar) { Value = Session["Email"] });
            DataTable dt = new DataTable();
            conn.Open();
            dt.Load(command.ExecuteReader());
            conn.Close();
            // PrjCardRptr will now be assigned tuples from the database to repeat on, received from DataTable dt
            // Repeater hasn't been initialized yet: data has to be retrieved before it's loaded to actually have data to repeat on
            PrjCardRptr.DataSource = dt;
            // Data has to be bound to the repeater before finishing the assignment of data to the repeater
            PrjCardRptr.DataBind();
        }

        protected void newProj_Click(object sender, EventArgs e)
        {
            if(newProj.Enabled)
                Response.Redirect("/Views/Projects/CreateProjects");
        }
    }
}