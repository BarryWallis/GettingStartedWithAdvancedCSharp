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
        Console.WriteLine("*** Exercising MySql Commands ***");

        try
        {
            ConnectToMySqlDatabase();
            DisplayRecordsFromEmployeeTable();
            InsertNewRecordsIntoEmployeeTable();
            DeleteRecordFromEmployeeTable();
            UpdateExistingRecordInEmployeeTable();
            CloseDatabaseConnection();
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Caught exception: {exception.Message}");
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
    }

    private static void ConnectToMySqlDatabase()
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

    private static void DisplayRecordsFromEmployeeTable()
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
            Console.WriteLine();
            _mySqlDataReader.Close();
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Cannot display records: {exception.Message}");
        }
    }

    private static void UpdateExistingRecordInEmployeeTable()
    {
        try
        {
            const decimal bobsOldSalary = 1500.00M;
            const decimal bobsNewSalary = 3000.75M;

            Console.WriteLine($"Updating Bob's salary to {bobsNewSalary}");
            _mySqlCommand = new($"update employee set salary={bobsNewSalary} where name='Bob';",
                                _mySqlConnection);
            int updateCount = _mySqlCommand.ExecuteNonQuery();
            Console.WriteLine($"{updateCount} record{(updateCount == 1 ? string.Empty : "s")} " +
                $"ha{(updateCount == 1 ? "s" : "ve")} been updated:");
            DisplayRecordsFromEmployeeTable();

            Console.WriteLine($"Resetting Bob's salary back to {bobsOldSalary}");
            _mySqlCommand = new($"update employee set salary={bobsOldSalary} where name='Bob';",
                                _mySqlConnection);
            updateCount = _mySqlCommand.ExecuteNonQuery();
            Console.WriteLine($"{updateCount} record{(updateCount == 1 ? string.Empty : "s")} " +
                $"ha{(updateCount == 1 ? "s" : "ve")} been updated:");
            DisplayRecordsFromEmployeeTable();
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Cannot update record: {exception.Message}");
        }
    }

    private static void DeleteRecordFromEmployeeTable()
    {
        try
        {
            Console.Write("Enter the name of the employee to be deleted: ");
            string? employeeNameToDelete = Console.ReadLine();
            _mySqlCommand = new($"delete from employee where name=@NameToBeDeleted;", _mySqlConnection);
            _ = _mySqlCommand.Parameters.AddWithValue("@NameToBeDeleted", employeeNameToDelete);
            _mySqlCommand.Prepare();
            int deleteCount = _mySqlCommand.ExecuteNonQuery();
            Console.WriteLine($"{deleteCount} record{(deleteCount == 1 ? string.Empty : "s")} " +
                $"ha{(deleteCount == 1 ? "s" : "ve")} been deleted:");
            DisplayRecordsFromEmployeeTable();
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Cannot delete record: {exception.Message}");
        }
    }

    private static void InsertNewRecordsIntoEmployeeTable()
    {
        try
        {
            _mySqlCommand = new("insert into employee values(4, 'John', 27, 975);", _mySqlConnection);
            int insertCount = _mySqlCommand.ExecuteNonQuery();
            Console.WriteLine($"{insertCount} record{(insertCount == 1 ? string.Empty : "s")} " +
                $"ha{(insertCount == 1 ? "s" : "ve")}s been inserted:");
            DisplayRecordsFromEmployeeTable();
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Cannot insert record: {exception.Message}");
        }
    }
}