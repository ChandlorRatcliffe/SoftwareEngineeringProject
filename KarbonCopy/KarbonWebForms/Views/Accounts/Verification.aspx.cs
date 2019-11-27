using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KarbonWebForms.Sql;

namespace KarbonWebForms.Views.Accounts
{
    public partial class Verification : System.Web.UI.Page
    {
        private readonly AccountSql accountSql = new AccountSql();

        //make dynamic
        private readonly string verfToken = "38749384";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void VerifyAccount(object sender, EventArgs e)
        {
            if (VerificationInput.Text == verfToken)
            {
                Account account = accountSql.GetWithEmail(Email.Text);
                if (account != null)
                {
                    accountSql.Update(account.Username, "skills", "");
                    Debug.WriteLine("Successful Verfication");
                    Response.Redirect("~/Views/Accounts/Login", false);
                }
                else
                {
                    Debug.WriteLine("Invalid Email Address");
                    Response.Redirect("~/Views/Accounts/Login", false);
                }
            }
            else
            {
                Debug.WriteLine("Invalid Code");
                Response.Redirect("~/Views/Accounts/Login", false);
            }
        }
    }
}