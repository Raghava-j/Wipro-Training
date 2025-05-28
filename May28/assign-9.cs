using System;
using System.Data;
using System.Data.SqlClient;
class Program
{
    static void Main()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();

            try
            {
                SqlCommand insertOrder = new SqlCommand(@"
                    INSERT INTO Orders (CustomerID, OrderDate, RequiredDate, ShipVia)
                    VALUES (@CustomerID, @OrderDate, @RequiredDate, @ShipVia);
                    SELECT SCOPE_IDENTITY();", connection, transaction);
                insertOrder.Parameters.AddWithValue("@CustomerID", "ALFKI");
                insertOrder.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                insertOrder.Parameters.AddWithValue("@RequiredDate", DateTime.Now.AddDays(7));
                insertOrder.Parameters.AddWithValue("@ShipVia", 1);

                int orderId = Convert.ToInt32(insertOrder.ExecuteScalar());

                SqlCommand insertDetails = new SqlCommand(@"
                    INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount)
                    VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount);", connection, transaction);
                insertDetails.Parameters.AddWithValue("@OrderID", orderId);
                insertDetails.Parameters.AddWithValue("@ProductID", 1);
                insertDetails.Parameters.AddWithValue("@UnitPrice", 18.00);
                insertDetails.Parameters.AddWithValue("@Quantity", 10);
                insertDetails.Parameters.AddWithValue("@Discount", 0);

                insertDetails.ExecuteNonQuery();

                transaction.Commit();
                Console.WriteLine($"Transaction committed. Order ID : {orderId}");
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    Console.WriteLine("Transaction rolled back due to an error.");
                }
                catch (Exception rollbackE)
                {
                    Console.WriteLine("Rollback error: " + rollbackE.Message);
                    Console.WriteLine();

                }
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}