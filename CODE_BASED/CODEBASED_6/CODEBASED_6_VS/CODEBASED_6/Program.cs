//c.Using Ado.net classes/methods, insert employee record in the table by invoking the procedure

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CODEBASED_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=ICS-LT-86JS8G3\MSSQLSERVER01;Database=CODEBASED_6;Trusted_Connection=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("AddEmployees", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@empno", 1335);
                    command.Parameters.AddWithValue("@empname", "VINOD");
                    command.Parameters.AddWithValue("@empsal", 1000.00);
                    command.Parameters.AddWithValue("@emptype", "F");

                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Employee Inserted successfully.");


     // d)Display all records

            DisplayAllEmployeeRecords(connectionString);
            Console.ReadLine();
        }


        static void DisplayAllEmployeeRecords(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Code_Employees", connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Employee ID: {reader["empno"]}, Name: {reader["empname"]}, Salary: {reader["empsal"]}, Type: {reader["emptype"]}");
                    }
                }
            }
        }





















    }
}