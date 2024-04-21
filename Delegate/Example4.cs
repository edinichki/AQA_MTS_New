namespace Delegate;

public class Example4
{
    private delegate void NoParameters();

    public void Run()
    {
        NoParameters noPrm = delegate
        {
            Console.WriteLine("Have fun!!!");    //анонимный метод, без сигнатуры, без параметров. для применения один раз
        };

        noPrm();    //вызываем делегат, который вызывает анонимный метод
    }
}
