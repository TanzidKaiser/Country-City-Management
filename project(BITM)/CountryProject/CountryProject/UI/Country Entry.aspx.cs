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
    public partial class Country_Entry : System.Web.UI.Page
    {
        CountryManager aCountryManager = new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                LoadCountry();
               
            }
        }

        private void LoadCountry()
        {
            List<Country> country = CountryManager.GetAll();
            CountryGridView.DataSource = country;
            CountryGridView.DataBind();
            
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Country aCountry = new Country();
            aCountry.CountryName = CountryTextBox.Text;
            aCountry.CountryAbout = AboutTextBox.Text;

            try
            {
                if (aCountryManager.Save(aCountry))
                {
                    MessageLabel.Text = "Saved Successfully!";
                    LoadCountry();
                }
                else
                {
                    MessageLabel.Text = "Save Failed!";
                    LoadCountry();
                }
            }
            catch (Exception exception)
            {
                MessageLabel.Text = exception.Message;
            }
        }

        protected void CancleButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}