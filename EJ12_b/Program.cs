using System;

class Program
{
    static void Main()
    {
        // Bucle para iterar desde 10 hasta 20, incrementando de 1 en 1
        for (int i = 10; i <= 20; i += 1)
        {
            if (i == 16)
            {
                continue; // Salta el resto del código del ciclo y pasa al siguiente número
            }
            if (i % 2 == 0)  // Evalua si el nmumero i dividido por 2 tiene resto cero.
            {
                Console.WriteLine(i);
            }
            else
            {
                continue; // Salta el resto del código del ciclo y pasa al siguiente número
            }
        }
        Console.ReadKey(true);
    }
}