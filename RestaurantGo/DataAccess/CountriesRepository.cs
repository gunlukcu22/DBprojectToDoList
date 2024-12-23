using MySql.Data.MySqlClient;
using System.Data;

namespace RestaurantGo.DataAccess
{
    public static class CountriesRepository
    {
        public static DataTable GetAllCountries()
        {
            string query = "SELECT CountryID, CountryName FROM Countries;";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public static DataTable GetCountriesByCuisine(int cuisineId)
        {
            string query = @"
                SELECT DISTINCT CountryID
                FROM Locations
                WHERE CityID IN (
                    SELECT CityID 
                    FROM Restaurants 
                    WHERE CuisineID = @CuisineId
                );";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@CuisineId", cuisineId)
            };

            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
    }
}
