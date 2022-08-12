namespace SharpDesign.CreationalPatterns.Builder.Implementation;

public class Director
{
    public void CreateProduct(IBuilder builder)
    {
        builder.BuildBody();
        builder.CreateDoors();
        builder.CreateWheels();
        builder.UseHeadLights();
    }
}