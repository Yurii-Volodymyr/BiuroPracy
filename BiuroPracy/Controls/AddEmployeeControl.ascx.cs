using BiuroPracy.BusinessLogic.Api;
using BiuroPracy.BusinessLogic.Api.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiuroPracy.Controls
{
    public partial class AddEmployeeControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitControl();
            }
        }
        #region Methods
        private void InitProfession()
        {
            IBiuroPracyApi api = new BiuroPracyApi();
            var dataResponse = api.GetProfessions();
            if (!dataResponse.Success)
            {
                Trace.Warn(dataResponse.Errors);
                return;
            }
            ddlProfession.DataSource = dataResponse.Data;
            ddlProfession.DataTextField = "Name";
            ddlProfession.DataValueField = "Id";
            ddlProfession.DataBind();
        }


        private void InitContract()
        {
            IBiuroPracyApi api = new BiuroPracyApi();
            var dataResponse = api.GetContracts();
            if (!dataResponse.Success)
            {
                Trace.Warn(dataResponse.Errors);
                return;
            }
            ddlContractOfEmployment.DataSource = dataResponse.Data;
            ddlContractOfEmployment.DataTextField = "Name";
            ddlContractOfEmployment.DataValueField = "Id";
            ddlContractOfEmployment.DataBind();
        }
        private void InitControl()
        {
            InitProfession();
            InitContract();
        }
        #endregion

        #region Properties
        public string Email => txtEmail.Text;
        public string Password => txtPassword.Text;
        public string Surename => txtSureName.Text;
        public string Name => txtName.Text;
        public string Type => rblType.SelectedValue;
        public int ProfessionId => string.IsNullOrEmpty(ddlProfession.SelectedValue) ? 0 : Convert.ToInt32(ddlProfession.SelectedValue);
        public int ContractId => string.IsNullOrEmpty(ddlContractOfEmployment.SelectedValue) ? 0 : Convert.ToInt32(ddlContractOfEmployment.SelectedValue);
        public DateTime DateOfBirth => calendarDateOfBirth.SelectedDate;
        #endregion

      
        
        public void ClearControls()
        {
            txtEmail.Text = txtPassword.Text = txtSureName.Text = txtName.Text = string.Empty;
        }
       
    }
}