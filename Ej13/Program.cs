class Program
{
    static void Main()
    {
        bool continuar = true;
        bool test;
        bool positivo;
        int numero;
        int contador;
        while (continuar)
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese un numero ENTERO positivo:");
            string entrada = Console.ReadLine();
            test = int.TryParse(entrada, out numero);
            positivo = numero >= 0;
            if (test)
            {
                switch (positivo)
                {
                    case true:
                        contador = 0;
                        foreach (char c in entrada)
                        { contador++; }
                        Console.WriteLine("Longitud: " + contador);
                        break;
                    case false:
                        contador = -1;
                        foreach (char c in entrada)
                        { contador++; }
                        Console.WriteLine("ADEVERTENCIA. Es un numero negativo");
                        Console.WriteLine("Longitud: " + contador);
                        break;
                }
            }
            else
            {
                Console.WriteLine("Saliendo del programa...");
                continuar = false;
                Console.ReadKey(true);
            }
        }
    }
}
