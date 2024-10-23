class Program
{
    static void Main()
    {
        bool continuar = true;
        int login;
        int password;
        int check_log;
        int check_pass;
        int intentos = 0;
        Console.Write("Ingrese su login (entero): ");
        string entrada_log = Console.ReadLine();
        login = int.Parse(entrada_log);
        Console.Write("Ingrese su password (entero): ");
        string entrada_pass = Console.ReadLine();
        password = int.Parse(entrada_pass);

        while (intentos < 3 && continuar)
        {
            Console.Write("Ingrese nuevamente su login (entero): ");
            check_log = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nuevamente su password (entero): ");
            check_pass = int.Parse(Console.ReadLine());
            bool test = (login == check_log && password == check_pass);
            switch (test)
            {
                case true:
                    continuar = false;
                    break;
                case false:
                    intentos++;
                    Console.Write("");
                    Console.Write("Login o password incorrectos");
                    Console.Write("Intentos restantes: " + intentos);
                    Console.Write("");
                    Console.ReadKey(true);
                    break;
            }

        }
        if (intentos >= 3)
        {
            Console.Write("No quedan más intentos!! Borrando datos....");
            Console.ReadKey(true);
        }
        if (intentos < 3)
        {
            Console.Write("Gracias. cerrando programa....");
            Console.ReadKey(true);
        }
    }
}