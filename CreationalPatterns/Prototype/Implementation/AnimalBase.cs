namespace SharpDesign.CreationalPatterns.Prototype.Implementation;

public abstract class AnimalBase : ICloneable<AnimalBase>
{
    public string Sound = "MOW";
    public string Name { get; private set; } = "animal";
    public abstract AnimalBase Clone();

    protected void SetName(string name)
    {
        Name = $"ANIMAL:{name}";
    }
}

internal interface ICloneable<out T> where T : class
{
    public T Clone();
}