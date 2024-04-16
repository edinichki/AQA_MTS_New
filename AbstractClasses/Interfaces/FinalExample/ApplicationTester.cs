namespace Interfaces.FinalExample;

public class ApplicationTester : ITestable                    //это раннер, кот будет запускать наши тесты
{
    private Test[] _tests = new Test[10];                     //массив тестов
    private int _index = 0;                                   //индекс теста

    public void AddTest(Test test)                            //добавление теста с опред индексом
    {
        _tests[_index++] = test;
    }

    public void RunTests()                                    //запуск тестов по очереди
    {
        for (int i = 0; i < _index; i++)
        {
            _tests[i].Run();
        }
    }
}