public class MultiTable
{
    static void Main(string[] args)
    {
        Console.Write("      |");
        for (int i = 1; i < 11; i++)
        {
            Console.Write("{0, 6}", i + "|");
        }
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------------------------");

        for (int i = 1; i < 11; ++i)
        {
            Console.Write("{0, 6}|", i);
            for (int j = 1; j < 11; ++j)
            {
                Console.Write("{0, 6}", i * j + "|");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------");
        }
    }
}