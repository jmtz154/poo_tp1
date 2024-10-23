using System;

class Program
{
    static void Main()
    {
        bool continuar = true;
        int total = 0;
        int numero;

        while (continuar)
        {
            // Mostrar el menú de opciones
            Console.WriteLine("");
            Console.Write("\tNúmero? ");
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out numero);

            switch (numero)
            {
                case 0:
                    // Salir.
                    Console.WriteLine("Saliendo del programa...");
                    continuar = false;
                    break;

                default:
                    total += numero;
                    Console.WriteLine("\tTotal: " + total);
                    break;
            }
        }
    }
}