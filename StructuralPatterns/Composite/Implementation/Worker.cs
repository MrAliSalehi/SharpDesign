using System.Text.Json;

namespace SharpDesign.StructuralPatterns.Composite.Implementation;

public class Worker: IEmployee
{

    public string Name { get; set; }
    public string Department { get; set; }
    public string Role { get; init; }
    public Worker(string name, string department, string role)
    {
        Name = name;
        Department = department;
        Role = role;
    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"{nameof(Worker)}:{JsonSerializer.Serialize(this)}");
    }
}