namespace Generics;

public static class Helper
{
    public static void Swap<T>(ref T x, ref T y)       //метод меняет значение двух переменных
    {
        T tmp = x;
        x = y;
        y = tmp;
        //(x, y) = (y, x);  //это новый способ замены
    }

    public static void SendMessage(Message message)
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}");
    }

    /*
    public static void SendMessage<T>(T message)
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}"); // ! Ошибка - свойство Text
    }
    */

    public static void SendMessage<T>(T message) where T : Message     //типизированный метод, ограниченный использованием типа T как только Message
    {
        Console.WriteLine($"Отправляется сообщение: {message.Text}");
    }
}
