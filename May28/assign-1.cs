using System;
using System.Data.SqlClient;
class Program
{
    static void Main()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
                + "Integrated Security=true";

        string queryString = "SELECT CustomerID, CompanyName, Country From Customers";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            try
            {
                connection.Open();
                SqlDataReader rdr = command.ExecuteReader();
                
                while (rdr.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}",
                        rdr["CustomerID"], rdr["CompanyName"], rdr["Country"]);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.ReadLine();
        }

    }
}