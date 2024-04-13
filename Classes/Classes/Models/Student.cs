namespace Classes.Models;

public class Student
{
    public string name;
    public int group;
    public int diplomMark;

    public Student()        
    {
    }

    public Student(string name)                //создаем конструктор
    {
        this.name = name;                        //this.name переменная этого класса, те public string name;
        group = 1;
        diplomMark = new Random().Next(1, 11);
    }

    public void Print()                       //блок методов
    {
        Console.Write($"Name: {name}, Group: {group}, Mark: {diplomMark}");
        Console.WriteLine();
    }
}