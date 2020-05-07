using BiuroPracy.BusinessLogic.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiuroPracy
{
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitEmployees();
            }
        }
        private void InitEmployees()
        {
            var employees = new BiuroPracyApi().GetEmployees();
            gvEmployees.DataSource = employees.Data;
            gvEmployees.DataBind();
        }
    }
}