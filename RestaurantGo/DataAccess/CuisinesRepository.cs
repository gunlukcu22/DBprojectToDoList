using System.Data;

namespace RestaurantGo.DataAccess
{
    public static class CuisinesRepository
    {
        public static DataTable GetAllCuisines()
        {
            string query = "SELECT CuisineType FROM Cuisines;";
            return DatabaseHelper.ExecuteQuery(query);
        }
    }
}
