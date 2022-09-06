namespace SharpDesign.StructuralPatterns.Facade.Implementation;

public class Gpu
{
    // ReSharper disable once MemberCanBeMadeStatic.Global
    public void GetGpu(string gpuModel)
    {
        Console.WriteLine($"GPU : {gpuModel} has been built for you.");
    }
}