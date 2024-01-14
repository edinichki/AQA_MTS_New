// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information



namespace TypesAndOperators
{
    static class Program1
    {
        static void Main(string[] args)
        {

            /*
                //Задание 1
                Напишите программу -консольный калькулятор.
                UseCase:
            1.Пользователь запускает программу
            2.В терминале предлагается ввести число номер 1 – пользователь вводит число номер 1
            3.В терминале предлагается ввести допустимую операцию(+, -, *, /) – пользователь вводит операцию
            4.В терминале предлагается ввести число номер 2 – пользователь вводит число номер 2
            5.В терминал выводится результат выбранной операции
            Примечание:
            ·  	Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
            ·  	В случае использования операции деления, организуйте проверку попытки деления на ноль с выводом соответствующего сообщения
            */



            int number1;
            int number2;
            int result;
            string operation;


            Console.WriteLine("Введите число номер 1: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выберите операцию: +, -, *, /");
            operation = Console.ReadLine();

            Console.WriteLine("Введите число номер 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());


            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    Console.WriteLine($"{number1} + {number2} = {result}");
                    break;
                case "-":
                    result = number1 - number2;
                    Console.WriteLine($"{number1} - {number2} = {result}");
                    break;
                case "*":
                    result = number1 * number2;
                    Console.WriteLine($"{number1} * {number2} = {result}");
                    break;
                case "/":
                    if (number2 == 0)
                    {
                        Console.WriteLine("Деление на ноль недопустимо");
                        break;
                    }
                    else
                    {
                        result = number1 / number2;
                        Console.WriteLine($"{number1} / {number2} = {result}");
                        break;
                    }
                default:
                    Console.WriteLine("Введенные данные не соответствуют условиям");
                    break;
            }





            /*
            //Задание 2
            //Напишите программу определения, попадает ли введенное пользователем число (от -50 до 50) 
            //в один из числовых промежутков [-40, -10] [-9, 0] [1, 10][11, 40].
            //Если да, то укажите, в какой именно промежуток.
            //Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, 
            //то выводится соответствующее сообщение.
            */

            sbyte num;
            Console.WriteLine("Введите любое число от -50 до 50: ");
            num = Convert.ToSByte(Console.ReadLine());
            if (num >= -40 && num <= -10)
            {
                Console.WriteLine($"Введенное число {num} входит в числовой промежуток [-40, -10]");
            }
            else if (num >= -9 && num <= 0)
            {
                Console.WriteLine($"Введенное число {num} входит в числовой промежуток [-9, 0]");
            }
            else if (num >= 1 && num <= 10)
            {
                Console.WriteLine($"Введенное число {num} входит в числовой промежуток [1, 10]");
            }
            else if (num >= 11 && num <= 40)
            {
                Console.WriteLine($"Введенное число {num} входит в числовой промежуток [11, 40]");
            }
            else
            {
                Console.WriteLine($"Введенное число {num} не входит ни в один из имеющихся числовых промежутков");
            }



            /*
            //Задание 3
 
            //Напишите программу русско-английский переводчик.
            //Программа знает 10 слов о погоде.
            //Требуется, чтобы пользователь вводил слово на русском языке, 
            //а программа давала ему перевод этого слова на английском языке.
            //Если пользователь ввел слово, для которого отсутствует перевод, 
            //то следует вывести сообщение, что такого слова нет.
            */

            Console.WriteLine("Я русско-английский переводчик о погоде.\nВведите слово по-русски и получите перевод на английский.");
            string? wrd = Console.ReadLine();
            switch (wrd)
            {
                case "Погода":
                    Console.WriteLine($"Перевод: Weather");
                    break;
                case "Солнце":
                    Console.WriteLine($"Перевод: Sun");
                    break;
                case "Облако":
                    Console.WriteLine($"Перевод: Cloud");
                    break;
                case "Осадки":
                    Console.WriteLine($"Перевод: Precipitation");
                    break;
                case "Дождь":
                    Console.WriteLine($"Перевод: Rain");
                    break;
                case "Снег":
                    Console.WriteLine($"Перевод: Snow");
                    break;
                case "Град":
                    Console.WriteLine($"Перевод: Hail");
                    break;
                case "Ветер":
                    Console.WriteLine($"Перевод: Wind");
                    break;
                case "Температура":
                    Console.WriteLine($"Перевод: Temperature");
                    break;
                case "Влажность":
                    Console.WriteLine($"Перевод: Humidity");
                    break;
                default:
                    Console.WriteLine("Мой скромный словарный запас не позволяет мне сделать перевод. Пожалуйста, попробуйте еще.");
                    break;
            }





            /*
            //Задание 4
 
            //Напишите программу, которая будет выполнять проверку чисел на четность.
            //Предложите два варианта решения поставленной задачи
            */

            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine()); //преобразуем строку в целое число
            if (number % 2 == 0)                        //используем операцию деления по модулю
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }



            //второй вариант:

            Console.Write("Введите число: ");
            int number11 = Convert.ToInt32(Console.ReadLine());
            string result11 = (number % 2 == 0) ? "Число четное" : "Число нечетное";   //тернарная операция 
            Console.WriteLine(result11);




        }
    }

}