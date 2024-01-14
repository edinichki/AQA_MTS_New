namespace Arrays
{
    static class Program2
    {
        static void Main(string[] args)
        {

            /*
            //Задание 1
            //Создайте массив целых чисел. Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет.
            //Пусть число для поиска задается с консоли.
            */


            int[] array01 = new int[] { 8, 42, 31, 18, 75, 505, 4, 99 };
            int numb;
            bool numbInArray = false;

            Console.WriteLine("Введите любое число: ");
            numb = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array01.GetLength(0); i++)
            {
                if (array01[i] == numb)
                {
                    numbInArray = true;
                    break;
                }
            }

            if (numbInArray)
            {
                Console.WriteLine($"Заданное число {numb} входит в массив");
            }
            else
            {
                Console.WriteLine($"Заданное число {numb} не входит в массив");
            }


            /*
                 //Задание 2
                 //Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
                 //Пусть число задается с консоли. Если такого числа нет - выведите сообщения об этом.
                 //В результате должен быть новый массив без указанного числа.
            */

            Console.Write("Введите размер массива: ");
            int sz = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[sz];

            Console.WriteLine("Введите элементы массива:");
            for (int k = 0; k < sz; k++)
            {
                arr[k] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Введите число для удаления: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            for (int k = 0; k < sz; k++)
            {
                if (arr[k] == num)
                {
                    found = true;
                    for (int j = k; j < sz - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    sz--;
                    k--;
                }
            }

            if (!found)
            {
                Console.WriteLine("В массиве нет такого числа");
            }
            else
            {
                Console.WriteLine("Массив после удаления числа:");
                for (int k = 0; k < sz; k++)
                {
                    Console.Write(arr[k] + " ");
                }
                Console.WriteLine();
            }
        }
    }




    /*
        //Задание 3
        //Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
        //Для генерации случайного числа используйте метод Random().
        //Пусть будет возможность создавать массив произвольного размера.Пусть размер массива вводится с консоли.
   */


    Console.Write("Введите размер массива и увидите его целиком: ");
    int arraySize = Convert.ToInt32(Console.ReadLine());  //задаем размер массива

    int[] array = new int[arraySize];

            for (int i = 0; i<arraySize; i++)
            {
            array[i] = new Random().Next(1,100);     //рандомное число от 1 до 100
            }

   int max = array[0];
   int min = array[0];
   int sum = 0;

   for (int i = 0; i < arraySize; i++)
   {
       if (array[i] > max)
       {
        max = array[i];
       }
       if (array[i] < min)
       {
        min = array[i];
       }
       sum += array[i];
   }

   for (int i = 0; i <= array.GetUpperBound(0); i++)
   {
    Console.WriteLine($"{array[i]} ");
   }

   int mid = (int)sum / arraySize;

   Console.WriteLine($"Максимальное значение: {max}");
   Console.WriteLine($"Минимальное значение: {min}");
   Console.WriteLine($"Среднее значение: {mid}");





   /*
   //Задание 4
   //Создайте 2 массива из 5 чисел.
   //Выведите массивы на консоль в двух отдельных строках.
   //Посчитайте среднее арифметическое элементов каждого массива и сообщите,
   //для какого из массивов это значение оказалось больше(либо сообщите, что их средние арифметические равны).
   */


   int[] arr1 = { 51, 9, 33, 7, 0 };
   int[] arr2 = { 95, 70, 2, 10, 4 };

   Console.WriteLine("Массив 1:");
   for (int i = 0; i <= arr1.GetUpperBound(0); i++)
   {
    Console.Write($"{arr1[i]} ");
   }
   Console.WriteLine();

   Console.WriteLine("Массив 2:");
   for (int i = 0; i <= arr2.GetUpperBound(0); i++)
   {
    Console.Write($"{arr2[i]} ");
   }
   Console.WriteLine();

   int sum1 = 0;
   int sum2 = 0;

   for (int i = 0; i < arr1.Length; i++)
   {
    sum1 += arr1[i];
   }

   for (int i = 0; i < arr2.Length; i++)
   {
    sum2 += arr2[i];
   }

   int average1 = sum1 / arr1.Length;
   int average2 = sum2 / arr2.Length;

   if (average1 > average2)
   {
    Console.WriteLine("Среднее арифметическое элементов массива 1 больше");
   }
   else if (average1 < average2)
   {
    Console.WriteLine("Среднее арифметическое элементов массива 2 больше");
   }
   else
   {
    Console.WriteLine("Средние арифметические элементов обоих массивов равны");
   }



