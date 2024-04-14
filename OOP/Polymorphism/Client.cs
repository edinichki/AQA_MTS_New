namespace Polymorphism;

public class Client
{
    public int Id;
    public string PhoneNumber;
    public string Email;

    public void Activate() { }
    public void Pause() { }
    public void Deactivate() { }

    public Client(int id)
    {
        Id = id;
    }

    public Client()
    {
    }

    public void CountBill(int hours, int rate)               //метод выставления счета
    {
        int result = hours * rate;
        Console.WriteLine("void CountBill: " + result);
    }

    public void CountBill(int hours, int rate, int debt)     //тоже метод выставления счета, но с дополненной сигнатурой = перегрузка (только для методов!!)
    {
        int result = hours * rate + debt;
        Console.WriteLine("void CountBill: " + result);
    }

    public int CountBill(int hours, int rate, int debt, int discount)
    {
        int result = hours * rate + debt - discount;
        Console.WriteLine("void CountBill: " + result);

        return result;
    }


    public virtual void SendNotification()      //virtual значит, что метод может быть переопределен в дочерних классах
    {
        Console.WriteLine("Base notification....");
    }
}