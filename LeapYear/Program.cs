using System;
public class LipYear
{
    public static void Main(string[] args)
    {
        int k;
        Console.Write("Enter the year: ");
        k = int.Parse(Console.ReadLine());
        Console.Write($" {k} {(lipYear(k) ? "год - високосный" : "год - невисокосный")}");

    }

    public static bool lipYear(int k)
    {
        if (k % 4 == 0 && (k % 100 != 0 || k % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}