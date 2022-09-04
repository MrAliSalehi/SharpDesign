namespace SharpDesign.StructuralPatterns.Decorator.Implementation;

public abstract class AbsComponent
{
    public string Name { get; }
    protected AbsComponent(string name)
    {
        Name = name;
    }
    
    public abstract void BuildComponent();
}