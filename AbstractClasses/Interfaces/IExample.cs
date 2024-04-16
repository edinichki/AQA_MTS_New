namespace Interfaces;

public interface IExample                 //в рамках интерфейса можно создавать либо константы, либо статические переменные:
{
    // константа
    const int minSpeed = 0;     // минимальная скорость
    // статическая переменная
    static int maxSpeed = 60;   // максимальная скорость

    // метод
    void Move();                // движение

    // свойство
    string Name { get; set; }   // название
}