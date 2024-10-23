using System;

class ej2
{
    static void Main()
    {
        int resultado1 = -1 + 3 * 5;
        int resultado2 = (24 + 5) % 7;
        int resultado3 = 15 + (-4 * 6) / 11;
        int resultado4 = 2 + 10 / 6 * 1 - 7 % 2;

        Console.WriteLine("El resultado de la operación -1 + 3 * 5 es: " + resultado1);
        Console.WriteLine("El resultado de la operación (24 + 5) % 7 es: " + resultado2);
        Console.WriteLine("El resultado de la operación 15 + -4 * 6 / 11 es: " + resultado3);
        Console.WriteLine("El resultado de la operación 2 + 10 / 6 * 1 - 7 % 2 es: " + resultado4);
    }
}