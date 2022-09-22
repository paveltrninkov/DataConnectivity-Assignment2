using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DataConnectivity_Assignment2
{
    class Program
    {
        static void AddProgram()
        {
            Console.WriteLine("AddProgramExecuteNonQueryExample");

            SqlConnection MyDataSource; // declaration
            MyDataSource = new(); // instantiation
            MyDataSource.ConnectionString = @"Persist Security Info=False;Integrated Security=True;Database=ptrninkov1;server=(localDB)\MSSQLLocalDB;"; //Windows Authentication
                                           //"Persist Security Info=False;Database=ptrninkov1;User ID=ptrninkov1;Password=xxxx;server=dev1.baist.ca"; //SQL SERVER authentication
            MyDataSource.Open();

            SqlCommand ExampleCommand = new(); // Declaration and instantiation
            ExampleCommand.Connection = MyDataSource;
            ExampleCommand.CommandType = CommandType.StoredProcedure;
            ExampleCommand.CommandText = "AddProgram";

            SqlParameter ExampleCommandParameter;
            ExampleCommandParameter = new()//object initialization syntax
            {
                ParameterName = "@ProgramCode",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "EXAMPLE3"
            };
            ExampleCommand.Parameters.Add(ExampleCommandParameter);

            ExampleCommandParameter = new()
            {
                ParameterName = "@Description",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "Example Description3"
            };
            ExampleCommand.Parameters.Add(ExampleCommandParameter);

            ExampleCommand.ExecuteNonQuery();

            MyDataSource.Close();

            Console.WriteLine("Success - ExecuteNonQuery");
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            AddProgram();
        }
    }
}
