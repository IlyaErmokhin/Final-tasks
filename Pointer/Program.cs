using System;

public class Arrow
{
    static void Main(string[] args)
    {
        while (true)
        {
            var keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
                
            {
                case ConsoleKey.UpArrow:
                    Console.Clear();       
                    Console.WriteLine("↑");
                    break;
                case ConsoleKey.DownArrow:
                    Console.Clear();
                    Console.WriteLine("↓");
                    break;
                case ConsoleKey.RightArrow:
                    Console.Clear();
                    Console.WriteLine("->");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.Clear();
                    Console.WriteLine("<-");
                    break;
            }
        }
    }
}