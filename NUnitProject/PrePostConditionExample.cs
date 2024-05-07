namespace NUnitProject;

public class PrePostConditionExample
{
    protected int i = 0;

    [OneTimeSetUp]                         //атрибут указывает на то, что это самый высокоуровневый метод, выполняется 1 раз перед всеми тестами
    public void OnetimeSetup()             //void ок для прекондишн методов 
    {
        Console.WriteLine($"{this}: OneTimeSetUp... {++i}");     //проставили номера тестов по ходу выполнения
    }

    [SetUp]                               //выполнение перед каждым тестом, н-р открытие браузера
    public void Setup()
    {
        Console.WriteLine($"{this}: SetUp... {++i}");
    }

    [Test]
    public void Test1()
    {
        Console.WriteLine($"{this}: Test1... {++i}");
    }

    [Test]
    public void Test2()
    {
        Console.WriteLine($"{this}: Test2... {++i}");
    }

    [Test]
    public void Test11()
    {
        Console.WriteLine($"{this}: Test2... {++i}");
    }

    [TearDown]
    public void TearDown()
    {
        Console.WriteLine($"{this}: TearDown... {++i}");
    }

    [OneTimeTearDown]                      //атрибут после завершения всех тестов              
    public void FinishTests()
    {
        Console.WriteLine($"{this}: OneTimeTearDown... {++i}");
    }
}
