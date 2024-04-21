namespace Delegate;

public class Example3
{
    public delegate void Notification();

    public void Run()
    {
        Notification noPrm = ShowMessage1;

        noPrm = noPrm + ShowMessage2;           //уже существующему параметру делегата присваиваем ссылку на новый метод
        noPrm += ShowMessage1;
        noPrm += ShowMessage2;

        noPrm.Invoke();

        noPrm -= ShowMessage1;       //кроме добавления, можно еще удалять методы
        noPrm -= ShowMessage1;
        noPrm -= ShowMessage2;
        noPrm -= ShowMessage2;

        noPrm.Invoke();   //Invoke() более унифицированный метод вызова делегатов
    }

    private void ShowMessage1() => Console.WriteLine("Have fun!!!");

    private void ShowMessage2() => Console.WriteLine("See you!!!");
}
