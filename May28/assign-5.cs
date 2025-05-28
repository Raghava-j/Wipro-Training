using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        int productIdToDelete = 78;
        DeleteProduct(productIdToDelete);

        Console.ReadLine();
    }
    static void DeleteProduct(int productId)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";
        string deleteQuery = "DELETE FROM Products WHERE ProductID = @ProductID";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(deleteQuery, connection);
            command.Parameters.AddWithValue("@ProductID", productId);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                    Console.WriteLine($"Product with ID {productId} wasdeleted successfully.");
                else
                    Console.WriteLine($"No product found with ID {productId}.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}