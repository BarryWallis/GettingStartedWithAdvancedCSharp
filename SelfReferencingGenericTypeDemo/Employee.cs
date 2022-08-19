namespace SelfReferencingGenericTypeDemo;

internal record Employee(string DepartmentName, int EmployeeId) : IIdenticalEmployee<Employee>
{
    public string CheckEqualityWith(Employee? obj)
        => obj is null
           ? "Cannot compare to a null object"
           : DepartmentName == obj.DepartmentName && EmployeeId == obj.EmployeeId
             ? "Same employee."
             : "Different employees.";
}
