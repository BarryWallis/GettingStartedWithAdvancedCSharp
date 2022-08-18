namespace UsingConstraintsInGenerics;

internal class EmployeeStorehouse<T> where T : IEmployee
{
    private readonly List<IEmployee> _employees = new();

    public void Add(IEmployee employee) => _employees.Add(employee);

    public void Display()
    {
        Console.WriteLine("The storehouse: ");
        foreach (IEmployee employee in _employees)
        {
            Console.WriteLine(employee.Position());
        }
    }
}
