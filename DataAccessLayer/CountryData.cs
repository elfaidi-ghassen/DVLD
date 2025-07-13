using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace DataAccessLayer
{
    public class CountryData
    {
        public static Country FindCountryByName(string name)
        {
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"SELECT *
                             FROM countries
                             WHERE CountryName = @CountryName";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@CountryName", name);
            int? countryId = null;
            string countryName = null;
            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    countryId = (int)reader["CountryId"];
                    countryName = (string)reader["CountryName"];
                }
            }
            catch (Exception e)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            if (isFound)
                return new Country((int)countryId, countryName);
            else
                return null;
        }
        public static List<Country> GetAllCountries()
        {
            List<Country> countries = new List<Country>();
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"SELECT * 
                     FROM Countries";
            SqlCommand command = new SqlCommand(QUERY, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = (int)reader["CountryId"];
                    string name = (string)reader["CountryName"];
                    countries.Add(new Country(id, name));
                   
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return countries;

        }

        public static Country FindCountryById(int id)
        {
            SqlConnection connection = new SqlConnection(Settings.ConnectionString);
            string QUERY = @"SELECT *
                             FROM countries
                             WHERE CountryId = @CountryId";
            SqlCommand command = new SqlCommand(QUERY, connection);
            command.Parameters.AddWithValue("@CountryId", id);
            int? countryId = null;
            string countryName = null;
            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    countryId = (int)reader["CountryId"];
                    countryName = (string)reader["CountryName"];
                }
            }
            catch (Exception e)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }
            if (isFound)
                return new Country((int)countryId, countryName);
            else
                return null;
        }
    }
}
