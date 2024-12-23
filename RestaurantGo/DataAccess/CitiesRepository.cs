using MySql.Data.MySqlClient;
using System.Data;

namespace RestaurantGo.DataAccess
{
    public static class CitiesRepository
    {
        public static DataTable GetCitiesByCountry(string countryName)
        {
            string query = @"
                SELECT CityName 
                FROM Cities 
                INNER JOIN Countries ON Cities.CountryID = Countries.CountryID
                WHERE Countries.CountryName = @CountryName;";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@CountryName", countryName)
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
    }
}
