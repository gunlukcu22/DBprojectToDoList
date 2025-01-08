using RestaurantGo.DataAccess;
using MySql.Data.MySqlClient;

namespace DBprojectToDoList
{
    public partial class RestaurantLister : Form
    {
        public RestaurantLister()
        {
            InitializeComponent();

            if (!DatabaseHelper.TestConnection())
            {
                MessageBox.Show("Failed to connect to the database. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close(); // Close the application if the connection fails
            }

            LoadCountries();
            countryPicker.SelectedIndexChanged += countryPicker_SelectedIndexChanged;
            filterRestaurantsButton.Click += filterRestaurantsButton_Click;
            /* LoadCities(); */
            LoadCuisines();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialization logic if needed.
        }

        private void LoadCountries()
        {
            try
            {
                var countries = CountriesRepository.GetAllCountries();
                MessageBox.Show($"Number of countries retrieved: {countries.Rows.Count}");
                if (countries.Rows.Count > 0 && countries.Columns.Contains("CountryCode"))
                {
                    countryPicker.DataSource = null; // Clear existing data binding
                    countryPicker.DisplayMember = "CountryName";
                    countryPicker.ValueMember = "CountryCode"; // Ensure ValueMember matches the query parameter
                    countryPicker.DataSource = countries;

                    // Set the default selected value to the first country
                    countryPicker.SelectedIndex = 0;
                }
                else
                {
                    countryPicker.DataSource = null;
                    MessageBox.Show("No countries available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading countries: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCities()
        {
            try
            {
                // Get the selected country
                var selectedCountryCode = countryPicker.SelectedValue?.ToString();

                if (string.IsNullOrEmpty(selectedCountryCode))
                {
                    MessageBox.Show("Please select a country first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cityPicker.DataSource = null; // Clear the city picker
                    return;
                }

                // Fetch cities for the selected country
                var cities = CitiesRepository.GetCitiesByCountry(selectedCountryCode);

                if (cities.Rows.Count > 0 && cities.Columns.Contains("CityName"))
                {
                    cityPicker.DataSource = null; // Clear existing data binding
                    cityPicker.DisplayMember = "CityName";
                    cityPicker.ValueMember = "CityID";
                    cityPicker.DataSource = cities;
                }
                else
                {
                    cityPicker.DataSource = null;
                    MessageBox.Show("No cities available for the selected country.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cities: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*private void LoadCities()
        {
            try
            {
                var cities = CitiesRepository.GetAllCities(); // Fetch all cities
                if (cities.Rows.Count > 0 && cities.Columns.Contains("CityName"))
                {
                    cityPicker.DataSource = null; // Clear existing data binding
                    cityPicker.DisplayMember = "CityName";
                    cityPicker.ValueMember = "CityID";
                    cityPicker.DataSource = cities;
                }
                else
                {
                    cityPicker.DataSource = null;
                    MessageBox.Show("No cities available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cities: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void countryPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCities();
        }

        private void LoadCuisines()
        {
            try
            {
                var cuisines = CuisinesRepository.GetAllCuisines(); // Fetch all cuisines
                if (cuisines.Rows.Count > 0 && cuisines.Columns.Contains("CuisineType"))
                {
                    cuisinePicker.DataSource = null; // Clear existing data binding
                    cuisinePicker.DisplayMember = "CuisineType";
                    cuisinePicker.ValueMember = "CuisineID";
                    cuisinePicker.DataSource = cuisines;
                }
                else
                {
                    cuisinePicker.DataSource = null;
                    MessageBox.Show("No cuisines available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cuisines: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterCountriesByCuisine(int cuisineId)
        {
            try
            {
                var countries = CountriesRepository.GetCountriesByCuisine(cuisineId);
                countryPicker.DataSource = null; // Clear existing data binding
                countryPicker.DisplayMember = "CountryID";
                countryPicker.ValueMember = "CountryID";
                countryPicker.DataSource = countries;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering countries by cuisine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void filterRestaurantsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Filter Restaurants button clicked!");

            try
            {
                // Get selected city
                string cityName = cityPicker.SelectedValue?.ToString();

                if (string.IsNullOrEmpty(cityName))
                {
                    MessageBox.Show("Please select a city to filter restaurants.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show($"Selected City: {cityName}");

                // Query to filter restaurants by the selected city
                string query = @"
                SELECT RestaurantID, RestaurantName, LocationID, PriceRange
                FROM Restaurants
                WHERE LocationID IN 
                (SELECT Locations.LocationID 
                 FROM Locations 
                 WHERE Locations.CityName = @CityName);";

                var parameters = new MySqlParameter[]
                {
            new MySqlParameter("@CityName", cityName)
                };

                // Execute the query and bind the results to the grid
                var dataTable = DatabaseHelper.ExecuteQuery(query, parameters);
                MessageBox.Show($"Rows Returned: {dataTable.Rows.Count}");
                restaurantGrid.DataSource = dataTable;

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No restaurants found for the selected city.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching restaurants: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* private void filterRestaurantsButton_Click(object sender, EventArgs e)
         {
             try
             {
                 string country = countryPicker.SelectedItem?.ToString() ?? "";
                 string city = cityPicker.SelectedItem?.ToString() ?? "";
                 string cuisine = cuisinePicker.SelectedItem?.ToString() ?? "";

                 string query = @"
                     SELECT RestaurantID, RestaurantName, LocationID, PriceRange
                     FROM Restaurants
                     WHERE (@Country = '' OR LocationID IN 
                         (SELECT Locations.LocationID 
                          FROM Locations 
                          INNER JOIN Cities ON Locations.CityID = Cities.CityID 
                          WHERE Cities.CountryCode = @Country))
                       AND (@City = '' OR LocationID IN 
                         (SELECT Locations.LocationID 
                          FROM Locations
                          WHERE Cities.CityName = @City))
                       AND (@Cuisine = '' OR RestaurantID IN 
                         (SELECT RestaurantID FROM Restaurant_Cuisines 
                          INNER JOIN Cuisines ON Restaurant_Cuisines.CuisineID = Cuisines.CuisineID 
                          WHERE Cuisines.CuisineType = @Cuisine));";

                 var parameters = new MySqlParameter[]
                 {
                     new MySqlParameter("@Country", country),
                     new MySqlParameter("@City", city),
                     new MySqlParameter("@Cuisine", cuisine)
                 };

                 var dataTable = DatabaseHelper.ExecuteQuery(query, parameters);
                 restaurantGrid.DataSource = dataTable;
             }
             catch (Exception ex)
             {
                 MessageBox.Show($"Error fetching restaurants: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }*/

        private void addToMyListButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in restaurantGrid.SelectedRows)
                {
                    string query = @"
                INSERT INTO ToDoList (RestaurantID, RestaurantName, IsChecked)
                VALUES (@RestaurantID, @RestaurantName, @IsChecked);";

                    var parameters = new MySqlParameter[]
                    {
                new MySqlParameter("@RestaurantID", row.Cells["RestaurantID"].Value),
                new MySqlParameter("@RestaurantName", row.Cells["RestaurantName"].Value),
                new MySqlParameter("@IsChecked", false)
                    };

                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                }

                MessageBox.Show("Selected restaurants added to My List.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMyList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding to My List: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMyList()
        {
            try
            {
                string query = "SELECT * FROM ToDoList;";
                var dataTable = DatabaseHelper.ExecuteQuery(query);
                myListGrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading My List: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeMyListGrid()
        {
            myListGrid.Columns.Clear();
            myListGrid.AutoGenerateColumns = false;

            var checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Visited",
                DataPropertyName = "IsChecked",
                Name = "IsChecked"
            };
            myListGrid.Columns.Add(checkBoxColumn);

            var nameColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = "Restaurant Name",
                DataPropertyName = "RestaurantName",
                Name = "RestaurantName"
            };
            myListGrid.Columns.Add(nameColumn);

            // Add more columns as needed
        }

        private void MyListGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && myListGrid.Columns[e.ColumnIndex].Name == "IsChecked")
            {
                var row = myListGrid.Rows[e.RowIndex];
                bool isChecked = Convert.ToBoolean(row.Cells["IsChecked"].Value);
                int toDoID = Convert.ToInt32(row.Cells["ToDoID"].Value);

                string query = "UPDATE ToDoList SET IsChecked = @IsChecked WHERE ToDoID = @ToDoID;";
                var parameters = new MySqlParameter[]
                {
            new MySqlParameter("@IsChecked", isChecked),
            new MySqlParameter("@ToDoID", toDoID)
                };

                try
                {
                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating visited status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in myListGrid.SelectedRows)
                {
                    int toDoID = Convert.ToInt32(row.Cells["ToDoID"].Value);

                    string query = "DELETE FROM ToDoList WHERE ToDoID = @ToDoID;";
                    var parameters = new MySqlParameter[]
                    {
                new MySqlParameter("@ToDoID", toDoID)
                    };

                    DatabaseHelper.ExecuteNonQuery(query, parameters);
                }

                MessageBox.Show("Selected restaurants removed from My List.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMyList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing from My List: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Event logic for label2 if needed.
        }

        private void myListLabel_Click(object sender, EventArgs e)
        {
            // Event logic for myListLabel if needed.
        }

        private void footNote_Click(object sender, EventArgs e)
        {
            // Event logic for footNote if needed.
        }
    }
}
