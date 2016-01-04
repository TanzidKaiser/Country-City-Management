using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryProject.MODEL;
using CountryProject.DAL;

namespace CountryProject.BLL
{
    public class CountryManager
    {
        CountryGatway aCountryGateway = new CountryGatway();
        public bool Save(Country aCountry)
        {

           
            if (IsCountryExist(aCountry.CountryName))
            {
                throw new Exception("Country Already Exist");
            }
            if (aCountryGateway.Save(aCountry) > 0)
               return true;
            return false;
        }
        private bool IsCountryExist(string CountryName)
        {
            //aStudentGateway = new StudentGateway();
            if (aCountryGateway.IsCountryExist(CountryName) > 0)
            {
                return true;
            }
            return false;
        }

        public static List<Country> GetAll()
        {

            CountryGatway aCountryGateway = new CountryGatway();
            return aCountryGateway.GetAll();
        }
    }
}