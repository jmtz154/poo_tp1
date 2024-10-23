using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        int i = 1;
        Console.WriteLine("i = " + i + " sum = " + sum);

        while (i <= 10)
        {
            sum += i++;
            Console.WriteLine("i = " + i + " sum = " + sum);
        }

        Console.WriteLine();
        Console.WriteLine($"Toral = {sum}");
        Console.WriteLine();
        Console.WriteLine("Programa terminado.");
    }
}