using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryProject.MODEL;
using CountryProject.DAL;
namespace CountryProject.BLL
{
    public class CityManager
    {
        CityGateway aCityGateway = new CityGateway();
        public bool Save(City aCity)
        {
          
            if (IsCityExist(aCity.CityName, aCity.CountryId)) {

                throw new Exception("City Already Exist of that country");
            }

            if (aCityGateway.Save(aCity) > 0)
                return true;
            return false;
        }

        private bool IsCityExist(string CityName, int CountryId)
        {

            if (aCityGateway.IsCityExist(CityName, CountryId) > 0)
            {
                return true;
            }
            return false;
        }



       public static List<City> GetAll()
        {
            CityGateway aCityGateway = new CityGateway();
            List<City> getFullCityList = new List<City>();
            List<City> acityList = new List<City>();
            acityList = aCityGateway.GetAll();
            foreach (City elemnt in acityList) {

                City aCity = new City();
                aCity.cityId = elemnt.cityId;
                aCity.CityName = elemnt.CityName;
                aCity.NoOfDwellers = elemnt.NoOfDwellers;
                int CountryId = elemnt.CountryId;
                aCity.Country = aCityGateway.GetCountryName(CountryId);
                getFullCityList.Add(aCity);

            }

            return getFullCityList;
        }
    }
}