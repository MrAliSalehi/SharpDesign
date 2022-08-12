namespace SharpDesign.CreationalPatterns.Builder.Implementation;

public interface IBuilder
{
    void BuildBody();
    void CreateWheels();
    void UseHeadLights();
    void CreateDoors();
    Product GetVehicle();
}

