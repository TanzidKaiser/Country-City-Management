using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CountryProject.MODEL.ViewModel;
using CountryProject.MODEL;
using System.Web.Configuration;

namespace CountryProject.DAL
{
    public class CountryGatway
    {
        //private SqlConnection connection;
        //private string connectionString = @"Data Source=TANZID\SQLEXPRESS;Initial Catalog=CountryCityDb;Integrated Security=True";

        private SqlConnection connection;
        string connectionString = WebConfigurationManager.ConnectionStrings["CountryCityManagement"].ConnectionString;

        public CountryGatway()
        {
            connection = new SqlConnection(connectionString);
        }

        public int IsCountryExist(string CountryName)
        {
            //string selectQuery = string.Format("SELECT * FROM tb_country WHERE name='{0}'", CountryName);
            string selectQuery = "SELECT * FROM tb_country WHERE name= @name";
            SqlCommand command = new SqlCommand(selectQuery, connection);

            command.Parameters.Clear();

            command.Parameters.Add("name", SqlDbType.VarChar);
            command.Parameters["name"].Value = CountryName;

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                connection.Close();
                return 1;
            }
            connection.Close();
            return -1;
        }

        public int Save(Country aCountry)
        {
            //string insertQuery = string.Format("INSERT INTO tb_country(name,about) VALUES('{0}','{1}')", aCountry.CountryName, aCountry.CountryAbout);
            string insertQuery = "INSERT INTO tb_country VALUES(@name, @about)";
            SqlCommand command = new SqlCommand(insertQuery, connection);
           
            command.Parameters.Clear();
            
            command.Parameters.Add("name", SqlDbType.VarChar);
            command.Parameters["name"].Value = aCountry.CountryName;

            command.Parameters.Add("about", SqlDbType.VarChar);
            command.Parameters["about"].Value = aCountry.CountryAbout;

            
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<Country> GetAll()
        {
            string query = "SELECT * FROM tb_country";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<Country> countryList = new List<Country>();

            while (reader.Read())
            {
                Country country = new Country();
                country.id = Convert.ToInt32(reader["id"]);
                country.CountryName = reader["name"].ToString();
                country.CountryAbout = reader["about"].ToString();
               
                countryList.Add(country);
            }
            reader.Close();
            connection.Close();
            return countryList;
        }

        

      

       
    }

    
}