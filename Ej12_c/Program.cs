using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 10; ; i += 2)
        {
            if (i > 20)
            {
                break; // Rompe el ciclo cuando el número es mayor a 20
            }
            if (i == 16)
            {
                continue; // Salta el resto del ciclo para este valor y pasa al siguiente
            }
            Console.WriteLine(i);
        }
        Console.ReadKey(true); // Espera que se presione alguna tecla para continuar
    }
}