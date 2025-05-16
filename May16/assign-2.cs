using System;
using System.Data.SqlClient;

class ProductOrderJoinDemo
{
    static void Main()
    {
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
                + "Integrated Security=true");

        string query = @"
            SELECT 
                p.ProductName,
                o.OrderID,
                o.OrderDate,
                od.Quantity,
                od.UnitPrice
            FROM 
                Products p
                INNER JOIN [Order Details] od ON p.ProductID = od.ProductID
                INNER JOIN Orders o ON od.OrderID = o.OrderID
            ORDER BY o.OrderDate DESC";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            try
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("{0,-30} {1,-10} {2,-15} {3,-10} {4,-10}",
                        "Product Name", "OrderID", "Order Date", "Quantity", "Unit Price");
                    Console.WriteLine(new string('-', 80));

                    while (reader.Read())
                    {
                        string productName = reader["ProductName"].ToString();
                        int orderId = (int)reader["OrderID"];
                        DateTime orderDate = (DateTime)reader["OrderDate"];
                        short quantity = (short)reader["Quantity"];
                        decimal unitPrice = (decimal)reader["UnitPrice"];

                        Console.WriteLine("{0,-30} {1,-10} {2,-15:yyyy-MM-dd} {3,-10} {4,-10:C}",
                            productName, orderId, orderDate, quantity, unitPrice);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}