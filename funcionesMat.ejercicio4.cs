using System;

class Ejercicio4
{
    static void Main()
    {
        double a, b, c;

        Console.Write("Ingrese el valor de a: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de b: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor de c: ");
        c = Convert.ToDouble(Console.ReadLine());

        double discriminante = b * b - 4 * a * c;

        if (discriminante > 0)
        {
            double raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            double raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            Console.WriteLine($"Las raíces son: {raiz1} y {raiz2}");
        }
        else if (discriminante == 0)
        {
            double raiz = -b / (2 * a);
            Console.WriteLine($"La raíz es: {raiz}");
        }
        else
        {
            double parteReal = -b / (2 * a);
            double parteImaginaria = Math.Sqrt(Math.Abs(discriminante)) / (2 * a);
            Console.WriteLine($"Las raíces son complejas: {parteReal} + {parteImaginaria}i y {parteReal} - {parteImaginaria}i");
        }
    }
}




