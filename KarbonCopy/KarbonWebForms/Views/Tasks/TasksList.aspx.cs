using KarbonWebForms.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KarbonWebForms.Views.Tasks
{
    public partial class Index : System.Web.UI.Page
    {
        private readonly TaskSql taskSql = new TaskSql();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TaskCardRptr_PreRender(object sender, EventArgs e)
        {
            
        }
    }
}