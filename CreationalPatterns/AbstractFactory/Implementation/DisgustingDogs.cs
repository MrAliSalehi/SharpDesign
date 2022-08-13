namespace SharpDesign.CreationalPatterns.AbstractFactory.Implementation;

public class DisgustingDogs : IDog
{
    public void AboutDog()
    {
        Console.WriteLine("im disgusting;sad.");
    }
}