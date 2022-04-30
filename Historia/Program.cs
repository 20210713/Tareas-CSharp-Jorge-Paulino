using System;

namespace Historia
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal, profesion, nombre, tela, cosa, lugar, verbo, comida;
            
            Console.WriteLine("Escribe un nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Escribe una profesion: ");
            profesion = Console.ReadLine();

            Console.WriteLine("Escribe una comida: ");
            comida = Console.ReadLine();

            Console.WriteLine("Escribe un tipo de tela: ");
            tela = Console.ReadLine();

            Console.WriteLine("Escribe el nombre de un lugar: ");
            lugar = Console.ReadLine();

            Console.WriteLine("Escribe el nombre de una cosa: ");
            cosa = Console.ReadLine();

            Console.WriteLine("Escribe un verbo: ");
            verbo = Console.ReadLine();
            Console.WriteLine("Escriba el nombre de un animal: ");
            animal = Console.ReadLine();

            Console.WriteLine("di "+comida +", dijo el fotógrafo mientras la cámara destellaba! " +nombre + " y había ido a " +lugar +" para tomarnos fotos en mi cumpleaños. La primera foto que realmente queríamos era una foto de nosotros vestidos como "+animal +" fingiendo ser una "+profesion +". cuando vimos la segunda foto, era exactamente lo que quería. Ambos parecíamos " +cosa + " vistiendo " +tela + " y " +verbo + " --exactamente lo que tenía en mente");

            }
    }
}
