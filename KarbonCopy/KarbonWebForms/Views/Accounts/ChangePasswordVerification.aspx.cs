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
    public partial class ChangePasswordVerification : Page
    {
        string ErrorMessage = string.Empty;
        protected void ChangePassword(object sender, EventArgs e)
        {
            if (PasswordChangeCode.Text == passwordRecoveryToken)
            {
                Session["EmailValue"] = Email.Text;
                Response.Redirect("~/Views/Accounts/ChangePassword", false);
            }
            else
            {
                ErrorMessage += $"Invalid Token Detected {LineBreak}";
            }
            ChangePasswordVerificationError.Text = PreFormatError(ErrorMessage);
        }
    }
}