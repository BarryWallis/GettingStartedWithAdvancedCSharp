namespace UsingConstraintsInGenerics;

internal record Employee(string Name, int YearsOfExperience) : IEmployee
{
    public string Position()
    {
        string designation = YearsOfExperience switch
        {
            int n when n <= 1 => "Fresher",
            int n when n is > 1 and <= 5 => "Intermediate",
            _ => "Expert",
        };
        return designation;
    }
}
