namespace Properties;

public class Person
{
    private string name;
    private int age;
    private string surname;
    private string address;

    public Person()                       //конструктор
    {
        surname = "Trostyanko";
        Address = "Gdansk";
    }

    // Стандартный вариант работы с блоком данных
    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    // В C# есть Свойство для доступа к полю name
    public string Name                                        //это свойство, тк у него нет () и есть два/один из блока - get и set:
    {
        get
        {
            return name;
        }
        set
        {
            // Логика проверки при установке значения
            if (!string.IsNullOrEmpty(value))
            {
                name = value;                            //value - единичный параметр, который передается для свойства Name
            }
        }
    }

    // свойство только для записи
    public int Age
    {
        set { age = value; }
    }

    // свойство только для чтения
    public string Surname
    {
        get { return surname; }            //захардкоженое значение в конструкторе
    }

    // Вычисляемые свойства
    public string Fullname
    {
        get { return $"{name} {surname}"; }
    }

    // Модификаторы доступа
    public string Address
    {
        get { return address; }

        protected set { address = value; }
    }

    // Автоматические свойства
    //public string Salary { get; set; }        //может и задать, и вернуть значение
    //public int Salary { get; set; } = 12500;  //или задать значение сразу, не в конструкторе
    public int Salary { get; private set; }

    // Блок init
    // Первый способ
    public string ID { get; init; } = "XXX-712";

    // Второй способ
    //public Person(string id) => ID = id;
    // Или так
    /*
    public Person(string id)
    {
        ID = id;
    }
    */

    // Модификатор required
    /*
    public required string Passport { get; set; } // - Ошибка при вызове базового конструктора
    public Person(string passport)
    {
        Passport = passport;
    }
    */
}