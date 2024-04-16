namespace Interfaces.FinalExample;

public abstract class Test              //создаем абстр класс, тк нам не нужно создавать экземляр этой сущности
{
    public string Name { get; set; }         //кажд тест должен содержать (авто)свойство
    public string Description { get; set; }  //и еще одно

    public abstract void Run();              //кажд тест должен иметь метод Run, который запускает тест,но как он будет работать мы пока не знаем (реализовыва его будет кажд дочерний класс, кот. решит воспользоваться этим шаблоном)
}