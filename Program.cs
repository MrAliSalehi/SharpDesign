
using SharpDesign.CreationalPatterns.AbstractFactory;
using SharpDesign.StructuralPatterns.Adapter;

namespace SharpDesign
{
    internal static class Program
    {
        private static void Main()
        {

            var prototype = new UseAdapter();

            prototype.AdapterInAction();

            Console.ReadKey();
        }
    }
}