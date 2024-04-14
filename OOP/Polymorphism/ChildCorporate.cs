namespace Polymorphism;

public class ChildCorporate : Corporate
{
    public ChildCorporate(int id) : base(id)
    {
    }

    /*
    public override void SendNotification() - Ошибка переопределения
    {
        Console.WriteLine("Дорогие сотрудники компании....");
    }
    */

}