namespace Classes.Models;

public class Cat
{
    public string name;
    public int age;
    public int maxFoodCount;

    public bool Feed(int foodCount)           //булин метод кормежка с параметрами кол-во корма
    {
        return foodCount >= maxFoodCount;     //возвращаем рез-т сравнения переменных между собой. то же самое терн.операция: return foodCount >= maxFoodCount ? true : false;
    }

}
