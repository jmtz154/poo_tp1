using System;

class Program
{
    static void Main()
    {
        Console.Write("Precio: ");
        int precio = int.Parse(Console.ReadLine());
        Console.Write("Pago: ");
        int pago = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int vuelto = pago - precio;
        //
        if (vuelto < 0)
        {
            Console.WriteLine("El pago es insuficiente.");
            return;
        }
        //
        Console.WriteLine($"Cambio a devolver: ${vuelto}");
        Console.WriteLine();
        int index = 0;
        int billetes;
        while (vuelto > 0)
        {
            switch (index)
            {
                case 0: // 100
                    billetes = vuelto / 100;
                    if (billetes > 0)
                    {
                        Console.WriteLine($"Billetes de $100: {billetes}");
                    }
                    vuelto = vuelto % 100;
                    break;
                case 1: // 50
                    billetes = vuelto / 50;
                    if (billetes > 0)
                    {
                        Console.WriteLine($"Billetes de $50: {billetes}");
                    }
                    vuelto = vuelto % 50;
                    break;
                case 2: // 20
                    billetes = vuelto / 20;
                    if (billetes > 0)
                    {
                        Console.WriteLine($"Billetes de $20: {billetes}");
                    }
                    vuelto = vuelto % 20;
                    break;
                case 3: // 10
                    billetes = vuelto / 10;
                    if (billetes > 0)
                    {
                        Console.WriteLine($"Billetes de $10: {billetes}");
                    }
                    vuelto = vuelto % 10;
                    break;
                case 4: // 5
                    billetes = vuelto / 5;
                    if (billetes > 0)
                    {
                        Console.WriteLine($"Billetes de $5: {billetes}");
                    }
                    vuelto = vuelto % 5;
                    break;
                case 5: // 2
                    billetes = vuelto / 2;
                    if (billetes > 0)
                    {
                        Console.WriteLine($"Billetes de $2: {billetes}");
                    }
                    vuelto = vuelto % 2;
                    break;
                case 6: // 1
                    billetes = vuelto / 1;
                    if (billetes > 0)
                    {
                        Console.WriteLine($"Billetes de $1: {billetes}");
                    }
                    vuelto = 0;
                    break;
                default:
                    Console.WriteLine("Error: Denominación no reconocida");
                    return;
            }
            index++;
        }
    }
}