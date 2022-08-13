namespace SharpDesign.CreationalPatterns.AbstractFactory.Implementation;

public class CharmingAnimalFactory : IAnimalFactory
{
    public IDog GetDog()
    {
        return new CharmingDogs();
    }

    public ICat GetCat()
    {
        return new CharmingCats();
    }
}