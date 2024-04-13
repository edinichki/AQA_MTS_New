﻿using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Classes.Models;            //global using Classes.Models;  есть такой вариант. или вообще вынести в отдельный класс 



namespace Classes
{
    class Program
    {
        static void Main(string[] args) 
        {/*
            int[] array = { 1, 8, 14, -4, 0, 7 };

            foreach (var item in array)                //выводим исходный массив
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            Array.Reverse(array);                      //реверс массива
            {
                foreach (var item in array)            //опять вывод массива: точно такой же блок как выше (одинаковые блоки кода=дубликаты)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();
            }

    

            PrintArray(array);         //описание метода (методы описываются обязательно в рамках класса) он же вызов самого метода=выполняемая операция
            
            void PrintArray(int[] arr) {      //описание метода. void = тип метода, который показывает, что ничего возвращаться не будет (return тоже не нужен)
                foreach (var item in arr)
                {
                    Console.Write($"{item}\t");
                }

                Console.WriteLine();
            }



            //тип_возвращаемого_значения НазваниеМетода(параметры)
            {
                // тело метода
                //выполняемые операции
                return результат; //возвращаемое значение (если есть)
            }




            // -=================== Метод без параметров ===================-
            void MethodWithoutParameters()
            {
                // Тело метода
            }
            
            
            // -=================== Метод без возвращаемого значения ===================- но с параметрами
            void PrintMessage(string message)                                    //=требование метода передать мне что-то, тут это строка
            {
                Console.WriteLine(message);
            }


            PrintMessage("Text"); //вызов метода уже требует строковый параметр 
            PrintMessage(1); //так не годится, нужна конвертация

            string tmp = "jhhkk"; //a вот так уже норм
            PrintMessage(tmp);



            // -=================== Метод с возвращаемым значением ===================-
            string GetInfo()          //описание метода, а не его вызов!
            {
                ///...
                return "Test";  //после return обязательно дб строка! 
            }
            string result = GetInfo();  //обычная операция присвоения. и вызов метода: нам нужно взять какое-то значение,которое мне отдаст этот метод, и поместитть его в переменную result 
            Console.WriteLine(result);  //вывод на консоль: Test




            // -=================== Метод с параметрами по умолчанию ===================-
            void DisplayGreeting(string greetingMessage, string name = "Гость")   //когда будем вызывать метод, нужно чтобы на вход было передано 2 строки
            {
                Console.WriteLine($"{greetingMessage}, {name}!");
            }


            DisplayGreeting("Hello");          //вызов метода со вторым параметром по умолчанию
            DisplayGreeting("Hello", " Alex"); //вызов метода, " Alex" можно было бы и не указывать - тогда бы подставился Гость по умолчанию, но раз он есть, то он главней

            //сигнатура метода - это тип метода, его параметры, их количество





            // -=================== Метод с переменным числом аргументов ===================-
            int CalculateSum(params int[] numbers)     //тут массив параметров, их может быть сколь угодно. метод: посчитать сумму чисел, которые мы передаем
            {
                int sum = 0;  //инициализируем начальную сумму

                foreach (int num in numbers)     //перебираем все элементы массива numbers, который придет к нам извне
                {
                    sum += num;                  //значение переменной sum увеличивается на значение переменной num
    }
                return sum;           //возвращаем посчитанную сумму
            }
            
            int sum1 = CalculateSum(1, 2, 3, 4, 5);     //вот первый вызов метода - нужно сложить числа от 1 до 5
            int sum2 = CalculateSum(); // Пустой вызов   (sum2 будет 0)

            Console.WriteLine("Sum 1: " + sum1);
            Console.WriteLine("Sum 2: " + sum2);


            
            // -=================== Передача параметров ===================-
            // -=================== По значению               т.е. значение одной переменной мы передаем другой переменной, не ссылкой
            
            void SimpleAdd(int x, int y)                //По умолчанию аргументы передаются по значению,
            {
                int ans = x + y;
                // Вызывающий код не увидит эти изменения, т.к. модифицируется копия исходных данных,
                
                // Раcкомментировать
                //х = 10000;
                //у = 88888;
            }


            // -=================== По ссылке
            // -=================== Out
            // Значения выходных параметров должны быть установлены внутри вызываемого метода.
            static void OutAdd (int x, int y, out int ans)     //параметр out выйдет из нашего метода с каким-то другим значением
            {
                ans = x + y;               //параметр ans позволяет присвоить новые значения для x и y
            }
            // Присваивать начальные значения локальным переменным, используемым как выходные параметры, не обязательно
            // при условии, что они впервые используются
            OutAdd(90, 90, out int ans1); // - Первый вариант
            
            //int ans;
            //OutAdd(90, 90, out ans); // - Второй вариант
            
            Console.WriteLine("OutAdd: 90 + 90 = {0}", ans);  //180
            Console.WriteLine("OutAdd: 90 + 90 = {0}", ans1); //180


            // Практическое применение в тестировании - возврат данных
            void FillTheseValues(out int a, out string b, out bool c)
            {
                a = 9;
                b = "Enjoy your string.";
                c = true;
            }


            // -=================== Ref
            void ModifyValue(ref int value)               //переменную value внутри нашего метода мы можем модифицировать:
            {
                value = value * 2;
            }

            int mainValue = 5;      // Если закоментировать - будет ошибка, тк нужно обязательно проинициализировать переменную
            Console.WriteLine($"mainValue is {mainValue}");
            ModifyValue(ref mainValue);
            Console.WriteLine($"mainValue now is {mainValue}");




            
            // -=================== Возврат значений ===================-
            // -=================== Возврат значения
            int GetPersonAge()
            {
                return 25;      //если метод не void, то команда return обязательна!
            }
            
            Console.WriteLine($"Age: {GetPersonAge()}");        //оп и название метода используем как переменную
            
            //то же самое, но длинней:
            int x = GetPersonAge();             
            Console.WriteLine($"Age: {x}");



            // -=================== Возврат нескольких значений
            (string, int) GetPersonInfo()                 
            {
                return ("John", 25);            // дб строгий порядок типов возвращаемых значений - (string, int)
            }

            var person = GetPersonInfo();
            Console.WriteLine($"Name: {person.Item1}, Age: {person.Item2}");


            
            // -=================== Сжатый метод
            int ShortAdd(int х, int у) => х + у;
            
            //это то же самое что и
            int ShortAdd(int х, int у)
            {
                return х + у;
            }
            //но покороче
           


            // -=================== Рекурсивная функция
            int Factorial(int n)     //внутри метода мы вызываем этот же метод = зацикливаем процесс
            {
                if (n == 1) return 1;   //дб обязательно точка возврата. пока 4 не равно 1 выполняем 
 
                return n * Factorial(n - 1);
            } 
            
            int factorial4 = Factorial(4);  // 24
            int factorial5 = Factorial(5);  // 120
            int factorial6 = Factorial(6);  // 720
 
            Console.WriteLine($"Факториал числа 4 = {factorial4}");
            Console.WriteLine($"Факториал числа 5 = {factorial5}");
            Console.WriteLine($"Факториал числа 6 = {factorial6}");
            




            // -=================== Классы ===================-
            // -=================== Структура класса
            EmptyClass emptyClassObject = new EmptyClass();

            Person personObj = new Person();
            
            personObj.Print();
            
            personObj.name = "Alex";
            personObj.age = 45;
            personObj.Print();

            // -=================== Создание конструкторов
            PersonWithConstructor personWithConstructor = new PersonWithConstructor();
            personWithConstructor.Print();


            ConstructorByDefault constructorByDefault = new ConstructorByDefault();
            
            ConstructorCustom constructorCustom1 = new ConstructorCustom(1);
            ConstructorCustom constructorCustom2 = new ConstructorCustom("test");

            ConstructorFull constructorFull1 = new ConstructorFull();
            ConstructorFull constructorFull2 = new ConstructorFull(1);
            ConstructorFull constructorFull3 = new ConstructorFull("test");
            
            // -=================== Цепочка вызова конструкторов
            PersonChain personChain1 = new PersonChain();
            PersonChain personChain2 = new PersonChain("Alex");
            PersonChain personChain3 = new PersonChain("Alex", 45);
            
            personChain1.Print();
            personChain2.Print();
            personChain3.Print();

            // -=================== Первичные конструкторы
            PersonPrimaryConstructors personPrimaryConstructors4 = new PersonPrimaryConstructors(name: "Alex", age: 45); //указываем какому свойству установить какое значение

            // PersonPrimaryConstructors personPrimaryConstructors1 = new PersonPrimaryConstructors();          - Ошибка
            PersonPrimaryConstructors personPrimaryConstructors2 = new PersonPrimaryConstructors(name: "Alex");
            // PersonPrimaryConstructors personPrimaryConstructors3 = new PersonPrimaryConstructors(age: 45);   - Ошибка


            personPrimaryConstructors2.Print();
            personPrimaryConstructors4.Print(); 

            // -=================== This
            PersonThis personThis = new PersonThis("Alex", 45);

            NamespaceA.NamespaceC.ClassA classA = new NamespaceA.NamespaceC.ClassA();
            classA.Print();
            NamespaceB.ClassA classAB = new NamespaceB.ClassA();
            classAB.Print();

*/

            // -=================== Практика ===================-
            // -=================== Задача 1
            Student[] students = new Student[14];              //массив students из 14 объектов класса Student

            for (int i = 0; i < 14; i++)
            {
                students[i] = new Student();
                students[i].name = "Alex" + i;
                students[i].group = new Random().Next(2);      //формируем номер группы - 10 или 2
                students[i].diplomMark = new Random().Next(1, 11); //оценка по диплому от 1 до 10
            }

            Console.WriteLine($"Students.Length: {students.Length}");  //выводим массив с данными 

            foreach (var student in students)
            {
                Console.Write($"Name: {student.name}, Group: {student.group}, Mark: {student.diplomMark}");
                Console.WriteLine();
            }
            Console.WriteLine();



            // -=================== Задача 2
            foreach (Student student in students)
            {
                if (student.diplomMark == 9 || student.diplomMark == 10)
                {
                    student.Print();                     //тут для вывода использовали метод
                }
            }
            Console.WriteLine();



            // -=================== Задача 3
            Student[] students1 = new Student[14];

            for (int i = 0; i < 14; i++) students1[i] = new Student("Alex" + i);
            foreach (var student in students1) student.Print();
            Console.WriteLine();



            // -=================== Задача 4
            Cat cat = new Cat();               //создаем экземпляр класса Сat
            cat.name = "Barsik";
            cat.age = 2;
            cat.maxFoodCount = 3;              //котик наелся

            Console.WriteLine($"Наелся? - {cat.Feed(2)}");           //вызываем метод кормежки
            Console.WriteLine($"Наелся? - {cat.Feed(4)}");
            Console.WriteLine("Наелся? - {0}", cat.Feed(3) ? "Да" : "Нет");  //буленовск.терн.операция но с параметрами
        }
    }
}