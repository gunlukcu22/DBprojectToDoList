using MySql.Data.MySqlClient;
using RestaurantGo.DataAccess;

namespace DBprojectToDoList
{
    public partial class RestaurantLister : Form
    {
        public RestaurantLister()
        {
            InitializeComponent();
            LoadCountries();
            LoadCities(); // Load all cities at startup
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
                countryPicker.DataSource = countries;
                countryPicker.DisplayMember = "CountryName";
                countryPicker.ValueMember = "CountryName"; // Ensure ValueMember is set for selection
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

        private void FilterRestaurantsButton_Click(object sender, EventArgs e)
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
                         INNER JOIN Countries ON Cities.CountryID = Countries.CountryID
                         WHERE Countries.CountryName = @Country))
                      AND (@City = '' OR LocationID IN 
                        (SELECT Locations.LocationID 
                         FROM Locations 
                         INNER JOIN Cities ON Locations.CityID = Cities.CityID 
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
        }

        private void AddToMyListButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in restaurantGrid.SelectedRows)
                {
                    string query = @"
                        INSERT INTO ToDoList (RestaurantID, RestaurantName, LocationID, IsChecked)
                        VALUES (@RestaurantID, @RestaurantName, @LocationID, @IsChecked);";

                    var parameters = new MySqlParameter[]
                    {
                        new MySqlParameter("@RestaurantID", row.Cells["RestaurantID"].Value),
                        new MySqlParameter("@RestaurantName", row.Cells["RestaurantName"].Value),
                        new MySqlParameter("@LocationID", row.Cells["LocationID"].Value),
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
