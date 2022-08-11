namespace SharpDesign.CreationalPatterns.FactoryMethod.Implementation;

public class DogFactory : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new Dog();
    }
}