namespace SharpDesign.CreationalPatterns.AbstractFactory.Implementation;

internal interface IAnimalFactory
{
    IDog GetDog();
    ICat GetCat();
}