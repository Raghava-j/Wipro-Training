using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";
        string query = "SELECT * FROM Products";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Products");
            DataTable products = dataSet.Tables["Products"];

            Console.WriteLine("Products with UnitsInStock > 20:\n");

            foreach (DataRow row in products.Rows)
            {
                if (Convert.ToInt32(row["UnitsInStock"]) > 20)
                {
                    Console.WriteLine($"Products: {row["ProductName"]}, Units In Stock : {row["UnitsInStock"]}");
                }
            }
        }
    }
}