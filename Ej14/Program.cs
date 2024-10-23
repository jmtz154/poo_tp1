using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un simbolo:");
        string simbolo = Console.ReadLine();
        Console.WriteLine("Ingrese la longitud del lado:");
        int lado = int.Parse(Console.ReadLine());
        // Dibuja el cuadrado
        for (int j = 0; j < lado; j++)  // Loop externo: cambia la posicion j (j = coord. vertical)
        {
            for (int i = 0; i < lado; i++)  // Loop interno: imprime la fila j barriendo las posiciones i (i = coord.horizontal)
            {            
                if (j == 0 || j == lado - 1 || i == 0 || i == lado - 1) // Imprime las "X" o los " " segun la posicion i en la fila.
                {
                    Console.Write(simbolo); //NOTA: se usa Console.Write() porque no cambia de linea lugo de escribir como sí lo hace Console.ReadLine().
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();    // Nueva línea después de cada fila
        }
    }
}