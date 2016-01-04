using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryProject.MODEL;
using System.Data.SqlClient;
using CountryProject.BLL;
namespace CountryProject.DAL
{
    public class CityGateway
    {
        private SqlConnection connection;
        private string connectionString = @"Data Source=TANZID\SQLEXPRESS;Initial Catalog=CountryCityDb;Integrated Security=True";

        public CityGateway() {

            connection = new SqlConnection(connectionString);
        }
        public int Save(City aCity)
        {
            string insertQuery = string.Format("INSERT INTO tb_city(name,about,noOfDwellers,weather,location,countryId) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", aCity.CityName,aCity.CityAbout,aCity.NoOfDwellers,aCity.Weather,aCity.Location,aCity.CountryId);
            SqlCommand command = new SqlCommand(insertQuery, connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

       

        internal int IsCityExist(string CityName, int CountryId)
        {
            string selectQuery = string.Format("SELECT name FROM tb_city WHERE countryId='{0}'", CountryId);
            SqlCommand command = new SqlCommand(selectQuery, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
           
            while (reader.Read())
            {
                
                City city = new City();
               

                city.CityName = reader["name"].ToString();
                if (city.CityName.Equals(CityName)) {

                    
                        reader.Close();
                        connection.Close();
                        return 1;
                        break;
                }

               
            }
            reader.Close();
            connection.Close();
            return -1;
        }

       public List<City> GetAll()
        {
            string query = "SELECT * FROM tb_city";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<City> cityList = new List<City>();

            while (reader.Read())
            {
                City city = new City();
                city.cityId = Convert.ToInt32(reader["id"]);
                city.CityName = reader["name"].ToString();
                city.NoOfDwellers = reader["noOfDwellers"].ToString();
                city.CountryId = Convert.ToInt32(reader["countryId"]);
                

                cityList.Add(city);
               
            }
            reader.Close();
            connection.Close();
            return cityList;
        }

       public string GetCountryName(int CountryId)
       {
           
           string selectQuery = string.Format("SELECT name FROM tb_country WHERE id='{0}'", CountryId);
           SqlCommand command = new SqlCommand(selectQuery, connection);
           connection.Open();
           SqlDataReader reader = command.ExecuteReader();
           Country country = new Country();
           while (reader.Read())
           { 
           country.CountryName = reader["name"].ToString();

           }
           reader.Close();
           connection.Close();

           return country.CountryName;

       }
    }
}