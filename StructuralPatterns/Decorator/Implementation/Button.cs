namespace SharpDesign.StructuralPatterns.Decorator.Implementation;

public class Button : AbsComponent
{
    public Button(string name) : base(name)
    {
    }

    public override void BuildComponent()
    {
        Console.WriteLine($"{nameof(Button)} named {Name} has been built.");
    }
}