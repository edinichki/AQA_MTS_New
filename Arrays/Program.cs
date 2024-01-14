namespace Arrays
{
    static class Program
    {
        static void Main1(string[] args)
        {
            /*
               //// Массивы и циклы
               ///int[] array;
                   //
                   ///
                   ////
                   ///
               */

            /*
                int n = 4;          //инициализация массива, ниже короче:
                array1 = new int[n]; 

                array1 = new int[4];

                int[] array = { 1, 9, 3, 6, 5 };
                int[] array2 = new int[5] { 1, 9, 3, 6, 5 };   //без указания длины массива [5] тоже ок: ([])

            int[] numbers;
            int[] nums = new int[4];
            int[] nums2 = new int[4] { 1, 2, 3, 5 };
            int[] nums3 = new int[] { 1, 2, 3, 5 };
            int[] nums4 = new[] { 1, 2, 3, 5 };
            int[] nums5 = { 1, 2, 3, 5 };


            */


            /*
            int[] array = { 1, 9, 3, 6, 5 };

            Console.WriteLine("Length: " + array.Length);                       // количество всех элементов
            Console.WriteLine("Rank: " + array.Rank);                           // ранк массива = разрядность (одно-, двухмерный и тд)
            Console.WriteLine("GetLength(0): " + array.GetLength(0));           // количество строк = возвращает длину (5) текущей строки (у нас - нулевой)
            Console.WriteLine("GetUpperBound(0): " + array.GetUpperBound(0));   // Верхний индекс строк (4)(=от 0 до 4) = индекс последнего элемента строки
            Console.WriteLine("GetLowerBound(0): " + array.GetLowerBound(0));   // Нижний индекс строк  = индекс первого элемента строки (0)


            Console.WriteLine(array[2]);    //обращаемся к элементу массива, в нашем случае это 3


            Console.WriteLine(array[5]);     // значения массива можно менять в любом нужном месте:
            array[0] = 10;                   // вот так присвоили элементу0 новое значение 10 вместо 1


            int[] array = { 1, 9, 3, 6, 5 };



            Console.WriteLine(array[array.Length - 1]);  //получить последний элемент массива
            Console.WriteLine($"Last item in array: {array[array.Length - 1]}");

            Console.WriteLine($"Last item in array: {array[array.Length - 2]}");  //получить предпоследний элемент массива или как ниже:
            Console.WriteLine($"Last item in array: {array[^2]}");                //получить предпоследний элемент с конца

            Console.WriteLine($"Last item in array: {array[array.GetUpperBound(0)]}");  //получить последний элемент в текущей строке. тут 0 тк строка массива одна
            //-самый правильный вариант (в сравнении с ...[array.Length - 1] выше), где мы указываем строку с которой работаем
           */


            ///циклы, перебор массива///
            /////если нам нужны рутинные действия, но с разными значениями, то используем for
            ///


            /*
           for (объявление переменной с указанием начального значения; условие; изменение переменной)    
                    {
                    операции которые нам надо повторить много раз;
                    }


            Console.WriteLine(array[0]); //например так это бы выглядело без использования for
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            */

            /*
                int[] array = { 1, 9, 3, 6, 5 };

                Console.WriteLine();
                for (int i = 0; i < array.GetLength (0); i++)   //а так норм: старт с ниж элемента массива и будем увеличивать наш индекс на единицу, пока условие выполняется
                {                                               //array.GetLength (0) длина текущей строки
                    Console.WriteLine($"{array[i]} ");
                }


                for (int i = 0; i <= array.GetUpperBound(0); i++) //  <= тк GetUpperBound выводит верхний индекс
                {                                              
                    Console.Write($"{array[i]} ");                //вывод в строку красиво
                }


                for (int i = 0; i <= array.GetUpperBound(0); i++)    
                {
                    array[i] = new Random().Next(100);                //переинициализируем элемент - получить рандомное число с указанным промежутком
                }



                //
                //а вот foreach не работает с индексами, а работает с элементами (их значениями)

                Console.WriteLine();
                foreach (int item in array)         //int тут тип массива с которым мы работаем
                {
                    Console.WriteLine($"{item} ");  //просто выводим элемены массива на экран, за границы цикла не выходим
                }




                for (int i = 1; i <= 10; i++)    //используем цикл для того, чтобы вывести на экран 10 раз Hello!
                {
                    Console.WriteLine("Hello!");
                }


                for (int i = 1; i <= 10; i++)         //то же самое но
                {
                    Console.WriteLine($"{i}Hello!");  //добавляем вывод переменной i в качестве параметра строки - получаются пронумерованнные строки (1-9)
                }


                for (int i = 0; i <= 10; i += 2)      //нам нужно вывести все четные числа от 0 до 10 - меняем шаг на +2
                {
                    Console.Write($"{i} ");
                }



                Console.WriteLine();
                string text = "Hello!!!";       //нужно каждую букву текста вывести на экран
                foreach (char ch in text)       //пройдемся по каждому символу в множестве строки
                {
                    Console.Write($"{ch} ");
                }


                int[] arr1 = new int[6];                           // задать значение массиву
                for (int i = 0; i <= arr1.GetUpperBound(0); i++)
                {
                    arr1[i] = new Random().Next(100);                
                }



                //операторы break (прекращает выполнение цикла совсем) и continue (перескакиваем шаг, где выполняется условие, и продолжаем дальше)
                //вносят определенную логику в цикл
                //используются вместо таких нагромождений как ниже

                for (int i = 0; i <= 10; i += 2)      //нам нужно вывести все четные числа от 0 до 10, а число 6 не нужно
                {
                    if (i == 6)
                    {

                    }
                    else
                    Console.Write($"{i} ");
                }



                for (int i = 0; i <= 10; i += 2)      // то же самое по-другому:
                {
                    if (i != 6)
                    {
                        Console.Write($"{i} ");
                    }
                }


                for (int i = 0; i < 9; i++)          //с break
                {
                    if (i == 5)
                        break;
                    Console.WriteLine(i);
                }


                for (int i = 0; i < 9; i++)
                {
                    if (i == 5)
                        continue;
                    Console.WriteLine(i);
                }


                //цикл do... while - достаточно условия, без объявления переменной
                //do - до того, как проверится какое-то условие, цикл выполнится минимум  раз
                //while - сразу проверяет условие, прежде чем выполнить какие-то действия

                do
                {
                    действия цикла
                }
                while (условие)



                int u = 6;                     //нам нужно выходить из цикла по флагу
                bool flag = true;
                do
                {
                    if (u < 0) = false;
                    Console.WriteLine($"{u}");
                    u--;
                }
                while (flag);



                int u = 6;                     //второй вариант выполнения
                do
                {
                   Console.WriteLine($"{u}");
                    u--;
                }
                while (u >= 0);




                // -============================================= Двумерный массив =============================================-
                ///=таблица
                ///


                int[,] nums1;
                int[,] nums2 = new int[2, 3];                                //сначала указываем сколько у нас строк, потом сколько в строке элементов
                int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
                int[,] nums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
                int[,] nums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
                int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };


                int[,] array = new int[4, 5];  //4 строки, 5 элементов


                Console.WriteLine("Length: " + array.Length);                       // количество всех элементов
                Console.WriteLine("Rank: " + array.Rank);                           // ранк массива
                Console.WriteLine("GetLength(0): " + array.GetLength(0));           // количество строк
                Console.WriteLine("GetUpperBound(0): " + array.GetUpperBound(0));   // Верхний индекс строк
                Console.WriteLine("GetLength(1): " + array.GetLength(1));           // количество столбцов
                Console.WriteLine("GetUpperBound(1): " + array.GetUpperBound(1));   // Верхний индекс столбцов
                Console.WriteLine("GetLowerBound(0): " + array.GetLowerBound(0));   // Нижний индекс строк
                Console.WriteLine("GetLowerBound(1): " + array.GetLowerBound(1));   // Нижний индекс столбцов
                Console.WriteLine("=========");

                int t = 1;
                //задание значений
                Console.WriteLine();
                for (int i = 0; i < array.GetLength(0); i++)       //или так: for (int i = 0; i <= array.GetUpperBound(0); i++) 
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = i + j;        //чтобы обратиться к элементу, нужно указать номер строки и номер колонки (i + j для выведения по порядку)
                    }
                }



                int rows = array.GetLength(0);                //вариант когда выведет красиво
                int columns = array.Length / rows ;
                for (int i = 0; i < rows; i++)      
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.WriteLine($"{array[i, j]} \t");        
                    }
                    Console.WriteLine();
                }


                foreach (int item in array)               // или некрасиво пробежаться по всем элементам массива
                {
                    Console.WriteLine($"{item} ");
                }





                int[,] array1 = new int[2, 3]   //способ инициализации массива
                {
                    { 1, 2, 3 }, 
                    { 4, 5, 6 },
                };


                int[,] array1 =                   //еще способ инициализации массива
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                };








                // -============================================= Трехмерный массив =============================================-

               int[,,] array3D = new int[,,]
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 }
                },
                {
                    { 7, 8, 9 },
                    { 10, 11, 12 }
                }
            };


                Console.WriteLine("Length: " + array3D.Length);                       // количество всех элементов
                Console.WriteLine("Rank: " + array3D.Rank);                           // ранк массива
                Console.WriteLine("GetLength(0): " + array3D.GetLength(0));           // количество строк
                Console.WriteLine("GetUpperBound(0): " + array3D.GetUpperBound(0));   // Верхний индекс строк
                Console.WriteLine("GetLength(1): " + array3D.GetLength(1));           // количество столбцов
                Console.WriteLine("GetUpperBound(1): " + array3D.GetUpperBound(1));   // Верхний индекс столбцов
                Console.WriteLine("GetLength(2): " + array3D.GetLength(2));           // количество столбцов
                Console.WriteLine("GetUpperBound(2): " + array3D.GetUpperBound(2));   // Верхний индекс столбцов

                Console.WriteLine("GetLowerBound(0): " + array3D.GetLowerBound(0));   // Нижний индекс строк
                Console.WriteLine("GetLowerBound(1): " + array3D.GetLowerBound(1));   // Нижний индекс столбцов
                Console.WriteLine("GetLowerBound(2): " + array3D.GetLowerBound(2));   // Нижний индекс столбцов




                for (int i = 0; i <= array3D.GetUpperBound(0); i++)
                {
                    Console.WriteLine($"-========= Level {i} ==========-"); //вывод с разделением слоёв
                    for (int j = 0; j <= array3D.GetUpperBound(1); j++)
                    {
                        for (int k = 0; k <= array3D.GetUpperBound(2); k++)
                        {
                            Console.Write($"{array3D[i, j, k]} \t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"-============================-");
                }

            */


            /*
            // -============================================= Многомерный (зубчатый) массив =============================================-
            //в каждой его стоке мб разное количество элементов


            int[][] numbers =                                  //массив из трех строк
        {
            new int[] { 1, 2 },
            new int[] { 1, 2, 3, 4, 5 },
            new int[] { 1, 2, 3 }
        };


            Console.WriteLine("Length: " + numbers.Length);                       // количество всех элементов
            Console.WriteLine("Rank: " + numbers.Rank);                           // ранк массива
            Console.WriteLine("GetLength(0): " + numbers.GetLength(0));           // количество строк
            //Console.WriteLine("GetLength(1): " + numbers.GetLength(1));           exeption! количество строк не выведет, тк это не двумерный массив 
            Console.WriteLine("GetUpperBound(0): " + numbers.GetUpperBound(0));   // количество строк
            Console.WriteLine("=========");


            foreach (int[] row in numbers)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    row[i] = new Random().Next(100);
                }
            }

            for (int i = 0; i <= numbers.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= numbers[i].GetUpperBound(0); j++)
                {
                    Console.Write($"{numbers[i][j]} \t");
                }

                Console.WriteLine();
            }





            //================Задача
            int[] nums = { -4, 8, 10, 2, 12, 0, 5, 6 };                               //инверсия массива

            foreach (int item in nums)                //сначала выводим массив какой он есть
            {
                Console.Write($"{item} \t");
            }
            Console.WriteLine();
            /*
            nums[0] <-> nums[nums.Length - 1 - 0]  //меняем местами индекс0 с последним индексом строки
            nums[1] <-> nums[nums.Length - 1 - 1]
            nums[2] <-> nums[nums.Length - 1 - 2]
            */


            /*
            int n = nums.Length; // длина массива
            int k = n / 2;       
            int tmp;

            for (int i = 0; i < k; i++)     //движемся от 0 до середины
            {
                tmp = nums[i];
                nums[i] = nums[n - 1 - i];
                nums[n - 1 - i] = tmp;
            }

            foreach (int item in nums)
            {
                Console.Write($"{item} \t");
            }
            Console.WriteLine();

            Array.Reverse(nums);        //второй переворот массива - с помощью готового метода для переворачивания массива: Array.Reverse();

            foreach (int item in nums)
            {
                Console.Write($"{item} \t");
            }

            */











        }
    }
}