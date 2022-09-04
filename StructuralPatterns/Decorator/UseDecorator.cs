using SharpDesign.StructuralPatterns.Decorator.Implementation;

namespace SharpDesign.StructuralPatterns.Decorator;

public static class UserDecorator
{
    public static void DecoratorInAction()
    {
        var comp = new Button("btn1");

        //comp.BuildComponent(); // this is just gonna build a normal button...

        var borderDec = new BorderDecorator(comp);
        borderDec.BuildComponent();

        var backgroundColor = new BackgroundColorDecorator(comp);
        backgroundColor.BuildComponent();
    }
}