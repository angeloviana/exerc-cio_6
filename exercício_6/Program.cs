using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c, Triangulo, Circulo, Trapezio, Quadrado, Retangulo;
        double Pi = 3.14159;

        Console.WriteLine("Digite 3 valores: \n");
        string[] Valores = Console.ReadLine().Split(' ');
        a = double.Parse(Valores[0], CultureInfo.InvariantCulture);
        b = double.Parse(Valores[1], CultureInfo.InvariantCulture);
        c = double.Parse(Valores[2], CultureInfo.InvariantCulture);

        Triangulo = (a * c) / 2;
        Circulo = Pi * Math.Pow(c , 2);
        Trapezio = ((a + b) * c) / 2;
        Quadrado = Math.Pow(b, 2);
        Retangulo = a * b;

        Console.WriteLine("Triangulo: " + Triangulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("Circulo: " + Circulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("Trapezio: " + Trapezio.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("Quadrado: " + Quadrado.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("Retangulo: " + Retangulo.ToString("F3", CultureInfo.InvariantCulture));
    }
}