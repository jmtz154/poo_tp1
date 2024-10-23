using System;

class Program
{
    static void Main()
    {
        bool continuar = true;
        double total = 0;
        double numero = 9;

        while (continuar)
        {
            Console.WriteLine("");
            Console.Write("\tNúmero? ");
            string entrada = Console.ReadLine();
            bool esDouble = double.TryParse(entrada, out numero); // guarda "true" o "false" en "esDouble" si "entrada" es convertible a double o no.
            switch (esDouble)
            {
                case true:
                    if (numero == 0)
                    {
                        // Salir.
                        Console.WriteLine("Saliendo del programa...");
                        continuar = false;
                        Console.ReadKey(true);
                        break;
                    }
                    else
                    {
                        //Sumar.
                        total += numero;
                        Console.WriteLine("\tTotal: " + total);
                        break;
                    }

                case false:
                    // ERROR.
                    Console.WriteLine("Ingrese un número para poder sumar!!");
                    Console.ReadKey(true);
                    break;
                default:
                    break;

            }
        }
    }
}