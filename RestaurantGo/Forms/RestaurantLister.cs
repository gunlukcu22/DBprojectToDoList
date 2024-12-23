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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading countries: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCuisines()
        {
            try
            {
                var cuisines = CuisinesRepository.GetAllCuisines();
                cuisinePicker.DataSource = cuisines;
                cuisinePicker.DisplayMember = "CuisineType";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cuisines: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCities(string country)
        {
            try
            {
                var cities = CitiesRepository.GetCitiesByCountry(country);
                cityPicker.DataSource = cities;
                cityPicker.DisplayMember = "CityName";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cities: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CountryPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (countryPicker.SelectedItem != null)
            {
                string selectedCountry = countryPicker.SelectedItem.ToString();
                LoadCities(selectedCountry);
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
                    SELECT RestaurantName, LocationID, PriceRange
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
