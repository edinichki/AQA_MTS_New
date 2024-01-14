using System.Text;
using System.Text.RegularExpressions;

namespace Strings
{
    static class Program3
    {
        static void Main(string[] args)
        {

            //Примечание:
            //Данные для задач могут быть проинициализированы непосредственно в задаче, 
            //введены через терминал или(*) прочитаны из подготовленного файла.

            //Задание 1:
            //Заменить в строке все вхождения 'test' на 'testing'.Удалить из текста все символы, являющиеся цифрами.

            string firstStr = "there are no test sce78narios, as well as any 027expectation of the test r11esult";
            string secondStr = firstStr.Replace("test", "testing");
            Console.WriteLine($"Строка без test: {secondStr}");

            string resultStr = "";
            foreach (char ch in secondStr)
            {
                if (!char.IsDigit(ch))             //добавляем в новую строку только символы, которые не являются цифрами
                {
                    resultStr += ch;
                }
            }
            Console.WriteLine($"Строка без цифр: {resultStr}");


            //Задание 2
            //Используя метод вывода значения в консоль, выполните конкатенацию слов и выведите на экран следующую фразу:
            //Welcome to the TMS lessons.
            //Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome".Не забывайте о пробелах после каждого слова

            //вот решение с нагромождениями .)))

            string join_wrd1 = "Welcome";
            string join_wrd2 = "to";
            string join_wrd3 = "the";
            string join_wrd4 = "TMS";
            string join_wrd5 = "lessons.";

            string[] wrds = new string[] { join_wrd1, join_wrd2, join_wrd3, join_wrd4, join_wrd5 };

            string final_wrds = "";
            foreach (string wrd in wrds)
            {
                final_wrds += $"\"{wrd}\" ";
            }
            Console.WriteLine($"Слова в кавычках: {final_wrds}");


            //а вот без нагромождений:

            Console.WriteLine("\"Welcome\"" + " " + "\"to\"" + " " + "\"the\"" + " " + "\"TMS\"" + " " + "\"lessons.\"");




            //Задание 3
            //Дана строка: “teamwithsomeofexcersicesabcwanttomakeitbetter.”
            //Необходимо найти в данной строке "abc", записав всё что до этих символов в первую переменную,
            //а также всё, что после них во вторую.
            //Результат вывести в консоль.


            string abc = "teamwithsomeofexcersicesabcwanttomakeitbetter.";
            string[] abcOff = abc.Split("abc");

            string firstPart = abcOff[0];
            string secondPart = abcOff[1];

            Console.WriteLine($"Начало: {firstPart}");
            Console.WriteLine($"Конец: {secondPart}");



            //Задание 4
            //Дана строка: “Плохой день.”
            //Необходимо с помощью метода substring удалить слово "плохой".
            //После чего необходимо используя команду insert создать строку со значением: Хороший день!!!!!!!!!.
            //Заменить последний "!" на "?"

            string sad = "Плохой день.";
            Console.WriteLine($"Сначала было так: {sad}");

            string neutral = sad.Substring("Плохой".Length);
            Console.WriteLine($"Потом так: {neutral}");

            string glad = neutral.Insert(0, "Хороший ");
            string gladglad = glad.Replace(".", "!!!!!!!!!");
            Console.WriteLine($"Случилось чудо: {gladglad}");

            string doubt = gladglad.Remove(gladglad.Length - 1);
            string doubtdoubt = doubt.Insert(doubt.Length, "?");
            Console.WriteLine($"Чудо омрачено: {doubtdoubt}");












        }
    }
}