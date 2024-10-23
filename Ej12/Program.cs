using System;

class Program
{
    static void Main()
    {
        // Bucle para iterar desde 10 hasta 20, incrementando de 2 en 2
        for (int i = 10; i <= 20; i += 2)
        {
            // Si el número es 16, saltarlo usando "continue"
            if (i == 16)
            {
                continue; // Salta el resto del código del ciclo y pasa al siguiente número
            }

            // Imprimir el número par
            Console.WriteLine(i);
        }
        Console.ReadKey(true);
    }
}