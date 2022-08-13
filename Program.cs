
using SharpDesign.CreationalPatterns.AbstractFactory;

namespace SharpDesign
{
    internal static class Program
    {
        private static void Main()
        {

            var prototype = new UseAbstractFactory();

            prototype.AbstractFactoryInAction();

            Console.ReadKey();
        }
    }
}