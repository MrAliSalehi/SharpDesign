using SharpDesign.CreationalPatterns.Prototype;

namespace SharpDesign
{
    internal static class Program
    {
        private static void Main()
        {

            var prototype = new UsePrototype();

            prototype.PrototypeInAction();

            Console.ReadKey();
        }
    }
}