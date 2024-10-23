using System;

class Program
{
    static void Main()
    {
        for (int x = -10; x <= 10; x++)
        {
            int y = (x * x) - (2 * x) + 1;
            Console.WriteLine($"Para x = {x}, y = {y}");
        }
    }
}