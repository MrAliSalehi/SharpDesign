namespace SharpDesign.StructuralPatterns.Flyweight.Implementation;

// ReSharper disable once MemberCanBeMadeStatic.Global
public class AdditionOperation
{
    private readonly Dictionary<(int firstNumber, int secondNumber), AdditionResult> _cachedResults = new();
    public AdditionResult AddWithoutCache(int firstNum, int secNum) => new(firstNum + secNum);

    public AdditionResult AddWithCache(int firstNumb, int secNum) =>
        _cachedResults.TryGetValue((firstNumb, secNum), out var result)
            ? result
            : _cachedResults[(firstNumb, secNum)] = new AdditionResult(firstNumb + secNum);
}

public class AdditionResult
{
    public static int TotalOperations { get; set; }

    public AdditionResult(long number)
    {
        TotalOperations++;
        Number = number;
    }
    public long Number { get; }
}