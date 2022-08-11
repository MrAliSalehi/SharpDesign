namespace SharpDesign.CreationalPatterns.Prototype.Implementation;

internal class Cat : AnimalBase
{
    public Cat(string catName)
    {
        SetName(catName);
        Sound = "MEEEEW";
    }

    public override AnimalBase Clone()
    {
        //this is shallow copy!
        return MemberwiseClone() as Cat ?? new Cat("default");
    }
}