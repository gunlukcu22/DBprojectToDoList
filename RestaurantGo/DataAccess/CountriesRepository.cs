using System.Data;

namespace RestaurantGo.DataAccess
{
    public static class CountriesRepository
    {
        public static DataTable GetAllCountries()
        {
            string query = "SELECT CountryName FROM Countries;";
            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}
