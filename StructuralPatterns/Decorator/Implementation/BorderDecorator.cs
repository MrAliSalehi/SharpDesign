namespace SharpDesign.StructuralPatterns.Decorator.Implementation;

public class BorderDecorator : BaseDecorator
{
    public BorderDecorator(AbsComponent component) : base(component.Name, component)
    {
        
    }

    public override void BuildComponent()
    {
        
        
        base.BuildComponent();
        //some task here...
        Thread.Sleep(TimeSpan.FromSeconds(.1));
        Console.WriteLine($"Border has been added to {Name}.");
    }
}