using System;

class ej4
{
    static void Main()
    {
        // Solicitar la temperatura en grados Celsius al usuario
        Console.Write("Ingresa la temperatura en grados Celsius: ");
        string entrada = Console.ReadLine();
        double celsius = double.Parse(entrada);

        // Convertir a Kelvin
        double kelvin = celsius + 273.15;

        // Convertir a Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Imprimir los resultados
        Console.WriteLine("Temperatura en Kelvin: " + kelvin);
        Console.WriteLine("Temperatura en Fahrenheit: " + fahrenheit);
    }
}