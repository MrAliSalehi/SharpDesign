namespace SharpDesign.CreationalPatterns.FactoryMethod.Implementation;

internal class Dog : IAnimal
{
    public void About()
    {
        Console.WriteLine("This is Dog");
    }
}