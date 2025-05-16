using System;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Demonstrates how to work with SqlConnection objects
/// </summary>summary>

class SqlConnectionDemo
{
    static void Main()
    {
        //1. Instantita the connection
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true");

        SqlDataReader rdr = null;

        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ContactName, City, CompanyName FROM Customers", conn);
            rdr = cmd.ExecuteReader();

            Console.WriteLine("{0, -25} {1,-15} {2,-40}", "Contact Name", "City", "Company Name");
            Console.WriteLine(new string('-', 25) + " " + new string('-', 15) + " " + new string('-', 40));

            while (rdr.Read())
            {
                Console.WriteLine("{0,-25} {1,-15} {2,-40}",
                    rdr["ContactName"].ToString(),
                    rdr["City"].ToString(),
                    rdr["CompanyName"].ToString());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            if (rdr != null)
                rdr.Close();

            if (conn != null)
                conn.Close();
        }
    }
}