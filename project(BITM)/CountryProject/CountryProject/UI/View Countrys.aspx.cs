using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryProject.MODEL.ViewModel;
using CountryProject.BLL;

namespace CountryProject.UI
{
    public partial class View_Countrys : System.Web.UI.Page
    {
        ViewCountryManager viewCountryManager = new ViewCountryManager();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {

                LoadCountry();
            }
        }

        private void LoadCountry()
        {
            List<ViewCountry> viewcountryList =viewCountryManager.ViewCountyGetAll(viewCountrynameTextBox.Text);
            viewCountryGridView.DataSource = viewcountryList;
            viewCountryGridView.DataBind();

        }



        protected void viewSearchButton_Click(object sender, EventArgs e)
        {

            LoadCountry();       
            
        }
    }
}