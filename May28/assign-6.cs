using System;
using System.Data.SqlClient;
class Program
{
    static void Main()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";

        string query = @"
          SELECT Orders.OrderID, Customers.CompanyName, Orders.OrderDate
          FROM Orders
          INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int orderId = reader.GetInt32(0);
                        string companyName = reader.GetString(1);
                        DateTime orderDate = reader.GetDateTime(2);

                        Console.WriteLine($"OrderID: {orderId}, CompanyName: {companyName}, OrderDate: {orderDate:d}");
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
            }
        }
    }
}