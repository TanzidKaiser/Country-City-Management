using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CountryProject
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CountryEntry_Click(object sender, EventArgs e)
        {

            Response.Redirect("Country Entry.aspx");
        }

        protected void CityEntry_Click(object sender, EventArgs e)
        {
            Response.Redirect("CityEntry.aspx");
        }

        protected void ViewCountrys_Click(object sender, EventArgs e)
        {
            Response.Redirect("View Countrys.aspx");
        }
    }
}