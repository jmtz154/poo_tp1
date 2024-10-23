using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            // Mostrar el menú de opciones
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Multiplicar");
            Console.WriteLine("2. Dividir");
            Console.WriteLine("3. Salir");
            Console.Write("Elige una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Multiplicar
                    Console.Write("Ingresa el primer número entero: ");
                    int numero1 = int.Parse(Console.ReadLine());

                    if (numero1 != 0)
                    {
                        Console.Write("Ingresa el segundo número entero: ");
                        int numero2 = int.Parse(Console.ReadLine());
                        int producto = numero1 * numero2;
                        Console.WriteLine("");
                        Console.WriteLine("El resultado de la multiplicación es: " + producto);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("El resultado de la multiplicación es: 0");
                    }
                    break;

                case 2:
                    // Dividir
                    Console.Write("Ingresa el primer número entero: ");
                    int dividendo = int.Parse(Console.ReadLine());
                    Console.Write("Ingresa el segundo número entero: ");
                    int divisor = int.Parse(Console.ReadLine());

                    if (divisor != 0)
                    {
                        int cociente = dividendo / divisor;
                        Console.WriteLine("");
                        Console.WriteLine("El resultado de la división es: " + cociente);
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("No puedo dividir por cero!.");
                    }
                    break;

                case 3:
                    // Salir.
                    Console.WriteLine("Saliendo del programa...");
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("");
                    Console.WriteLine(">> Opción no válida <<");
                    Console.WriteLine("Intente de nuevo e ingrse un número del 1 al 3...");
                    break;
            }
        }
    }
}