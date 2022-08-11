namespace SharpDesign.CreationalPatterns.Prototype.Implementation;

public class Dog : AnimalBase
{
    public Dog(string dogName)
    {
        SetName(dogName);
        Sound = "WOF WOF WOF";
    }
    public override AnimalBase Clone()
    {
        //this is shallow copy!
        return MemberwiseClone() as Dog ?? new Dog("default");
    }
}