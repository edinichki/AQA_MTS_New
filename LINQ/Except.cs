using LINQ.models;

namespace LINQ;

public class Except
{
    private TestIntSet _testIntSet = new TestIntSet();
    private TestStringSet _testStringSet = new TestStringSet();
    private TestObjectSet _testObjectSet = new TestObjectSet();

    private List<int> blackList = new() { -1, -3, 3, 6, 8, 12 };
    public List<Person> personBlackList = new List<Person>()
    {
        new Person("Michel", 23),
        new Person("Oleg", 23),
        new Person("Toma", 55),
    };

    // Основной LINQ ситаксис
    public void RunQuerySyntax()
    {
        // Query Syntax
        Console.WriteLine("Query Syntax");

        var queryResult =
            from number in _testIntSet
            where !blackList.Contains(number)      //когда наша коллекция содержит число, то его нужно добавить, а здесь наоборот - если число не содержится, то добавляем
            select number;                         //выполняется, если условие !blackList.Contains(number) = true

        PrintHelper.Print(queryResult, item => Console.WriteLine($"Int: {item}"));
    }

    public void RunMethodSyntax()
    {
        // Method Syntax
        Console.WriteLine("Method Syntax");

        var queryResult = _testIntSet.Except(blackList);

        var queryResult1 = _testObjectSet.Except(personBlackList);

        PrintHelper.Print(queryResult, item => Console.WriteLine($"Int: {item}"));
        PrintHelper.Print(queryResult1, item => Console.WriteLine($"Person: {item}"));
    }
}
