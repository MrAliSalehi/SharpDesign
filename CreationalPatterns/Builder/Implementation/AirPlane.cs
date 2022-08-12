namespace SharpDesign.CreationalPatterns.Builder.Implementation;

public class AirPlane : IBuilder
{
    private readonly string _name;
    private readonly Product _product;
    public AirPlane(string name)
    {
        _product = new Product();
        _name = name;
    }
    public void BuildBody()
    {
        _product.AddParts("AirPlane Body has been built");
    }

    /// <inheritdoc />
    public void CreateWheels()
    {
        _product.AddParts("airplane wheels added");
    }

    /// <inheritdoc />
    public void UseHeadLights()
    {
        //maybe airplane don't have headlights so i don't add it
        //sweet, isn't it?
    }

    /// <inheritdoc />
    public void CreateDoors()
    {
        _product.AddParts("Airplane doors added");
    }

    public Product GetVehicle()
    {
        return _product;
    }
}