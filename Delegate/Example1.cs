namespace Delegate;

public class Example1
{
    private delegate void NoParameters();   //NoParameters это тип, ниже создаем переменную noParameters1 с этим типом

    public void Run()
    {
        NoParameters noParameters1 = new NoParameters(ShowMessage);  //присваиваем типу ссылку на тот метод, который впоследствиии я хочу выполнять (в скобках)
        NoParameters noParameters2 = new(ShowMessage);
        NoParameters noParameters3 = ShowMessage;   //самая сокращенная запись - просто присваиваем значение 

        noParameters1(); //переменная используется как вызов метода
        noParameters2();
        noParameters3();
    }

    private void ShowMessage()
    {
        Console.WriteLine("Have fun!!!");
    }
}
