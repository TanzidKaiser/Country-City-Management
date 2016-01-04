using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryProject.MODEL;
using CountryProject.BLL;


namespace CountryProject.UI
{
    public partial class City_Entry : System.Web.UI.Page
    {
       CityManager aCityManager = new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                LoadCountry();
                LoadCity();
            }
        }

        private void LoadCity()
        {
            List<City> city = CityManager.GetAll();
            CityGridView.DataSource = city;
            CityGridView.DataBind();

        }
        private void LoadCountry()
        {
            CountryManager countryManager = new CountryManager();
            CountryDropDownList.DataSource = null;
            List<Country> country = CountryManager.GetAll();
            CountryDropDownList.DataSource = country;
            CountryDropDownList.DataTextField = "CountryName";
            CountryDropDownList.DataValueField = "id";
            CountryDropDownList.DataBind();
           
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            City aCity = new City();
            aCity.CityName = CityNameTextBox.Text;
            aCity.CityAbout = AboutTextBox.Text;
            aCity.NoOfDwellers = NoOfDrewlerTextBox.Text;
            aCity.Weather = WeatherTextBox.Text;
            aCity.Location = LocationTextBox.Text;
            aCity.CountryId = Convert.ToInt32(CountryDropDownList.SelectedValue);
            

            try
            {
                if (aCityManager.Save(aCity))
                {
                    messageLabel.Text = "Saved Successfully!";
                    LoadCountry();
                    LoadCity();
                }
                else
                {
                    messageLabel.Text = "Save Failed!";
                    LoadCountry();
                    LoadCity();
                }
            }
            catch (Exception exception)
            {
                messageLabel.Text = exception.Message;
            }
        }

        protected void CancleButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }


     }

    
}