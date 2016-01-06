using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryProject.MODEL.ViewModel;
using System.Data;
using System.Web.Configuration;

namespace CountryProject.DAL
{
    public class ViewCountryGateway
    {
        //SqlConnection sqlconn = new SqlConnection();

        //sqlconn.ConnectionString = connectionString;

        private SqlConnection connection;
        string connectionString = WebConfigurationManager.ConnectionStrings["CountryCityManagement"].ConnectionString;

        //private string connectionString = @"Data Source=TANZID\SQLEXPRESS;Initial Catalog=CountryCityDb;Integrated Security=True";

        public ViewCountryGateway()
        {
            connection = new SqlConnection(connectionString);
        }

        public List<ViewCountry> ViewCountyGetAll()
        {
            string viewContryGetAllQuery = "SELECT * FROM tb_country";

            SqlCommand command = new SqlCommand(viewContryGetAllQuery, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<ViewCountry> viewCountryList = new List<ViewCountry>();

            while (reader.Read())
            {
                ViewCountry viewCountry = new ViewCountry();
                viewCountry.ViewCountryid = Convert.ToInt32(reader["id"]);
                viewCountry.ViewCountryName = reader["name"].ToString();
                viewCountry.ViewCountryAbout = reader["about"].ToString();

                viewCountryList.Add(viewCountry);
            }
            reader.Close();
            connection.Close();
            return viewCountryList;
        }

        public List<ViewCountry> ViewCountyGetAll(string searchCountry)
        {
            

            string viewContryGetAllQuery = "SELECT * FROM tb_country WHERE name LIKE '%'+ @name +'%' ORDER BY name";

            SqlCommand command = new SqlCommand(viewContryGetAllQuery, connection);

            command.Parameters.Clear();

            command.Parameters.Add("name", SqlDbType.VarChar);
            command.Parameters["name"].Value =searchCountry;

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<ViewCountry> viewCountryList = new List<ViewCountry>();

            while (reader.Read())
            {
                ViewCountry viewCountry = new ViewCountry();
                viewCountry.ViewCountryid = Convert.ToInt32(reader["id"]);
                viewCountry.ViewCountryName = reader["name"].ToString();
                viewCountry.ViewCountryAbout = reader["about"].ToString();

                viewCountryList.Add(viewCountry);
            }
            reader.Close();
            connection.Close();
            return viewCountryList;
        }


        public int NoOfCityGetway(int ViewCountryid)
        {


            string selectQuery = string.Format("SELECT count(name) as count FROM t_city WHERE countryId='{0}'", ViewCountryid);
            SqlCommand command = new SqlCommand(selectQuery, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            ViewCountry viewCountry = new ViewCountry();
            while (reader.Read())
            {

                viewCountry.viewCountryNoOfCitys = Convert.ToInt32(reader["count"]);

            }

            reader.Close();
            connection.Close();

            return viewCountry.viewCountryNoOfCitys;


        }

        public string NoOfCityDrewlersGetway(int ViewCountryid)
        {
            string selectQuery = string.Format("SELECT sum(noOfDwellers) as count FROM t_city WHERE countryId='{0}'", ViewCountryid);
            SqlCommand command = new SqlCommand(selectQuery, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            ViewCountry viewCountry = new ViewCountry();
            while (reader.Read())
            {

                viewCountry.viewCountryNoOfCityDrewlers = reader["count"].ToString();

            }

            reader.Close();
            connection.Close();

            return viewCountry.viewCountryNoOfCityDrewlers;
        }

    }
}