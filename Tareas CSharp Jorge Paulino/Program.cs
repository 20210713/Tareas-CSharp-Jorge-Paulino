using System;

namespace Tareas_CSharp_Jorge_Paulino
{
    class Program
    {
        //Calcular 5 figura geometricas
        static void Main(string[] args)
        {
            float a, b, h;

            //Cuadrado
            Console.WriteLine("Escriba el lado del Cuadrado");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine($"El area del Cuadrado es: {a*a}");

            //Rectangulo
            Console.WriteLine("Escriba la base del Rectangulo");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la altura del Rectangulo");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine($"El area del Rectangulo es: {a * b}");

            //Triangulo
            Console.WriteLine("Escriba la base del Triagulo");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la altura del Triangulo");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine($"El area del Triangulo es: {(a * b)/2}");

            //Circulo
            Console.WriteLine("Escriba el radio del Circulo");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine($"El diametro del Circulo es: {2*a}");

            //Trapezio
            Console.WriteLine("Escriba la base mayor del Trapezio");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la base menor del Trapezio");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la altura del Trapecio");
            h = float.Parse(Console.ReadLine());
            Console.WriteLine($"El area del Trapezio es: {h*((a + b) / 2)}");
        }
    }
}
