using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CashewWebForms
{
    public partial class SiteMaster : MasterPage
    {
        public string tempLink = "~/Views/Projects/Projects.aspx";
        public string theme;
        public string textCol;
        public string permAccess;
        public string permLink;
        public string inviteAccess;
        public string inviteLink;
        public string removeAccess;
        public string removeLink;

        public void dashRun()
        {
            access();
            setTheme();
            setTextCol();
            linkAccess();
        }

        private void access()
        {
            string user;

            try
            {
                user = Session["Username"].ToString();
                if(user.Equals(""))
                {
                    Response.Redirect("~/Views/Accounts/Login.aspx");
                }
            }
            catch
            {
                Response.Redirect("~/Views/Accounts/Login.aspx");
            }

        }

        private void setTheme()
        {
            try
            {
                this.theme = Session["Theme"].ToString();
                if (!this.theme.Equals("light"))
                    this.theme = "dark";
            }
            catch
            {
                this.theme = "dark";
            }

        }

        private void setTextCol()
        {
            if (this.theme.Equals("light"))
                this.textCol = "dark";
            else
                this.textCol = "light";
        }

        private void linkAccess()
        {
            var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["mySql"].ConnectionString);
            conn.Open();
            string qRun = "SELECT `RemoveUser`,`InviteUser`,`PermissionsEditing` FROM `organizationabilities` WHERE `Username`='" + Session["Username"].ToString() + "'";
            var command = new MySqlCommand(qRun, conn);
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader()); //[0][0]=RemoveUser, [0][1]=InviteUser, [0][2]=PermissionsEditing

            if (dt.Rows.Count != 0)
            {
                if ((int)dt.Rows[0][2] == 1)
                {
                    permAccess = "";
                    permLink = "/Views/Permissions/PermissionsSetting.aspx";
                }
                else
                {
                    permAccess = "disabled";
                    permLink = "#";
                }
                if ((int)dt.Rows[0][1] == 1)
                {
                    inviteAccess = "";
                    inviteLink = "/Views/Accounts/OrganizationInviteUser.aspx";
                }
                else
                {
                    inviteAccess = "disabled";
                    inviteLink = "#";
                }
                if ((int)dt.Rows[0][0] == 1)
                {
                    removeAccess = "";
                    removeLink = "#";
                }
                else
                {
                    removeAccess = "disabled";
                    removeLink = "#";
                }
            }
            else
            {
                permAccess = "disabled";
                inviteAccess = "disabled";
                removeAccess = "disabled";
                permLink = "#";
                inviteLink = "#";
                removeLink = "#";

                if (string.Compare(Request.Url.AbsolutePath, "/Views/Permissions/PermissionsSetting") == 0 ||
                    string.Compare(Request.Url.AbsolutePath, "/Views/Accounts/OrganizationInviteUser") == 0)
                {
                    Response.Redirect("~/Views/Projects/Projects.aspx");
                }
            }

            conn.Close();
        }
    }
}