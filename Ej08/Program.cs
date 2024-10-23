using System;

class Program
{
    static void Main()
    {
        bool continuar = true;
        double menor = 0;
        double mayor = 0;
        while (continuar)
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese un numero:");
            string entrada = Console.ReadLine();
            double numero;
            bool esDouble = double.TryParse(entrada, out numero);
            switch (esDouble)
            {
                case true:
                    if (numero < menor)
                    { menor = numero; }
                    if (numero > mayor)
                    { mayor = numero; }
                    break;
                case false:
                    if (entrada == "")
                    {
                        Console.WriteLine("El menor número ingresado es: " + menor);
                        Console.WriteLine("El mayor número ingresado es: " + mayor);
                        Console.WriteLine("");
                        Console.WriteLine("Saliendo del programa...");
                        continuar = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada incorrecta. " + entrada + " no es un numero!!");
                        Console.WriteLine("Debe ingresar un número.");
                        Console.ReadKey(true);
                        break;
                    }
                default:
                    break;
            }
        }
    }
}