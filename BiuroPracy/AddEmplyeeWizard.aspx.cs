using BiuroPracy.BusinessLogic.Api;
using BiuroPracy.BusinessLogic.ModelDTO;
using System;
using System.Web.UI.WebControls;

namespace BiuroPracy
{
    public partial class AddEmplyeeWizard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
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

        private EmployeeDto GetEmployeeDto()
        {
            return new EmployeeDto()
            {
                Email = crtlAddEmployee.Email,
                Password = crtlAddEmployee.Password,
                Name = crtlAddEmployee.Name,
                Surename = crtlAddEmployee.Surename,
                DateOfBirth = crtlAddEmployee.DateOfBirth,
                ProfessionId = crtlAddEmployee.ProfessionId,
                ContractId = crtlAddEmployee.ContractId,
                CityId = crtlAddPlaceOfResidence.CityId,
                CountryId = crtlAddPlaceOfResidence.CountryId,
                Street = crtlAddPlaceOfResidence.Street,
                ZipCode = crtlAddPlaceOfResidence.ZipCode,
            };
        }
    }
}