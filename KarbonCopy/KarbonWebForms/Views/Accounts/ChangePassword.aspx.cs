using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KarbonWebForms.Sql;
using static KarbonWebForms.Validators;

namespace KarbonWebForms.Views.Accounts
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        private readonly AccountSql accountSql = new AccountSql();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Session["EmailValue"] as string))
            {
                AccountEmail.Text = Session["EmailValue"].ToString();
            }
        }

        protected void ChangeMyPassword(object sender, EventArgs e)
        {
            string ErrorMessage = string.Empty;
            if (IsValidPassword(EnterPassword.Text))
                ErrorMessage += $"Invalid Password Format {LineBreak}";
            else
            {
                if (EnterPassword.Text == EnterPasswordConfirm.Text)
                {
                    if (accountSql.UpdateWithEmail(Session["EmailValue"].ToString(), "password", EnterPassword.Text, out string UpdateError))
                    {
                        Session["Success"] = "Change Password Successful";
                        Response.Redirect("~/Views/Accounts/Login", false);
                    }
                    else
                    {
                        ErrorMessage += $"{UpdateError} {LineBreak}";
                    }
                }
                else
                {
                    ErrorMessage += $"Passwords do not match {LineBreak}";
                }
            }
            ChangePasswordError.Text = PreFormatError(ErrorMessage);
        }
    }
}