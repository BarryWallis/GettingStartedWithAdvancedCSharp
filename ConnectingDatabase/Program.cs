// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

using MySql.Data.MySqlClient;

internal class Program
{
    private static string _connectMe = string.Empty;
    private static MySqlConnection? _mySqlConnection = null;
    private static MySqlCommand? _mySqlCommand = null;
    private static MySqlDataReader? _mySqlDataReader = null;

    private static void Main()
    {
        Console.WriteLine("*** Connecting and Retrieving Details from a MySql Database Table ***");


        try
        {
            ConnectToMySqlDatabase();
            DisplayRecordsFromEmployeeTable();
            CloseDatabaseConnection();
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Caught exception {exception.Message}");
        }

        static void CloseDatabaseConnection()
        {
            try
            {
                Debug.Assert(_mySqlConnection is not null);
                _mySqlConnection.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Could not close database: {exception.Message}");
                throw;
            }
        }

        static void DisplayRecordsFromEmployeeTable()
        {
            try
            {
                string sqlQuery = "select * from Employee;";
                _mySqlCommand = new(sqlQuery, _mySqlConnection);
                _mySqlDataReader = _mySqlCommand.ExecuteReader();
                Console.WriteLine($"EmployeeId\tEmployeeName\tAge\tSalary");
                Console.WriteLine(new string('_', 47));
                while (_mySqlDataReader.Read())
                {
                    Console.WriteLine($"{_mySqlDataReader["EmpId"]}\t\t{_mySqlDataReader["Name"]}\t\t" +
                        $"{_mySqlDataReader["Age"]}\t{_mySqlDataReader["Salary"]}");
                }
                _mySqlDataReader.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Cannot display records: {exception.Message}");
            }
        }

        static void ConnectToMySqlDatabase()
        {
            try
            {
                _connectMe = "server=localhost;database=test;username=root;password=american";
                _mySqlConnection = new(_connectMe);
                _mySqlConnection.Open();
                Console.WriteLine("Connection to MySql successful!");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Could not connect to database: {exception.Message}");
            }
        }
    }
}