namespace Interfaces;

public class StaticExample
{
    public static int StaticVariable = 0;              //статическая переменная принадлежит классу (для всех переменных), а не экземпляру объекта
    public int InstanceVar;

    public StaticExample()
    {
        StaticVariable++;                              //тут в конструкторе увеличиваем на единицу статическую переменную
        InstanceVar = StaticVariable;                  //присваеваем InstanceVar значение этой стат.переменной 
    }

    public static void Print()
    {
        Console.WriteLine($"Static Variable: {StaticVariable}");
    }
}