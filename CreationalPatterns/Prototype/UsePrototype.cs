using SharpDesign.CreationalPatterns.Prototype.Implementation;

namespace SharpDesign.CreationalPatterns.Prototype;

internal class UsePrototype
{
    public void PrototypeInAction()
    {
        AnimalBase dog = new Dog("dog1");
        AnimalBase cat = new Cat("cat1");


        //can be dog
        AnimalBase animalBase = dog.Clone();

        Console.WriteLine($"{animalBase.Name} ,Sound : {animalBase.Sound}");

        //can be cat
        animalBase = cat.Clone();

        Console.WriteLine($"{animalBase.Name} ,Sound : {animalBase.Sound}");



    }
}