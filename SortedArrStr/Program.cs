public class SortArrStr
{
    static void Main(string[] args)
    {
        string path = "Str.txt";
        string[] lines = File.ReadAllLines(path);
        // Выводим отсортированный массив на экран
        Console.WriteLine("Отсортированный массив:");
        Sort(lines);
        for (int i = 0; i < lines.Length; i++)
            Console.WriteLine(lines[i]);

    }
    public static void Sort(string[] lines)
    {
        string s;
        // Сортировка
        for (int i = 0; i < lines.Length - 1; i++)
            for (int j = i; j >= 0; j--)
                if (String.Compare(lines[j], lines[j + 1]) > 0)
                {
                    s = lines[j];
                    lines[j] = lines[j + 1];
                    lines[j + 1] = s;
                }

    }
}