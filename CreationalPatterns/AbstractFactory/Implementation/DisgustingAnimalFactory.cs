namespace SharpDesign.CreationalPatterns.AbstractFactory.Implementation;

public class DisgustingAnimalFactory : IAnimalFactory
{
    /// <inheritdoc />
    public IDog GetDog()
    {
        return new DisgustingDogs();
    }

    /// <inheritdoc />
    public ICat GetCat()
    {
        return new DisgustingCats();
    }
}