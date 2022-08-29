using System.Data;
using System.Diagnostics;

using MySql.Data.MySqlClient;

internal class Program
{
    private static string _connectMe = string.Empty;
    private static string _sqlCommand = string.Empty;
    private static MySqlDataAdapter? _mySqlDataAdapter = null;
    private static DataSet? _localDataSet = null;
    private static MySqlCommandBuilder? _mySqlCommandBuilder = null;

    private static void Main()
    {
        Console.WriteLine("*** Connecting and Retrieving Details From a MySql Database Using a Disconnected " +
            "Architecture ***");

        try
        {
            DataTable localDataTable = CreateLocalTable();
            DisplayRecordsFromEmployeeTable(localDataTable);

            InsertRecordIntoEmployeeTable(localDataTable);
            Console.WriteLine("-After inserting a record into the Employee table...");
            DisplayRecordsFromEmployeeTable(localDataTable);

            DeleteRecordFromEmployeeTable();
            Console.WriteLine("-After deleting a record from the Employee table...");
            DisplayRecordsFromEmployeeTable(localDataTable);
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Caught exception: {exception.Message}");
        }
    }

    private static void DeleteRecordFromEmployeeTable()
    {
        const int empIdToDelete = 4;

        try
        {
            Console.WriteLine($"Deleting record for EmpId {empIdToDelete}");
            Debug.Assert(_localDataSet is not null);
            DataTable? dataTable = _localDataSet.Tables["Employee"];
            Debug.Assert(dataTable is not null);
            DataRow? deleteRow = dataTable.Rows.Find(empIdToDelete);
            Debug.Assert(deleteRow is not null);
            deleteRow.Delete();
            Console.WriteLine($"Deleted record from local buffer where EmpId was {empIdToDelete}");

            Debug.Assert(_mySqlDataAdapter is not null);
            _mySqlCommandBuilder = new(_mySqlDataAdapter);

            Console.WriteLine("Syncing with remote table...");
            Debug.Assert(_localDataSet is not null);
            _ = _mySqlDataAdapter.Update(_localDataSet, "Employee");
            Console.WriteLine("...Updated the remote table.");
            Console.WriteLine();
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Could not delete Employee record {empIdToDelete}: {exception.Message}");
        }
    }

    private static void InsertRecordIntoEmployeeTable(DataTable localDataTable)
    {
        try
        {
            DataRow currentRow = localDataTable.NewRow();
            currentRow["EmpId"] = 4;
            currentRow["Name"] = "Jack";
            currentRow["Age"] = 40;
            currentRow["Salary"] = 2500.75;
            localDataTable.Rows.Add(currentRow);
            Console.WriteLine("Added a record to the local buffer.");

            int numberOfRecords = localDataTable.Rows.Count;
            Console.WriteLine($"Local table has {numberOfRecords} rows.");

            _mySqlCommandBuilder = new(_mySqlDataAdapter);
            Debug.Assert(_mySqlDataAdapter is not null);
            Console.WriteLine("Syncing with remote table...");

            Debug.Assert(_localDataSet is not null);
            _ = _mySqlDataAdapter.Update(_localDataSet, "Employee");
            Console.WriteLine("...Updated remote table.");
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Could not insert record: {exception.Message}");
        }
    }

    private static void DisplayRecordsFromEmployeeTable(DataTable localDataTable)
    {
        try
        {
            int numberOfRecords = localDataTable.Rows.Count;
            Console.WriteLine($"EmployeeId\tEmployeeName\tAge\tSalary");
            Console.WriteLine(new string('_', 47));
            for (int currentRow = 0; currentRow < numberOfRecords; currentRow++)
            {
                Console.WriteLine($"" +
                    $"{localDataTable.Rows[currentRow]["EmpId"]}\t\t" +
                    $"{localDataTable.Rows[currentRow]["Name"]}\t\t" +
                    $"{localDataTable.Rows[currentRow]["Age"]}\t " +
                    $"{localDataTable.Rows[currentRow]["Salary"]}");
            }
            Console.WriteLine();
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Cannot display records: {exception.Message}");
        }
    }

    private static DataTable CreateLocalTable()
    {
        _connectMe = "datasource=localhost;port=3306;database=test;username=root;password=american";
        _sqlCommand = "select * from Employee";
        _mySqlDataAdapter = new(_sqlCommand, _connectMe);
        _localDataSet = new("LocalDataSet");
        _ = _mySqlDataAdapter.FillSchema(_localDataSet, SchemaType.Source, "Employee");
        _ = _mySqlDataAdapter.Fill(_localDataSet, "Employee");
        DataTable? dataTable = _localDataSet.Tables["Employee"];
        Debug.Assert(dataTable is not null);
        int numberOfRecords = dataTable.Rows.Count;
        Console.WriteLine($"Create a local data table with {numberOfRecords} rows");
        return dataTable;
    }
}