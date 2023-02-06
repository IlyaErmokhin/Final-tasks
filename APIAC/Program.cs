using System;
public class APIAC
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the X coordinate: ");
        double x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Y coordinate:");
        double y = int.Parse(Console.ReadLine());

        Console.WriteLine($"The point ({x},{y}) {(InOutCircle(x, y) ? "in the circle" : "outside the circle")}");
    }


    public static bool InOutCircle(double x, double y)
    {
        double radius = 2;
        double pointX = 0;
        double pointY = -1;
        double d = Math.Sqrt(Math.Pow(x - pointX, 2) + Math.Pow(y - pointY, 2));
        if (d <= radius)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}