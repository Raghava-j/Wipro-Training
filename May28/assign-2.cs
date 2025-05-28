using System;
using System.Data.SqlClient;
class Program
{
    static void Main()
    {
        Console.Write("Enter Customer ID:");
        string customerId = Console.ReadLine();
        GetOrderByCustomer(customerId);
        Console.ReadLine();
    }
    static void GetOrderByCustomer(string customerId)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
                + "Integrated Security=true";
        string queryString = 
            "SELECT OrderID, OrderDate, ShipCountry FROM Orders" +
            "WHERE CustomerID = @customerId ORDER BY OrderDate DESC";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@customerId", customerId);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    Console.WriteLine("No orders found for Customer ID: " + customerId);
                }
                else
                {
                    Console.WriteLine("OrderId\tOrderDate\tShipCountry");
                    Console.WriteLine("-----------------------------------------");
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1:yyyy-MM-dd}\t{2}",
                            reader["OrderID"],
                            reader["OrderDate"],
                            reader["ShipCountry"]);
                    }
                }
                reader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
            }
        }
    }
}