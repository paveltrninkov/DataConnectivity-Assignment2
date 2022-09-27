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

            SqlParameter SQLParameter;
            SQLParameter = new()//object initialization syntax
            {
                ParameterName = "@ProgramCode",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "Demo"
            };
            SQLCommand.Parameters.Add(SQLParameter);

            SQLParameter = new()
            {
                ParameterName = "@Description",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "Demo Description"
            };
            SQLCommand.Parameters.Add(SQLParameter);

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

            SqlParameter SQLParameter = new()
            {
                ParameterName = "@ProgramCode",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "Demo"
            };

            SQLCommand.Parameters.Add(SQLParameter);
            Console.WriteLine(SQLCommand.ExecuteScalar().ToString());

            MyDataSource.Close();

            Console.WriteLine("Success - GetProgram");
        }
    
        static void AddStudent()
        {
            Console.WriteLine("AddStudent");

            SqlConnection MyDataSource = new();
            MyDataSource.ConnectionString = @"Persist Security Info=False;Integrated Security=True;Database=ptrninkov1;server=(localDB)\MSSQLLocalDB;";
            MyDataSource.Open();

            SqlCommand SQLCommand = new()
            {
                Connection = MyDataSource,
                CommandType = CommandType.StoredProcedure,
                CommandText = "AddStudent"
            };

            SqlParameter SQLParameter = new()
            {
                ParameterName = "@StudentID",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "57122"
            };
            SQLCommand.Parameters.Add(SQLParameter);

            SQLParameter = new()
            {
                ParameterName = "@FirstName",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "Bill"
            };
            SQLCommand.Parameters.Add(SQLParameter);

            SQLParameter = new()
            {
                ParameterName = "@LastName",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "Clinton"
            };
            SQLCommand.Parameters.Add(SQLParameter);

            SQLParameter = new()
            {
                ParameterName = "@Email",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "none@sexual.relation"
            };
            SQLCommand.Parameters.Add(SQLParameter);

            SQLParameter = new()
            {
                ParameterName = "@ProgramCode",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "BAIST"
            };
            SQLCommand.Parameters.Add(SQLParameter);

            SQLCommand.ExecuteNonQuery();
            MyDataSource.Close();

            Console.WriteLine("Success - AddStudent");
        }

        static void UpdateStudent()
        {
            Console.WriteLine("UpdateStudent");

            SqlConnection MyDataSource = new();
            MyDataSource.ConnectionString = @"Persist Security Info=False;Integrated Security=True;Database=ptrninkov1;server=(LocalDB)\MSSQLLocalDB;";
            MyDataSource.Open();

            SqlCommand SQLCommand = new()
            {
                Connection = MyDataSource,
                CommandType = CommandType.StoredProcedure,
                CommandText = "UpdateStudent"
            };

            SqlParameter SQLParameter = new()
            {
                ParameterName = "@StudentID",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "57122"
            };
            SQLCommand.Parameters.Add(SQLParameter);

            SQLParameter = new()
            {
                ParameterName = "@FirstName",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "Cill"
            };
            SQLCommand.Parameters.Add(SQLParameter);

            SQLParameter = new()
            {
                ParameterName = "@LastName",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "Blinton"
            };
            SQLCommand.Parameters.Add(SQLParameter);

            SQLParameter = new()
            {
                ParameterName = "@Email",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "something"
            };
            SQLCommand.Parameters.Add(SQLParameter);

            SQLParameter = new()
            {
                ParameterName = "@ProgramCode",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "Demo"
            };
            SQLCommand.Parameters.Add(SQLParameter);

            SQLCommand.ExecuteNonQuery();

            MyDataSource.Close();
            Console.WriteLine("Success - UpdateStudent");
        }

        static void DeleteStudent()
        {
            Console.WriteLine("DeleteStudent");
            SqlConnection MyDataSource = new();
            MyDataSource.ConnectionString = @"Persist Security Info=False;Integrated Security=True;Database=ptrninkov1;server=(LocalDB)\MSSQLLocalDB;";
            MyDataSource.Open();

            SqlCommand SQLCommand = new()
            {
                Connection = MyDataSource,
                CommandType = CommandType.StoredProcedure,
                CommandText = "DeleteStudent"
            };

            SqlParameter SQLParameter = new()
            {
                ParameterName = "@StudentID",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "57122"
            };
            SQLCommand.Parameters.Add(SQLParameter);

            SQLCommand.ExecuteNonQuery();

            MyDataSource.Close();
            Console.WriteLine("Success - DeleteStudent");
        }

        static void GetStudent()
        {
            Console.WriteLine("GetStudent");
            SqlConnection MyDataSource = new();
            MyDataSource.ConnectionString = @"Persist Security Info=False;Integrated Security = True;Database=ptrninkov1;server=(LocalDB)\MSSQLLocalDB;";
            MyDataSource.Open();

            SqlCommand SQLCommand = new()
            {
                Connection = MyDataSource,
                CommandType = CommandType.StoredProcedure,
                CommandText = "GetStudent"
            };

            SqlParameter SQLParameter = new()
            {
                ParameterName = "@StudentID",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "57122"
            };
            SQLCommand.Parameters.Add(SQLParameter);

            SqlDataReader DataReader = SQLCommand.ExecuteReader();

            if (DataReader.HasRows)
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Columns");
                Console.WriteLine("---------------");

                for (int i = 0; i < DataReader.FieldCount; i++)
                {
                    Console.WriteLine(DataReader.GetName(i));
                }

                Console.WriteLine("---------------");
                Console.WriteLine("Rows");
                Console.WriteLine("---------------");

                while (DataReader.Read())
                {
                    for (int i = 0; i < DataReader.FieldCount; i++)
                    {
                        Console.WriteLine(DataReader[i].ToString());
                    }
                    Console.WriteLine("---");
                }
            }

            DataReader.Close();
            MyDataSource.Close();
            Console.WriteLine("Success - GetStudent");
        }

        static void GetStudentsByProgram()
        {
            Console.WriteLine("GetStudentsByProgram");
            SqlConnection MyDataSource = new();
            MyDataSource.ConnectionString = @"Persist Security Info=False;Integrated Security=True;Database=ptrninkov1;server=(LocalDB)\MSSQLLocalDB;";

            MyDataSource.Open();

            SqlCommand SQLCommand = new()
            {
                Connection = MyDataSource,
                CommandType = CommandType.StoredProcedure,
                CommandText = "GetStudentsByProgram"
            };

            SqlParameter SQLParameter = new()
            {
                ParameterName = "@ProgramCode",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "BAIST"
            };

            SQLCommand.Parameters.Add(SQLParameter);

            SqlDataReader DataReader = SQLCommand.ExecuteReader();

            if (DataReader.HasRows)
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Columns");
                Console.WriteLine("---------------");

                for (int i = 0; i < DataReader.FieldCount; i++)
                {
                    Console.WriteLine(DataReader.GetName(i));
                }

                Console.WriteLine("---------------");
                Console.WriteLine("Rows");
                Console.WriteLine("---------------");

                while (DataReader.Read())
                {
                    for (int i = 0; i < DataReader.FieldCount; i++)
                    {
                        Console.WriteLine(DataReader[i].ToString());
                    }
                    Console.WriteLine("---");
                }
            }
            DataReader.Close();
            MyDataSource.Close();
            Console.WriteLine("Success - GetStudentsByProgram");
        }

        /*
         * ------------------------------------BAIST SERVER------------------------------------
         */

        static void GetCustomersByCountry()
        {
            Console.WriteLine("GetCustomersByCountry");

            SqlConnection MyDataSource = new();
            MyDataSource.ConnectionString = @"Persist Security Info=False;Database=Northwind;User ID=ptrninkov1;Password=rageking1A;server=dev1.baist.ca";
            MyDataSource.Open();

            SqlCommand SQLCommand = new()
            {
                Connection = MyDataSource,
                CommandType = CommandType.StoredProcedure,
                CommandText = "ptrninkov1.GetCustomersByCountry"
            };

            SqlParameter SQLParameter = new()
            {
                ParameterName = "@Country",
                SqlDbType = SqlDbType.NVarChar,
                Direction = ParameterDirection.Input,
                Value = "Germany"
            };
            SQLCommand.Parameters.Add(SQLParameter);

            SqlDataReader DataReader = SQLCommand.ExecuteReader();

            if (DataReader.HasRows)
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Columns");
                Console.WriteLine("---------------");

                for (int i = 0; i < DataReader.FieldCount; i++)
                {
                    Console.WriteLine(DataReader.GetName(i));
                }

                Console.WriteLine("---------------");
                Console.WriteLine("Rows");
                Console.WriteLine("---------------");

                while (DataReader.Read())
                {
                    for (int i = 0; i < DataReader.FieldCount; i++)
                    {
                        Console.WriteLine(DataReader[i].ToString());
                    }
                    Console.WriteLine("---");
                }
            }

            DataReader.Close();
            MyDataSource.Close();
            Console.WriteLine("Success - GetCustomersByCountry");
        }

        static void GetCategory()
        {
            Console.WriteLine("GetCategory");
            SqlConnection MyDataSource = new();
            MyDataSource.ConnectionString = @"Persist Security Info=False;Database=Northwind;User ID=ptrninkov1;Password=rageking1A;server=dev1.baist.ca";

            MyDataSource.Open();

            SqlCommand SQLCommand = new()
            {
                Connection = MyDataSource,
                CommandType = CommandType.StoredProcedure,
                CommandText = "ptrninkov1.GetCategory"
            };

            SqlParameter SQLParameter = new()
            {
                ParameterName = "CategoryID",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = 1
            };
            SQLCommand.Parameters.Add(SQLParameter);

            SqlDataReader DataReader = SQLCommand.ExecuteReader();

            if (DataReader.HasRows)
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Columns");
                Console.WriteLine("---------------");

                for (int i = 0; i < DataReader.FieldCount; i++)
                {
                    Console.WriteLine(DataReader.GetName(i));
                }

                Console.WriteLine("---------------");
                Console.WriteLine("Rows");
                Console.WriteLine("---------------");

                while (DataReader.Read())
                {
                    for (int i = 0; i < DataReader.FieldCount; i++)
                    {
                        Console.WriteLine(DataReader[i].ToString());
                    }
                    Console.WriteLine("---");
                }
            }

            MyDataSource.Close();
            Console.WriteLine("Success - GetCategory");
        }

        static void GetProductsByCategory()
        {
            Console.WriteLine("GetProductsByCategory");
            SqlConnection MyDataSource = new();
            MyDataSource.ConnectionString = @"Persist Security Info=False;Database=Northwind;User ID=ptrninkov1;Password=rageking1A;server=dev1.baist.ca";
            MyDataSource.Open();

            SqlCommand SQLCommand = new()
            {
                Connection = MyDataSource,
                CommandType = CommandType.StoredProcedure,
                CommandText = "ptrninkov1.GetProductsByCategory"
            };

            SqlParameter SQLParameter = new()
            {
                ParameterName = "@CategoryID",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = 1
            };
            SQLCommand.Parameters.Add(SQLParameter);

            SqlDataReader DataReader = SQLCommand.ExecuteReader();

            if (DataReader.HasRows)
            {
                Console.WriteLine("---------------");
                Console.WriteLine("Columns");
                Console.WriteLine("---------------");

                for (int i = 0; i < DataReader.FieldCount; i++)
                {
                    Console.WriteLine(DataReader.GetName(i));
                }

                Console.WriteLine("---------------");
                Console.WriteLine("Rows");
                Console.WriteLine("---------------");

                while (DataReader.Read())
                {
                    for (int i = 0; i < DataReader.FieldCount; i++)
                    {
                        Console.WriteLine(DataReader[i].ToString());
                    }
                    Console.WriteLine("---");
                }
            }

            DataReader.Close();
            MyDataSource.Close();
            Console.WriteLine("Success - GetProductsByCategory");
        }
        static void Main(string[] args)
        {
            //AddProgram(); // Demonstration | Demonstration Description
            //GetProgram(); // Demonstration
            //AddStudent(); // Bill Clinton ID=57122 INTO BAIST
            //UpdateStudent(); // Cill Blinton INTO Demonstration
            //DeleteStudent();
            //GetStudent(); // 123654 TEST TEST TESTING
            //GetStudentsByProgram(); // BAIST Students

            //---------------------------
            //GetCustomersByCountry();
            //GetCategory();
            //GetProductsByCategory();
        }
    }
}
