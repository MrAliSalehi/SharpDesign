namespace SharpDesign.StructuralPatterns.Composite.Implementation;

public class CompositeObject : IEmployee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public string Role { get; init; }

    private readonly List<IEmployee> _employees = new();

    public CompositeObject(string name, string department, string role)
    {
        Name = name;
        Department = department;
        Role = role;
    }

    public void Add(IEmployee employee)
    {
        _employees.Add(employee);
    }

    public void Remove(IEmployee employee)
    {
        _employees.Remove(employee);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"The Head of The {Department}: {Name}-{Role}.");

        _employees.ForEach(employee => employee.PrintInfo());
    }
}