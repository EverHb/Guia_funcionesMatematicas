using System;

public class Ejercicio3
{
    static void Main()
    {
        double number = 0;

        for (int numero = 1; numero <= 20; numero++)
        {
            
            number += Math.Pow(numero, 2);
        }

        Console.WriteLine("La suma acumulada de los cuadrados es: " + number);
    }
}


