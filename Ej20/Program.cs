using System;

class Program
{
    static void Main()
    {
        double a;
        double b;
        Console.Write("Ingrese el valor de a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el valor de b: ");
        b = double.Parse(Console.ReadLine());

        // Verificar que b no sea 0 para evitar división por cero
        if (b != 0)
        {
            // Realizar la división y asignar el resultado a una variable entera
            int resultado = (int)(a / b);  // Convertir a entero (trunca la parte decimal)

            // Mostrar el resultado
            Console.WriteLine($"El resultado entero de la división a/b es: {resultado}");
        }
        else
        {
            Console.WriteLine("Error: División por cero no permitida.");
        }
    }
}
