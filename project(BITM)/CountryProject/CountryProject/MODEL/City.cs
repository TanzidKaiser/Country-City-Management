using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryProject.MODEL
{
    public class City
    {
        public int cityId { get; set; }
        public string CityName { get; set; }
        public string CityAbout { get; set; }
        public string NoOfDwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public string Country { get; set; }
        public int CountryId { get; set; }

    }
}