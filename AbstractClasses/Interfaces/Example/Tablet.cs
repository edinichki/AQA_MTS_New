namespace Interfaces.Example;

public class Tablet : IDisplayable            //так реализовываем интерфейс, ниже обязательно имплементируем метод DisplayInformation
{
    public int SerialNumber;

    public void DisplayInformation(string information)
    {
        // Реализация отображения на экране планшета
        Console.WriteLine($"Tablet Display: {information}");
    }

    public void DrawBorders()
    {
        Console.WriteLine("Tablet: Рисуем границы");
    }
}