using System;

class Program
{
    static void Main()
    {
        // int numero; // Use of unassigned local variable 'numero' en el while
        int numero = -1;  // Use of unassigned local variable 'numero' en el while

        while (numero != 0) // El bucle termina si el número ingresado es 0
        {
            // Solicitar un número entero al usuario
            Console.Write("Ingrese un número entero (0 para terminar): ");
            numero = int.Parse(Console.ReadLine());

            // Si el número es diferente de 0, se muestra en hexadecimal y binario
            if (numero != 0)
            {
                string hexadecimal = numero.ToString("X");  // Convertir a hexadecimal
                string binario = Convert.ToString(numero, 2); // Convertir a binario

                Console.WriteLine($"Número en hexadecimal: {hexadecimal}");
                Console.WriteLine($"Número en binario: {binario}\n");
            }

        }

        Console.WriteLine("Programa terminado.");
    }
}