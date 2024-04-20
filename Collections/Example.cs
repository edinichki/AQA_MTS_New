namespace Collections;

public class Example
{
    public void Run()
    {
        Dictionary<string, List<int>> studentsGrades = new Dictionary<string, List<int>>();  //используем коллекцию внутри коллекции

        studentsGrades.Add("Sasha", new List<int> { 7, 9, 10 });
        studentsGrades.Add("Masha", new List<int> { 10, 9, 10 });
        studentsGrades.Add("Stas", new List<int> { 6, 5, 4 });

        foreach (var item in studentsGrades)            //пробегаемся по коллекции studentsGrades, где Value будет List
        {
            var averageMark = item.Value.Average();
            Console.WriteLine($"Средняя оценка : {averageMark}");
        }
    }
}
