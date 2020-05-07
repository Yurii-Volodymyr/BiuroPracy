using BiuroPracy.BusinessLogic.Api;
using BiuroPracy.BusinessLogic.Api.Interface;
using BiuroPracy.BusinessLogic.ModelDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiuroPracy
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region Methods
        private EmployeeDto GetEmployeeDto()
        {
            return new EmployeeDto()
            {
                Email=crtlAddEmployee.Email,
                Password=crtlAddEmployee.Password,
                Name=crtlAddEmployee.Name,
                Surename=crtlAddEmployee.Surename,
                DateOfBirth=crtlAddEmployee.DateOfBirth,
                ProfessionId=crtlAddEmployee.ProfessionId,
                ContractId=crtlAddEmployee.ContractId,
            };
        }
        #endregion
        #region Events

        

        #endregion

        protected void btnTestNHibertate_Click(object sender, EventArgs e)
        {
            IBiuroPracyApi api = new BiuroPracyApi();
            api.TestNHibernate();
        }

        protected void btnsave_Click1(object sender, EventArgs e)
        {
            var api = new BiuroPracyApi();
            var result = api.AddEmployee(GetEmployeeDto());

            if (!result.Success)
            {
                Trace.Warn(result.Errors);
                lblInfo.Text = "Błąd dodawania";
                panelInfo.CssClass = "alert alert-danger";
            }
            else
            {
                crtlAddEmployee.ClearControls();
                panelInfo.CssClass = "alert alert-success";
                lblInfo.Text = "Dodano Pracownika";
            }
        }
    }
}