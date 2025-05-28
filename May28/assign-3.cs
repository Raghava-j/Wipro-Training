using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        InsertProduct("Test Product", 1, 1, 25m);
        Console.ReadLine();
    }
    static void InsertProduct(string productName, int supplierId, int categoryId, decimal unitPrice)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";
        string queryString = "INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice) " +
                             "VALUES (@ProductName, @SupplierID, @CategoryID, @UnitPrice)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);

            command.Parameters.AddWithValue("@ProductName", productName);
            command.Parameters.AddWithValue("@SupplierID", supplierId);
            command.Parameters.AddWithValue("@CategoryID", categoryId);
            command.Parameters.AddWithValue("@UnitPrice", unitPrice);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine("Rows inserted: " + rowsAffected);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: " + e.Message);
            }
        }

    }
}