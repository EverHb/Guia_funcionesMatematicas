using System;

public class ejercicio 
{
    public static void Main()
    {
        double number = Math.PI;
        Console.WriteLine("Valor truncado:" + Math.Truncate(number));
        Console.WriteLine("Valor redondeado hacia arriba:"+ Math.Ceiling(number));
        Console.WriteLine("Valor redondeado hacia abajo:" + Math.Floor(number));
       
    }

}
