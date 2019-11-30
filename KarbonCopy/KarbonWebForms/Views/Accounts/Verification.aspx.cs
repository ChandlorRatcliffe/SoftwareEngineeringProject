using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KarbonWebForms.Sql;
using static KarbonWebForms.Validators;

namespace KarbonWebForms.Views.Accounts
{
    public partial class Verification : System.Web.UI.Page
    {
        private readonly AccountSql accountSql = new AccountSql();

        protected void VerifyAccount(object sender, EventArgs e)
        {
            if (VerificationInput.Text == verfToken)
            {
                Account account = accountSql.GetWithEmail(Email.Text);
                if (account != null)
                {
                    accountSql.Update(account.Username, "skills", "");
                    Debug.WriteLine("Successful Verfication");
                    Session["Success"] = "Account successfully Verified";
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