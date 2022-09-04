namespace SharpDesign.StructuralPatterns.Decorator.Implementation;

public class BaseDecorator : AbsComponent
{
    private readonly AbsComponent _component;
    protected BaseDecorator(string name, AbsComponent component) : base(name)
    {
        _component = component;
    }

    public override void BuildComponent()
    {
        _component.BuildComponent();
    }
}