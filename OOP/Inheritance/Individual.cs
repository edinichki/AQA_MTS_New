using Abstraction;

public class Individual : Client
{
    public string Firstname;           //два доп.свойства для еще одного дочернего класса
    public string Lastname;

    public Individual(int id) : base(id)
    {
        Console.WriteLine("Клнструктор Individual");
    }
    /*
    public Individual(int id) : base(id)
    {
    }
*/
}