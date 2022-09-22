using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DataConnectivity_Assignment2
{
    class Program
    {
        static void AddProgram()
        {
            Console.WriteLine("AddProgram");

            SqlConnection MyDataSource; // declaration
            MyDataSource = new(); // instantiation
            MyDataSource.ConnectionString = @"Persist Security Info=False;Integrated Security=True;Database=ptrninkov1;server=(localDB)\MSSQLLocalDB;"; //Windows Authentication
                                           //"Persist Security Info=False;Database=ptrninkov1;User ID=ptrninkov1;Password=xxxx;server=dev1.baist.ca"; //SQL SERVER authentication
            MyDataSource.Open();

            SqlCommand SQLCommand = new(); // Declaration and instantiation
            SQLCommand.Connection = MyDataSource;
            SQLCommand.CommandType = CommandType.StoredProcedure;
            SQLCommand.CommandText = "AddProgram";

            SqlParameter sqlParameter;
            sqlParameter = new()//object initialization syntax
            {
                ParameterName = "@ProgramCode",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "EXAMPLE3"
            };
            SQLCommand.Parameters.Add(sqlParameter);

            sqlParameter = new()
            {
                ParameterName = "@Description",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "Example Description3"
            };
            SQLCommand.Parameters.Add(sqlParameter);

            SQLCommand.ExecuteNonQuery();

            MyDataSource.Close();

            Console.WriteLine("Success - AddProgram");
        }
        static void GetProgram()
        {
            Console.WriteLine("GetProgram");

            SqlConnection MyDataSource = new();
            MyDataSource.ConnectionString = @"Persist Security Info=False;Integrated Security=True;Database=ptrninkov1;server=(localDB)\MSSQLLocalDB;";

            MyDataSource.Open();

            SqlCommand SQLCommand = new();
            SQLCommand.Connection = MyDataSource;
            SQLCommand.CommandType = CommandType.StoredProcedure;
            SQLCommand.CommandText = "GetProgram";

            SqlParameter sqlParameter = new()
            {
                ParameterName = "@ProgramCode",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "DMIT"
            };

            SQLCommand.Parameters.Add(sqlParameter);
            Console.WriteLine(SQLCommand.ExecuteScalar().ToString());

            MyDataSource.Close();

            Console.WriteLine("Success - GetProgram");
        }
        static void Main(string[] args)
        {
            //AddProgram();
            GetProgram();
        }
    }
}
