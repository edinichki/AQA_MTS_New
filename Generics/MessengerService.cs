namespace Generics;

public class MessengerService<T, P>           //определяем что и кому мы хотим отправить
    where T : Message
    where P : SimplePerson
{
    public void SendMessage(P sender, P receiver, T message)
    {
        Console.WriteLine($"Отправитель: {sender.Name}");
        Console.WriteLine($"Получатель: {receiver.Name}");
        Console.WriteLine($"Сообщение: {message.Text}");
    }
}