﻿using System;


class Program
{
    static void Main()
    {
        int precio, pago, cambio;
        int[] cantidadBilletes = new int[7]; // Para almacenar la cantidad de cada billete

        Console.Write("Ingrese el precio del producto: ");
        precio = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el monto pagado: ");
        pago = int.Parse(Console.ReadLine());

        cambio = pago - precio;

        if (cambio < 0)
        {
            Console.WriteLine("El pago es insuficiente.");
            return;
        }

        Console.WriteLine($"Cambio a devolver: {cambio}");

        int index = 0;
        while (cambio > 0)
        {
            switch (index)
            {
                case 0: // 100
                    cantidadBilletes[index] = cambio / 100;
                    cambio %= 100; // equivalente a: cambio = cambio % 100;
                    break;
                case 1: // 50
                    cantidadBilletes[index] = cambio / 50;
                    cambio %= 50; // equivalente a: cambio = cambio % 50;
                    break;
                case 2: // 20
                    cantidadBilletes[index] = cambio / 20;
                    cambio %= 20;
                    break;
                case 3: // 10
                    cantidadBilletes[index] = cambio / 10;
                    cambio %= 10;
                    break;
                case 4: // 5
                    cantidadBilletes[index] = cambio / 5;
                    cambio %= 5;
                    break;
                case 5: // 2
                    cantidadBilletes[index] = cambio / 2;
                    cambio %= 2;
                    break;
                case 6: // 1
                    cantidadBilletes[index] = cambio;
                    cambio = 0;
                    break;
                default:
                    Console.WriteLine("Error: Denominación no reconocida");
                    return;
            }
            index++;
        }

        string[] denominaciones = { "100", "50", "20", "10", "5", "2", "1" };
        for (int i = 0; i < cantidadBilletes.Length; i++)
        {
            if (cantidadBilletes[i] > 0)
            {
                Console.WriteLine($"Billetes de {denominaciones[i]}: {cantidadBilletes[i]}");
            }
        }
    }
}