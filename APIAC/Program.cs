using System;

public class APIAC
{
    private static double radius = 2.0;
    private static double centerX = 0;
    private static double centerY = -1;
    
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the X coordinate: ");
        double x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Y coordinate: ");
        double y = int.Parse(Console.ReadLine());

        Console.WriteLine($"The point ({x},{y}) {(InOutCircle(x, y) ? "in the circle" : "outside the circle")}");
    }


    public static bool InsideCircle(double x, double y) =>
        Math.Sqrt(Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2)) <= radius;
    }
