using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace RestaurantGo.DataAccess
{
    public static class DatabaseHelper
    {
        // Update this with your actual MySQL connection string
        private static readonly string connectionString = "Server= localhost;Database=RestaurantGo;User=root;Password=admin;";

        /// <summary>
        /// Executes a query that returns a result set (e.g., SELECT).
        /// </summary>
        ///<param name="query">The SQL query to execute.</param>
        /// <param name="parameters">Optional parameters for the query.</param>
        /// <returns>A DataTable containing the query results.</returns>
        /// 

        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connection successful!");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection failed: {ex.Message}");
                return false;
            }
        }

        public static DataTable ExecuteQuery(string query, MySqlParameter[] parameters = null)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(query, connection);

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);

                        // Debugging Parameters
                        foreach (var param in parameters)
                        {
                            Console.WriteLine($"Parameter: {param.ParameterName}, Value: {param.Value}");
                        }
                    }

                    DataTable dataTable = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error executing query: {ex.Message}");
                throw new Exception("Error executing query: " + ex.Message, ex);
            }
        }


        /// <summary>
        /// Executes a non-query command (e.g., INSERT, UPDATE, DELETE).
        /// </summary>
        /// <param name="query">The SQL query to execute.</param>
        /// <param name="parameters">Optional parameters for the query.</param>
        public static void ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                throw new Exception("Error executing non-query: " + ex.Message, ex);
            }
        }
    }
}
