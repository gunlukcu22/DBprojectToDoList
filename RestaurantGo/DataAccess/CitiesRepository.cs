using MySql.Data.MySqlClient;
using System.Data;

namespace RestaurantGo.DataAccess
{
    public static class CitiesRepository
    {
        public static DataTable GetAllCities()
        {
            string query = "SELECT CityID, CityName FROM Cities;";

            return DatabaseHelper.ExecuteQuery(query);
        }

        public static DataTable GetCitiesByCountry(string countryCode)
        {
            string query = @"
                SELECT CityID, CityName 
                FROM Cities 
                INNER JOIN Countries ON Cities.CountryCode = Countries.CountryCode
                WHERE Countries.CountryCode = @CountryCode;";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@CountryCode", countryCode)
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
    }
}
