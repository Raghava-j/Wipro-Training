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
/*
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Intrinsics.Arm;

namespace Lesson04
{
    class ReaderDemo
    {
        static void Main()
        {
            ReaderDemo rd = new ReaderDemo();
            rd.SimpleRead();
        }

        public void SimpleRead()
        {
            // delclare the sqldatareader, which is used in
            //both the try block and finally block


            SqlDataReader rdr = null;

            // create a connection object
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
                + "Integrated Security=true");

            SqlCommand cmd = new SqlCommand("select * from customers", conn);

            try
            {
                // open the connection
                conn.Open();

                //1. get an instance of the sqlDataReader
                rdr = cmd.ExecuteReader();

                // print a set of column headers
                Console.WriteLine("Contact Name               City                 Company Name");
                Console.WriteLine("-------------              ------------         -----------");

                //2. print necessary columns of each record
                while (rdr.Read())
                {
                    // get the results of each column
                    string contact = (string)rdr["ContactName"];
                    string company = (string)rdr["CompanyName"];
                    string city = (string)rdr["City"];

                    // PRintout the results
                    Console.Write("{0,-25}", contact);
                    Console.Write("{0,-20}", city);
                    Console.Write("{0,-40}", company);
                    Console.WriteLine();
                }

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
}
*/