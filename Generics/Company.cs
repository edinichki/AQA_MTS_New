namespace Generics;

public class Company<P>   //тут обобщение <P> взамен GenericPerson, будет инициализироваться экземпляр класса Company с определенным значением типа <P> (а это тип не основании GenericPerson)
{
    public P CEO { get; set; }

    public Company(P ceo)
    {
        CEO = ceo;
    }
}

