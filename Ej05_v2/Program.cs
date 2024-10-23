using System;

class Program
{
    static void Main()
    {
        bool continuar = true;
        int opcion = 0;

        while (continuar)
        {
            // Mostrar el menú de opciones
            Console.WriteLine("");
            Console.WriteLine("\t Menú:");
            Console.WriteLine("\t  1. Multiplicar");
            Console.WriteLine("\t  2. Dividir");
            Console.WriteLine("\t  3. Salir");
            Console.Write("\t  Elige una opción: ");
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out opcion); // El método int.TryParse() intenta convertir la entrada a un entero y devuelve "True" si la conversión es exitosa, o "False" si falla.
                                               // int.TryParse() toma valor True o False (somo si fuera una variable). Si es True la conversion la guarda en "opcion", si es False no guarda nada.

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
                    Console.WriteLine("Intente de nuevo e ingrse un número ENTERO del 1 al 3...");
                    break;
            }
        }
    }
}