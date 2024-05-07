using NUnit.Framework.Interfaces;

namespace NUnitProject;

public class TestCaseExample
{
    [TestCase(1, 2, 3)]                   //указываем наборы данных, которые хотим проверить
    [TestCase(-1, -2, -3)]
    [TestCase(0, 0, 0)]
    public void Test1(int x, int y, int result)
    {
        Assert.That(Calc.Sum(x, y), Is.EqualTo(result));
    }

    [TestCase(1, 2, ExpectedResult = 3)]        //второй способ написать эти же тесты. покороче 
    [TestCase(-1, -2, ExpectedResult = -3)]
    [TestCase(0, 0, ExpectedResult = 0)]
    public int Test2(int x, int y)
    {
        return Calc.Sum(x, y);
    }

    public static object[] DivideCases =
    {
        new object[] { 12, 3, 4},
        new object[] { 12, 2, 6},
        new object[] { 12, 4, 3}
    };

    [TestCaseSource(nameof(DivideCases))]               //ждет на вход параметры из массива DivideCases 
    public void DivideTest(int x, int y, int result)
    {
        Assert.That(x / y, Is.EqualTo(result));
    }

    [TestCaseSource(typeof(TestData), nameof(DivideCases))]
    public void ExternalDivideTest(int x, int y, int result)     //ссылка на внешний набор данных
    {
        Assert.That(x / y, Is.EqualTo(result));
    }
}
