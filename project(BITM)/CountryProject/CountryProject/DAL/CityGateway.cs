using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using CountryProject.MODEL;
using System.Data.SqlClient;
using CountryProject.BLL;
using System.Web.Configuration;
namespace CountryProject.DAL
{
    public class CityGateway
    {
        //private SqlConnection connection;
        //private string connectionString = @"Data Source=TANZID\SQLEXPRESS;Initial Catalog=CountryCityDb;Integrated Security=True";

        private SqlConnection connection;
        string connectionString = WebConfigurationManager.ConnectionStrings["CountryCityManagement"].ConnectionString;

        public CityGateway() {

            connection = new SqlConnection(connectionString);
        }
        public int Save(City aCity)
        {
            
            //string insertQuery = string.Format("INSERT INTO tb_city(name,about,noOfDwellers,weather,location,countryId) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", aCity.CityName,aCity.CityAbout,aCity.NoOfDwellers,aCity.Weather,aCity.Location,aCity.CountryId);
            string insertQuery = "INSERT INTO t_city VALUES(@name, @about, @noOfDwellers,@weather,@location,@countryId)";
            SqlCommand command = new SqlCommand(insertQuery, connection);
            command.Parameters.Clear();
            command.Parameters.Add("name", SqlDbType.VarChar);
            command.Parameters["name"].Value = aCity.CityName;
            command.Parameters.Add("about", SqlDbType.VarChar);
            command.Parameters["about"].Value = aCity.CityAbout;
            command.Parameters.Add("noOfDwellers", SqlDbType.Int);
            command.Parameters["noOfDwellers"].Value = aCity.NoOfDwellers;
            command.Parameters.Add("weather", SqlDbType.VarChar);
            command.Parameters["weather"].Value = aCity.Weather;
            command.Parameters.Add("location", SqlDbType.VarChar);
            command.Parameters["location"].Value = aCity.Location;
            command.Parameters.Add("countryId", SqlDbType.Int);
            command.Parameters["countryId"].Value = aCity.CountryId;
            
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

       

        internal int IsCityExist(string CityName, int CountryId)
        {
            string selectQuery = string.Format("SELECT name FROM t_city WHERE countryId='{0}'", CountryId);
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
            string query = "SELECT * FROM t_city";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<City> cityList = new List<City>();

            while (reader.Read())
            {
                City city = new City();
                city.cityId = Convert.ToInt32(reader["id"]);
                city.CityName = reader["name"].ToString();
                city.NoOfDwellers = Convert.ToInt32(reader["noOfDwellers"]);
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