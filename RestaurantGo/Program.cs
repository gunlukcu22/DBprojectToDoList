using RestaurantGo.DataAccess;

namespace DBprojectToDoList
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Test DatabaseHelper before launching the form
            TestDatabaseHelper();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new RestaurantLister());
        }

        private static void TestDatabaseHelper()
        {
            try
            {
                // Step 1: Fetch data from Restaurants table
                string query = "SELECT * FROM Restaurants;";
                var result = DatabaseHelper.ExecuteQuery(query);

                foreach (System.Data.DataRow row in result.Rows)
                {
                    Console.WriteLine($"RestaurantID: {row["RestaurantID"]}, Name: {row["RestaurantName"]}");
                }

                // Step 2: Insert data into ToDoList table
                string insertQuery = @"
                    INSERT INTO ToDoList (RestaurantID, RestaurantName, LocationID, IsChecked, Notes)
                    VALUES (@RestaurantID, @RestaurantName, @LocationID, @IsChecked, @Notes);";

                var parameters = new MySql.Data.MySqlClient.MySqlParameter[]
                {
                    new MySql.Data.MySqlClient.MySqlParameter("@RestaurantID", 1), // Replace with actual ID
                    new MySql.Data.MySqlClient.MySqlParameter("@RestaurantName", "Example Restaurant"),
                    new MySql.Data.MySqlClient.MySqlParameter("@LocationID", 1), // Replace with actual LocationID
                    new MySql.Data.MySqlClient.MySqlParameter("@IsChecked", false),
                    new MySql.Data.MySqlClient.MySqlParameter("@Notes", "Visited for testing purposes")
                };

                DatabaseHelper.ExecuteNonQuery(insertQuery, parameters);
                Console.WriteLine("Data inserted into ToDoList successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database test failed: " + ex.Message);
            }
        }
    }
}
