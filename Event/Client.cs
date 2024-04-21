namespace Event;

public class Client
{
    public ClientType Type { get; set; }

    public int Discount { get; set; }               //свойство - скидка в зависимости от типа клиента

    public string Email { get; set; }
}
