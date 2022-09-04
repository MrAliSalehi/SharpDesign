using System.Text.Json;

namespace SharpDesign.StructuralPatterns.Composite.Implementation;

public class Employee: IEmployee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public string Role { get; init; }
    
    public Employee(string name, string department, string role)
    {
        Name = name;
        Department = department;
        Role = role;
    }

    
    public void PrintInfo()
    {
        //im just too lazy 
        Console.WriteLine($"{nameof(Employee)}:{JsonSerializer.Serialize(this)}");
    }
}