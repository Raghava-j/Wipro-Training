using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
           + "Integrated Security=true";
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            try
            {
                string query = @"
                   SELECT P.CategoryID,
                          SUM(OD.UnitPrice *OD.Quantity) AS TotalSales
                   FROM [Order Details] OD
                   JOIN Products P ON OD.ProductID = P.ProductID
                   GROUP BY P.CategoryID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();

                adapter.Fill(table);

                Console.WriteLine("CategoryID\tTotalSales");
                Console.WriteLine("---------------------------");

                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine($"{row["CategoryID"]}\t\t{row["TotalSales"]:C}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
        Console.ReadKey();
    }
}
        