namespace SharpDesign.StructuralPatterns.Facade.Implementation;

public class Cpu
{
    // ReSharper disable once MemberCanBeMadeStatic.Global
    public void GetCpu(string cpuModel)
    {
        Console.WriteLine($"CPU:{cpuModel} has been built for you.");
    }
}