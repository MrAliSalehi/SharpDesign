namespace SharpDesign.StructuralPatterns.Bridge.Implementation;

public class ProfessionalDoctor : IDoctorType
{
    public void PrintDoctorDetails(string doctorName)
    {
        Console.WriteLine($"{nameof(ProfessionalDoctor)} called {doctorName} Reserved for you.");
    }
}