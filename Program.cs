
using SharpDesign.CreationalPatterns.FactoryMethod;

namespace SharpDesign
{
    internal static class Program
    {
        private static void Main()
        {

            var prototype = new UseFactoryMethod();

            prototype.FactoryMethodInAction();

            Console.ReadKey();
        }
    }
}