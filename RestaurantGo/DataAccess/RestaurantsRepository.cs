using System.Collections.Generic;
using System.Data;
using RestaurantGo.Models;
using Microsoft.Data.SqlClient;


namespace RestaurantGo.DataAccess
{
    public class RestaurantsRepository
    {
        public List<Restaurant> GetAllRestaurants()
        {
            string query = "SELECT RestaurantID, RestaurantName, LocationID, PriceRange FROM Restaurants;";
            DataTable dataTable = DatabaseHelper.ExecuteQuery(query);

            var restaurants = new List<Restaurant>();
            foreach (DataRow row in dataTable.Rows)
            {
                restaurants.Add(new Restaurant
                {
                    RestaurantID = (int)row["RestaurantID"],
                    RestaurantName = row["RestaurantName"].ToString(),
                    LocationID = (int)row["LocationID"],
                    PriceRange = (int)row["PriceRange"]
                });
            }
            return restaurants;
        }

    }
}
