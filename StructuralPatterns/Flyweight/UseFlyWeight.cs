using SharpDesign.StructuralPatterns.Flyweight.Implementation;

namespace SharpDesign.StructuralPatterns.Flyweight;

public static class UseFlyWeight
{
    public static void FlyweightInAction()
    {
        var additionOperation = new AdditionOperation();
        
        //without cache ... 
        var noCacheResult1 = additionOperation.AddWithoutCache(123, 69);
        var noCacheResult2 = additionOperation.AddWithoutCache(123, 69);
        
        var noCacheResult3 = additionOperation.AddWithoutCache(54, 4);
        var noCacheResult4 = additionOperation.AddWithoutCache(54, 4);

        Console.WriteLine($"total operations Without cache : {AdditionResult.TotalOperations}."); //4

        AdditionResult.TotalOperations = 0;
        
        //with cache

        var cachedResult1 = additionOperation.AddWithCache(65, 95);
        var cachedResult2 = additionOperation.AddWithCache(65, 95);

        var cachedResult3 = additionOperation.AddWithCache(689, 155);
        var cachedResult4 = additionOperation.AddWithCache(689, 155);

        Console.WriteLine($"total operations with cache : {AdditionResult.TotalOperations}."); //2


    }
}