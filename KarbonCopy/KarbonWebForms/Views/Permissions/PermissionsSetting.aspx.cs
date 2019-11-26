using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace KarbonWebForms.Views.Permissions
{
    public partial class PermissionsSetting : System.Web.UI.Page
    {
        List<string> MemberList = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OrgMemRptr_PreRender(object sender, EventArgs e)
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
                OrgMemRptr.DataSource = dt;
                // Data has to be bound to the repeater before finishing the assignment of data to the repeater
                OrgMemRptr.DataBind();
                foreach (DataRow row in dt.Rows){
                    MemberList.Add(row[0].ToString());
                }
            }
            conn.Close();
        }

        private void SetSelected(string[] usernames) {
            foreach (string un in usernames){
                MemberList.Add(un);
            }
        }
        private List<string> GetSelected() {
            return MemberList;
        }
        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
            conn.Open();
            foreach (string un in GetSelected())
            {
                // update all permission levels of each user
            }
            
            conn.Close();
        }
    }
}