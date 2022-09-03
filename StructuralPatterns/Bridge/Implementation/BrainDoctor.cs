namespace SharpDesign.StructuralPatterns.Bridge.Implementation;

public class BrainDoctor: HospitalDoctors
{
    public BrainDoctor(IDoctorType doctorType,string doctorName)
    {
        this.DoctorName = doctorName;
        this.DoctorType = doctorType;
    }

    public void NeedMoreMoney()
    {
        Console.WriteLine("Got More Money One This Doc..");
    }
    public override void Details()
    {
        DoctorType.PrintDoctorDetails(DoctorName);
    }
}