using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        int employeeId = 5;
        string newTitle = "Sales Lead";

        UpdateEmployeeTitle(employeeId, newTitle);

        Console.ReadLine();
    }
    static void UpdateEmployeeTitle(int employeeId, string newTitle)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;"
            + "Integrated Security=true";
        string updateQuery = "UPDATE Employees SET Title = @Title WHERE EmployeeID = @EmployeeID";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(updateQuery, connection);

            command.Parameters.AddWithValue("@Title", newTitle);
            command.Parameters.AddWithValue("@EmployeeID", employeeId);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                    Console.WriteLine("Employee title update successfully.");
                else
                    Console.WriteLine("No employee found with ID: " + employeeId);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}