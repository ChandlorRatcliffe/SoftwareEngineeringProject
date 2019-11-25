using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KarbonWebForms.Sql;
using MySql.Data.MySqlClient;

namespace KarbonWebForms.Views.Tasks
{
    public partial class CreateTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /*
        protected void InsertTask(object sender, EventArgs e)
        {
            string test = Request.QueryString["test"];
            SqlParameter[] sqlParameters = new SqlParameter[10];

            SqlParameter sqlParameters = new SqlParameter("task", MySqlDbType.VarChar) { Value = test };


            SqlFunctions sqlFunction = new SqlFunctions();


            sqlFunction.ExecuteNonQuery("", [] = new SqlParameter[])
        }
        */


    }
}