using System;

namespace Rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la altura del rectángulo");
            string linea = Console.ReadLine();
            int altura = int.Parse(linea);

            Console.WriteLine("Ingrese la base del rectángulo");
            linea = Console.ReadLine();
            int base1 = int.Parse(linea);

            int area = base1 * altura;
            Console.WriteLine("El área del rectángulo es:");
            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}