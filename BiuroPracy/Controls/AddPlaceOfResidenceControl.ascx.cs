using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BiuroPracy.BusinessLogic.Api;
using BiuroPracy.BusinessLogic.Api.Interface;

namespace BiuroPracy.Controls
{
    public partial class AddPlaceOfResidenceControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitControl();
            }
        }


        public string Street => txtStreet.Text;
        public string ZipCode => txtZipCode.Text;
        public int CityId => string.IsNullOrEmpty(ddlCity.SelectedValue) ? 0 : Convert.ToInt32(ddlCity.SelectedValue);
        public int CountryId => string.IsNullOrEmpty(ddlCountry.SelectedValue) ? 0 : Convert.ToInt32(ddlCountry.SelectedValue);

        private void InitCity()
        {
            IBiuroPracyApi api = new BiuroPracyApi();
            var dataResponse = api.GetCity();
            if (!dataResponse.Success)
            {
                Trace.Warn(dataResponse.Errors);
                return;
            }
            ddlCity.DataSource = dataResponse.Data;
            ddlCity.DataTextField = "Name";
            ddlCity.DataValueField = "Id";
            ddlCity.DataBind();
        }

        private void InitCountry()
        {
            IBiuroPracyApi api = new BiuroPracyApi();
            var dataResponse = api.GetCountry();
            if (!dataResponse.Success)
            {
                Trace.Warn(dataResponse.Errors);
                return;
            }
            ddlCountry.DataSource = dataResponse.Data;
            ddlCountry.DataTextField = "Name";
            ddlCountry.DataValueField = "Id";
            ddlCountry.DataBind();
        }

        private void InitControl()
        {
            InitCity();
            InitCountry();
        }

        public void ClearControls()
        {
            txtStreet.Text = txtZipCode.Text = string.Empty;
        }
    }
}

