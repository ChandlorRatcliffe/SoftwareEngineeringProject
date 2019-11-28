using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        public void dashRun()
        {
            access();
            setTheme();
            setTextCol();
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
    }
}