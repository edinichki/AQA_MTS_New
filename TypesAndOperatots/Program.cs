// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information



namespace TypesAndOperators
{
    static class Program
    {
        static void Main1(string[] args)
        {
            //выводит сообщение на экран
            /*
            тоже выводит сообщение на экран 
            */



            Console.WriteLine("Hello, World!");
            {
                Console.WriteLine("It's a nice day!");
            }


            /*

            int for1 = 23;
            int what_a_beautiful_day = 15;

            const int MINUTES_IN_HOUR = 60; //константа=постоянное значение. пишется заглавными. вынесено вперед перед прочими переменными

            string name;
            string Name;

            name = "Bob"; //переменной присвоено значение, его можно менять сколько угодно раз и в любой части программы где нужно

            name = "Bob";
            Console.WriteLine(name);

            name = "Bob1";
            Console.WriteLine(name);

            name = "Bob2";
            Console.WriteLine(name);

            Console.WriteLine(true);
            Console.WriteLine(false);

            Console.WriteLine(-10);
            Console.WriteLine(0);
            Console.WriteLine(10);
            Console.WriteLine(0b10011);

            Console.WriteLine(1.24);
            Console.WriteLine(1.24F); //F в конце значит число с дробной точкой

            Console.WriteLine('H'); //символьный литерал=одиночный

            //Console.WriteLine(null); //тут некорректно,тк налл используется в операциях и связан с объектами

            Console.WriteLine("It's a \t nice day!"); //а вот значок табуляции
            Console.WriteLine("It's a \n nice day!"); //перевод каретки на новую строчку
            Console.WriteLine("It's a \\ nice day!"); //чтобы поставить слэш нужно два (первый управляющий), или сделать '\'


            bool flag = true;
            flag = false;

            sbyte sb = 300;

            float a = 3.14F;
            float a1 = 3.14f;

            decimal c = 1005.5M;
            decimal c1 = 1005.5m;

            var d = 10; //неявная типизация переменных
            var d1 = 10.2F;
            var d2 = 'D';
            var d3 = "Thank's";

            int j;
            j = 20;

            var int j1 = 20; //инициализация сразу с заданным значением
            j1 = 21;

            */



        }
    }
}
            //var j1 = null; //недопустимо


/*
Console.WriteLine(); //выводит курсор на новую строку
Console.Write(); //не выводит, продолжает писать где остановились


Console.WriteLine("Добро пожаловать в C#"); 
Console.Write("Надеюсь вы "); 
Console.Write("постигнете его нюансы \n");
Console.WriteLine("И всё будет супергуд");
*/


/*
int j;
j = 20;

Console.WriteLine("J = " + j); //конкатинация

string name = "Tom";
int age = 34;
double height = 1.7;

Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height}"); //самый простой выриант вывода параметров
Console.WriteLine("Имя: {0} Возраст: {2} Рост: {1}", name, height, age); // выведет такую же строку с параметрами
*/

/*
Console.WriteLine("Ведите свое имя:");
string name = Console.ReadLine(); // ReadLine читает только строку
Console.WriteLine($"Ваше имя: {name}");

Console.WriteLine("Ведите свое имя:");
string? name = Console.ReadLine(); // string? = строка может иметь значение null
Console.WriteLine($"Ваше имя: {name}");

Console.WriteLine("Ведите свой возраст:");
string? age_str = Console.ReadLine(); 
int age = Convert.ToInt32(age_str); //конвертируем строчку в число
Console.WriteLine($"Ваш возраст: {age}");
*/

/*
double x = 10.0;
double z = x % 4;
Console.WriteLine($"Результат: {z}"); // результат 2 (остаток от целочисленного деления двух чисел)

int a = 10; //ниже операции присваивания
a += 10; //20 то есть a = a + 10
а -= 4; //16 a = a - 4 (=20-4)
a *= 2; //32 (=16*2)
a /= 8; //4 (=32/8)
*/


/*
byte a = 4; //преобразование базовых типов данных
int b = a + 70;

byte a = 4;
byte result = a + 70; // ошибка, тк 70 это intовое значение, а мы его хотим поместить в byte

byte a = 4;
byte result = (byte)(a + 70); //норм преобразование
*/

/*
int a = 10; //операции сравнения
bool c = a != 10;
Console.WriteLine($"Результат: {c}"); // false тк 10=10
*/

//промежуток,отрезок - границы входят в значение [] -- проверка граничных значений в тестировании
//интервал - границы не входят ()







/*

//Решение нашей задачи
//Подготовка данных
bool isWhiteBreadFresh = true;
ushort whiteBreadPrice = 150;
ushort butterPrice = 230;
ushort milkPrice = 170;
float milkFatPercentage = 1.2F;
ushort icecreamPrice = 350;

Console.Write("Введите начальную сумму: ");
string? sumString = Console.ReadLine();
short sum = Convert.ToInt16(sumString);

if (sum > 0)
{
    if (isWhiteBreadFresh) //первый вариант с положительным условием
    {
        if (sum >= whiteBreadPrice)
        {
            sum = (short)(sum - whiteBreadPrice); //или sum = Convert.ToInt16(sum - whiteBreadPrice)
            Console.WriteLine($"Купили свежий батон по цене {whiteBreadPrice}");
        }
        else
        {
            Console.WriteLine("На батон денег не хватает");
        }
    }
    else
    {
        Console.WriteLine("Батон не свежий");
    }



    if (!isWhiteBreadFresh) //второй вариант - при отрицательном условии, если хлеб не свежий. код короче и удобней
    {
        Console.WriteLine("Батон не свежий");
    }
    else if (sum >= whiteBreadPrice)
    {
         sum = (short)(sum - whiteBreadPrice); //или sum = Convert.ToInt16(sum - whiteBreadPrice)
         Console.WriteLine($"Купили свежий батон по цене {whiteBreadPrice}");
    }
    else
    {
            Console.WriteLine("На батон денег не хватает");
    }




    sum = (short)(sum - butterPrice);

    if (milkFatPercentage == 1.2F)
    {
        sum = Convert.ToInt16(sum - milkPrice);
    }

    if (sum >= icecreamPrice)
    {
        sum = Convert.ToInt16(sum - icecreamPrice);
    }

    Console.WriteLine($"Остаток суммы: {sum}");
}
else
{
    Console.WriteLine("Сумма не может быть меньше 0");
}

*/

/*
bool a = true;
bool b = false;

if (a || b) //логическое ИЛИ - или а верно, или b верно (результат Неверно, если и а, и b false)
{
    Console.WriteLine("Верно");
}
else
{
    Console.WriteLine("Неверно");
}



bool a = true;
bool b = false;
string name1 = "Tom";
string name2 = "Tom1";
if (name1.Equals(name2) || b) 
{
    Console.WriteLine("Верно");
}
else
{
    Console.WriteLine("Неверно");
}


bool a = true;
bool b = false;
string name1 = "Tom";
string name2 = "Tom1";
if (name1.Equals(name2) && b) // логическое И. а можно сделать отрицание: if ( !(name1.Equals(name2) && b) )
{
    Console.WriteLine("Верно");
}
else
{
    Console.WriteLine("Неверно");
}
*/


/*
    int x = 10; // вместо этого нагромождения можно использовать тернарную операцию, см. ниже
    int y = 20;
    int z;

    if ( x < y ) 
    {
        z = x + y;
    }
    else
    {
        z = x - y;
    }


    int x = 10; // тернарная операция: [первый операнд - условие] ? [второй операнд] : [третий операнд]
    int y = 20;
    int z;

    z = x < y ? x + y : x - y; // или так: z = x < y ? (x + y) : (x - y);
    Console.WriteLine(z); // 30

*/

/*
int x = 1;
if (x == 1)
{
    Console.WriteLine("1");
}
else if (x == 2) 
{
    Console.WriteLine("2");
}
else if (x == 3)
{
    Console.WriteLine("3");
}
else
{
    Console.WriteLine("Не соответствует условиям");
}


int x = 1;
switch (x)                             //альтернативное решение задачки выше
{
    case 1:                            // 1 в данном случае это значение, с которым нужно сравнить x
        Console.WriteLine("1");
        break;
    case 2:                            
        Console.WriteLine("2");
        break;
    case 3:
        Console.WriteLine("3");
        break;
    default:                                                      //если ни один кейс не подошел
        Console.WriteLine("Не соответствует условиям");
        break;
}



string name = "Tom";
switch (name)
{
    case "Alex":
        Console.WriteLine("Alex");
        break;
    case "Tom":
        Console.WriteLine("Tom");
        break;
}



string name1 = "Alex1";            //буленовские значения со switch как здесь, обычно не используются
switch (name1.Equals("Alex"))
{
    case true:
        Console.WriteLine("Alex");
        break;
    case false:
        Console.WriteLine("Tom");
        break;
}




Console.WriteLine(DoOperation(1));   //используем метод DoOperation. метод можно вызывать сколько угодно раз с разными параметрами
Console.WriteLine(DoOperation(2));
Console.WriteLine(DoOperation(3));

int DoOperation(int x)             // метод содержит: возвращаемое значение имя(параметры)    
{
    switch (x)                             
    {
        case 1:                            
            return 1;
        case 2:
            return 2;
      default: return 0;
    }

}

*/



























