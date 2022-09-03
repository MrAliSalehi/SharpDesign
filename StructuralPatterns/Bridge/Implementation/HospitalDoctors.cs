namespace SharpDesign.StructuralPatterns.Bridge.Implementation;

public abstract class HospitalDoctors
{
    protected IDoctorType DoctorType { get; init; } = default!;
    protected string DoctorName { get; init; } = default!;
    public abstract void Details();
}