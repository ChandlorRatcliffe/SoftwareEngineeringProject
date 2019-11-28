using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KarbonWebForms.Views.Permissions
{
    public partial class PermissionsSetting : System.Web.UI.Page
    {
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
            }
            conn.Close();
        }

        // KeyValuePair<AbilitiesTable, PermissionToSet>
        private List<KeyValuePair<string, string>> checkSelected()
        {
            List<KeyValuePair<string, string>> selectedPerms = new List<KeyValuePair<string, string>>();
            foreach (Control c in permissionAccordion.Controls)
            {
                if (c is CheckBox)
                {
                    var chkbx = (CheckBox)c;
                    if (chkbx.Checked)
                    {
                        // first 4 designate table, end of substring determines permission
                        string first4 = chkbx.ID.Substring(0, 4);
                        string end = chkbx.ID.Substring(4, chkbx.ID.Length - 4);
                        selectedPerms.Add(new KeyValuePair<string, string>(first4, end));
                    }
                }
            }
            return selectedPerms;
        }

        // KeyValuePair<AbilitiesTable, PermissionToUnset>
        private List<KeyValuePair<string, string>> checkUnselected()
        {
            List<KeyValuePair<string, string>> unselectedPerms = new List<KeyValuePair<string, string>>();
            foreach (Control c in permissionAccordion.Controls)
            {
                if (c is CheckBox)
                {
                    var chkbx = (CheckBox)c;
                    if (!chkbx.Checked) {
                        // first 4 designate table, end of substring determines permission
                        string first4 = chkbx.ID.Substring(0, 4);
                        string end = chkbx.ID.Substring(4, chkbx.ID.Length - 4);
                        unselectedPerms.Add(new KeyValuePair<string, string>(first4, end));
                    }
                }
            }
            return unselectedPerms;
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
            conn.Open();
            var trans = conn.BeginTransaction();
            foreach (RepeaterItem RptrItem in OrgMemRptr.Items)
            {
                foreach (Control c in RptrItem.Controls)
                {
                    // set all selected permissions of each user
                    if (c is CheckBox)
                    {
                        var chkbx = (CheckBox)c;
                        if (chkbx.Checked)
                        {
                            foreach (KeyValuePair<string, string> kvp in checkSelected())
                            {
                                if (kvp.Key == "Orgn")
                                {
                                    try
                                    {
                                        var OrgnCommand = new MySqlCommand($"Update OrganizationAbilities SET {kvp.Value}=1 Where (Username=@user);", conn, trans);
                                        // UsernameChkBx: last 5 need trimming
                                        OrgnCommand.Parameters.Add(new MySqlParameter("user", MySqlDbType.VarChar) { Value = chkbx.Attributes["param"] });
                                        OrgnCommand.ExecuteNonQuery();
                                    }
                                    catch (Exception exc)
                                    {
                                        Debug.WriteLine("OrgnCommand unsucessful.\n" + exc.StackTrace);
                                    }
                                }
                                else if (kvp.Key == "Proj")
                                {
                                    try
                                    {
                                        var ProjCommand = new MySqlCommand($"Update ProjectAbilities SET {kvp.Value}=1 Where (Username=@user);", conn, trans);
                                        // UsernameChkBx: last 5 need trimming
                                        ProjCommand.Parameters.Add(new MySqlParameter("user", MySqlDbType.VarChar) { Value = chkbx.Attributes["param"] });
                                        ProjCommand.ExecuteNonQuery();
                                    }
                                    catch (Exception exc)
                                    {
                                        Debug.WriteLine("ProjCommand unsucessful.\n" + exc.StackTrace);
                                    }
                                }
                                else if (kvp.Key == "Task")
                                {
                                    try
                                    {
                                        var TaskCommand = new MySqlCommand($"Update TaskAbilities SET {kvp.Value}=1 Where (Username=@user);", conn, trans);
                                        // UsernameChkBx: last 5 need trimming
                                        TaskCommand.Parameters.Add(new MySqlParameter("user", MySqlDbType.VarChar) { Value = chkbx.Attributes["param"] });
                                        TaskCommand.ExecuteNonQuery();
                                    }
                                    catch (Exception exc)
                                    {
                                        Debug.WriteLine("TaskCommand unsucessful.\n" + exc.StackTrace);
                                    }
                                }
                            }
                            // clear all unselected permissions of each user (removal of permissions)
                            foreach (KeyValuePair<string, string> kvp in checkUnselected())
                            {
                                if (kvp.Key == "Orgn")
                                {
                                    try
                                    {
                                        var OrgnCommand = new MySqlCommand($"Update OrganizationAbilities SET {kvp.Value}=0 Where (Username=@user);", conn, trans);
                                        // UsernameChkBx: last 5 need trimming
                                        OrgnCommand.Parameters.Add(new MySqlParameter("user", MySqlDbType.VarChar) { Value = chkbx.Attributes["param"] });
                                        OrgnCommand.ExecuteNonQuery();
                                    }
                                    catch (Exception exc)
                                    {
                                        Debug.WriteLine("OrgnCommand unsucessful.\n" + exc.StackTrace);
                                    }
                                }
                                else if (kvp.Key == "Proj")
                                {
                                    try
                                    {
                                        var ProjCommand = new MySqlCommand($"Update ProjectAbilities SET {kvp.Value}=0 Where (Username=@user);", conn, trans);
                                        // UsernameChkBx: last 5 need trimming
                                        ProjCommand.Parameters.Add(new MySqlParameter("user", MySqlDbType.VarChar) { Value = chkbx.Attributes["param"] });
                                        ProjCommand.ExecuteNonQuery();
                                    }
                                    catch (Exception exc)
                                    {
                                        Debug.WriteLine("ProjCommand unsucessful.\n" + exc.StackTrace);
                                    }
                                }
                                else if (kvp.Key == "Task")
                                {
                                    try
                                    {
                                        var TaskCommand = new MySqlCommand($"Update TaskAbilities SET {kvp.Value}=0 Where (Username=@user);", conn, trans);
                                        // UsernameChkBx: last 5 need trimming
                                        TaskCommand.Parameters.Add(new MySqlParameter("user", MySqlDbType.VarChar) { Value = chkbx.Attributes["param"] });
                                        TaskCommand.ExecuteNonQuery();
                                    }
                                    catch (Exception exc)
                                    {
                                        Debug.WriteLine("TaskCommand unsucessful.\n" + exc.StackTrace);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            trans.Commit();
            conn.Close();
        }
    }
}