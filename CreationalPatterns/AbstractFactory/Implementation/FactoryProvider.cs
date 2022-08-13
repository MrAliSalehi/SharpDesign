namespace SharpDesign.CreationalPatterns.AbstractFactory.Implementation;

internal static class FactoryProvider
{
    public static IAnimalFactory GetAnimalFactory<T>() where T : IAnimalFactory, new()
    {

        return typeof(T) switch
        {
            { } type when (type == typeof(DisgustingAnimalFactory)) => new T(),
            { } type when (type == typeof(CharmingAnimalFactory)) => new T(),
            _ => throw new ArgumentException("")
        };

    }

    public static IAnimalFactory GetAnimalFactory(string type)
    {
        return type switch
        {
            "disgusting" => new DisgustingAnimalFactory(),
            "charming" => new CharmingAnimalFactory(),
            _ => throw new ArgumentException("Invalid Argument")
        };
    }
}