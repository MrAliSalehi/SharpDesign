namespace SharpDesign.StructuralPatterns.Composite.Implementation;

public interface IEmployee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public string Role { get; init; }
    void PrintInfo();
}