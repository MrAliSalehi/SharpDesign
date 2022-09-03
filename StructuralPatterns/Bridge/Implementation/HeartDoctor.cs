namespace SharpDesign.StructuralPatterns.Bridge.Implementation;

public class HeartDoctor : HospitalDoctors
{
    public override void Details()
    {
        DoctorType.PrintDoctorDetails(DoctorName);
    }

    public HeartDoctor(IDoctorType doctorType, string doctorName)
    {
        this.DoctorName = doctorName;
        this.DoctorType = doctorType;
    }
}