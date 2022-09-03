namespace SharpDesign.StructuralPatterns.Bridge.Implementation;

public class NormalDoctor : IDoctorType
{
    public void PrintDoctorDetails(string doctorName)
    {
        Console.WriteLine($"{nameof(NormalDoctor)} called {doctorName} Reserved for you.");
    }
}