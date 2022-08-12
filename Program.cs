
using SharpDesign.CreationalPatterns.Builder;

namespace SharpDesign
{
    internal static class Program
    {
        private static void Main()
        {

            var prototype = new UseBuilder();

            prototype.BuilderInAction();

            Console.ReadKey();
        }
    }
}