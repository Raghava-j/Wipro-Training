using System;
using System.Data;
using System.Data.SqlClient;
class Program
{
    static void Main()

    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";
        Console.Write("Enter Customer ID:");
        string customerId = Console.ReadLine();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand("CustOrderHist", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CustomerID", customerId);

            connection.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string productName = reader["ProductName"].ToString();
                    int total = Convert.ToInt32(reader["Total"]);

                    Console.WriteLine($"Product: {productName}, Total: {total}");
                }
            }
        }
    }
}

            