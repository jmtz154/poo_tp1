using System;

class ej3
{
    static void Main()
    {
        // Solicitar el primer número al usuario
        Console.Write("Ingresa el primer número entero: ");
        string entrada1 = Console.ReadLine();
        int numero1 = int.Parse(entrada1);

        // Solicitar el segundo número al usuario
        Console.Write("Ingresa el segundo número entero: ");
        string entrada2 = Console.ReadLine();
        int numero2 = int.Parse(entrada2);

        // Realizar las operaciones matemáticas
        int suma = numero1 + numero2;
        int resta = numero1 - numero2;
        int multiplicacion = numero1 * numero2;
        int division = numero1 / numero2;
        int resto = numero1 % numero2;

        // Imprimir los resultados
        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Resta: " + resta);
        Console.WriteLine("Multiplicación: " + multiplicacion);
        Console.WriteLine("División: " + division);
        Console.WriteLine("Resto: " + resto);
    }
}