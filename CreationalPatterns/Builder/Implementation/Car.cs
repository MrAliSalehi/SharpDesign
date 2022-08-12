namespace SharpDesign.CreationalPatterns.Builder.Implementation;


public class Car : IBuilder
{
    private readonly string _carName;
    private readonly Product _product;

    public Car(string carName)
    {
        _product = new Product();
        _carName = carName;
    }
    public void BuildBody()
    {
        _product.AddParts("body has been built");
    }

    public void CreateWheels()
    {
        _product.AddParts("Add some Wheels");
    }

    public void UseHeadLights()
    {
        _product.AddParts("Head Lights Used");
    }

    public void CreateDoors()
    {
        _product.AddParts("Doors Created");
    }

    public Product GetVehicle()
    {
        return _product;
    }
}
