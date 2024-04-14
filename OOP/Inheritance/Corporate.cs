namespace Abstraction;

public class Corporate : Client           //создаем класс Corporate который будет наследоваться от класса Client
{
    public string INN;                    //создаем уникальные свойства для нашего дочернего класса Corporate
    public string UNP;

    public Corporate(int id) : base(id)
    {
    }
}