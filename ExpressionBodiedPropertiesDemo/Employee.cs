namespace ExpressionBodiedPropertiesDemo;

internal class Employee
{
#pragma warning disable IDE0052 // Remove unread private members
    private readonly int _employeeId;
#pragma warning restore IDE0052 // Remove unread private members

    public string Name { get; set; } = string.Empty;

    public string Company { get; } = "XYZ Ltd.";


    public Employee(int employeeId) => _employeeId = employeeId;
}
