using System;

namespace PrimeNumber;


public class isPrimeNumber
{
    static void Main(string[] args)
    {
        bool PrimeNumber = true;
        Console.WriteLine("Введите число");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Число {n} {(isPrimeNumber.PrimeNumb(n) ? "простое" : "не является простым")}");
    }
    public static bool PrimeNumb(int n)
    {
        int k = 0;
        k = n / 2;
        for (int i = 2; i <= k; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}