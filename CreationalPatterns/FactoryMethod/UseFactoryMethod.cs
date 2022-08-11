using SharpDesign.CreationalPatterns.FactoryMethod.Implementation;

namespace SharpDesign.CreationalPatterns.FactoryMethod;

internal class UseFactoryMethod
{
    public void FactoryMethodInAction()
    {
        //tiger factory
        AnimalFactory tigerFactory = new TigerFactory();
        var tiger = tigerFactory.CreateAnimal();
        tiger.About();

        //dog factory
        AnimalFactory dogFactory = new DogFactory();
        var dog = dogFactory.CreateAnimal();
        dog.About();

        //it also can be IAnimal
        IAnimal anotherTiger = tigerFactory.CreateAnimal();
        anotherTiger.About();
    }
}