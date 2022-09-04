namespace SharpDesign.StructuralPatterns.Decorator.Implementation;

public class BackgroundColorDecorator : BaseDecorator
{
    public BackgroundColorDecorator(AbsComponent component) : base(component.Name, component)
    {
    }

    public override void BuildComponent()
    {
        base.BuildComponent();
        //some task here...
        Thread.Sleep(TimeSpan.FromSeconds(.1));
        Console.WriteLine($"Some Dark Background Color has been added to {Name}.");
    }
}