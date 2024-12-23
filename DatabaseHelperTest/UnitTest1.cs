using RestaurantGo.DataAccess;
using System.Data;

[Fact]
public void TestExecuteQuery()
{
    string query = "SELECT * FROM Restaurants;";
    DataTable result = DatabaseHelper.ExecuteQuery(query);

    Assert.NotNull(result);
    Assert.True(result.Rows.Count > 0, "No data returned from query.");
}
