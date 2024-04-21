namespace Event;

public class ClientEvent
{
    public delegate void Notificate(string email);

    public event Notificate Notified;    //объявляем событие Notified, которое произойдет после каких-то действий

    public void NotifyClients(IEnumerable<Client> clients)   //коллекция клиентов, которых будем уведомлять
    {
        foreach (Client client in clients)
        {
            // какой-то код бизнес логики - например подготовка сообщения
            string emailMsg = client.Email + "   Congratulation!!!";

            // Оповещение
            Notified(emailMsg);
        }
    }
}
