namespace SharpDesign.CreationalPatterns.AbstractFactory.Implementation;

public class DisgustingCats : ICat
{
    public void AboutCat()
    {
        Console.WriteLine("Im even more disgusting than dogs");
    }
}