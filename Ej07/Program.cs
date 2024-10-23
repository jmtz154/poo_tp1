using System;
class Program
{
    static void Main()
    {
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese un texto:");
            string entrada = Console.ReadLine();
            switch (entrada)
            {
                case "":
                    Console.WriteLine("Saliendo del programa...");
                    continuar = false;
                    Console.ReadKey(true);
                    break;
                default:
                    int contador = 0;
                    foreach (char c in entrada)
                    { contador++; }
                    Console.WriteLine("Longitud: " + contador);
                    break;
            }
        }
    }
}