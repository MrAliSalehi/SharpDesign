namespace SharpDesign.CreationalPatterns.FactoryMethod.Implementation;

public class TigerFactory : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new Tiger();
    }
}