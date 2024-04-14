using Encapsulation;

namespace Abstraction;

public class ChildState : State
{
    void Test()
    {
        base.PrintProtectedInternal();               //используем  base. для того чтобы получить доступ к родительским методам и переменным
        // base.PrintProtectedPrivate(); - Ошибка
    }

}