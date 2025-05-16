/*
 * using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";

        // Provide the query string with a parameter placeholder.
        string queryString =
            "SELECT ProductID, UnitPrice, ProductName from dbo.products "
                + "WHERE UnitPrice > @pricePoint "
                + "ORDER BY UnitPrice DESC;";
        // Specify the parameter value
        int paramValue = 5;

        //Create and open the connection in a using block. This
        //ensure that all resources will be closed and disposed
        //when the code exits
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            //Create the command and parameters object
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@pricePoint", paramValue);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}",
                        reader[0], reader[1], reader[2]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}

*/


/* using System;
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
            // 2. open the connection
            conn.Open();
            // 3. Pass the connection to a command object
            SqlCommand cmd = new SqlCommand("select * from Customers", conn);

            //
            // 4. use the connection
            //

            // get query results
            rdr = cmd.ExecuteReader();
            //
            // print the CustomerID of each record
            while (rdr.Read())
            {
                Console.WriteLine(rdr[1]);
            }

        }
        catch
        {

        }
        finally
        {
            // close the reader
            if (rdr != null)
            {
                rdr.Close();
            }

            //5. Close the connection
            if (conn != null)
            {
                conn.Close();
            }
        }

    }
}
*/