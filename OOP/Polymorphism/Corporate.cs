using Polymorphism;

public class Corporate : Client
{
    public string INN;
    public string UNP;

    public Corporate(int id) : base(id)               //вызываем конструктор из базового класса
    {
        Console.WriteLine("Corporate Base HashCode: " + base.GetHashCode());
    }

    public override sealed void SendNotification()    //полностью переопределяем метод базового класса. sealed запрещает дальнейшее переопределение
    {
        Console.WriteLine("Дорогие сотрудники компании....");
    }

   
    /*можно так:
    public override void SendNotification()
    {
        base SendNotification();                      //вызываем саму функцию из базового класса
        Console.WriteLine("Уважаемый клиент....");    //затем уже делаем что-то своё
    }
    */
}