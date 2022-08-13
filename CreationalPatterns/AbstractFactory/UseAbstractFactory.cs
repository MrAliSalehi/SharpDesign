using SharpDesign.CreationalPatterns.AbstractFactory.Implementation;

namespace SharpDesign.CreationalPatterns.AbstractFactory;

public class UseAbstractFactory
{
    public void AbstractFactoryInAction()
    {
        //explicit types just so you can see whats going on...
        var charmingFactory = FactoryProvider.GetAnimalFactory<CharmingAnimalFactory>();
        //or
        var disgustingFactory = FactoryProvider.GetAnimalFactory("disgusting");

        //charming dog
        IDog myCharmingDog = charmingFactory.GetDog();
        myCharmingDog.AboutDog();


        //charming cat (tip: i hate cats)
        ICat stupidCat = charmingFactory.GetCat();
        stupidCat.AboutCat();


        //disgusting animals :
        IDog myDisgustingDog = disgustingFactory.GetDog();
        myDisgustingDog.AboutDog();


        //disgusting cat 
        ICat disgustingCat = disgustingFactory.GetCat();
        disgustingCat.AboutCat();

    }
}