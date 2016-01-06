using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryProject.MODEL.ViewModel;
using CountryProject.DAL;

namespace CountryProject.BLL
{
    public class ViewCountryManager
    {
       
         public List<ViewCountry> ViewCountyGetAll(string searchCountry)
        {
            ViewCountryGateway viewCountryGateway = new ViewCountryGateway();
            
             List<ViewCountry> getFullViewCuntryList = new List<ViewCountry>();

            if (searchCountry == "")
            {



                List<ViewCountry> viewCountryList = viewCountryGateway.ViewCountyGetAll();



                foreach (ViewCountry elemnt in viewCountryList)
                {
                    ViewCountry aViewCountry = new ViewCountry();
                    aViewCountry.ViewCountryid = elemnt.ViewCountryid;
                    aViewCountry.ViewCountryName = elemnt.ViewCountryName;
                    aViewCountry.ViewCountryAbout = elemnt.ViewCountryAbout;

                    aViewCountry.viewCountryNoOfCitys = viewCountryGateway.NoOfCityGetway(aViewCountry.ViewCountryid);

                    aViewCountry.viewCountryNoOfCityDrewlers = viewCountryGateway.NoOfCityDrewlersGetway(aViewCountry.ViewCountryid);

                    getFullViewCuntryList.Add(aViewCountry);

                }
            }
            else
            {


                List<ViewCountry> viewCountryList = viewCountryGateway.ViewCountyGetAll(searchCountry);


                foreach (ViewCountry elemnt in viewCountryList)
                {
                    ViewCountry aViewCountry = new ViewCountry();
                    aViewCountry.ViewCountryid = elemnt.ViewCountryid;
                    aViewCountry.ViewCountryName = elemnt.ViewCountryName;
                    aViewCountry.ViewCountryAbout = elemnt.ViewCountryAbout;

                    aViewCountry.viewCountryNoOfCitys = viewCountryGateway.NoOfCityGetway(aViewCountry.ViewCountryid);

                    aViewCountry.viewCountryNoOfCityDrewlers = viewCountryGateway.NoOfCityDrewlersGetway(aViewCountry.ViewCountryid);

                    getFullViewCuntryList.Add(aViewCountry);
                }

               
            }
            return getFullViewCuntryList;
        }
        

        public bool SearchCountry(ViewCountry aViewCountry)
        {
            throw new NotImplementedException();
        }
    
    }
}