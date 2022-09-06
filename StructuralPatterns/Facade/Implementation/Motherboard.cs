namespace SharpDesign.StructuralPatterns.Facade.Implementation;

public class Motherboard
{
    // ReSharper disable once MemberCanBeMadeStatic.Global
    public void GetMotherboard(string motherboardModel)
    {
        Console.WriteLine($"Motherboard :{motherboardModel} has been built for you.");
    }
}