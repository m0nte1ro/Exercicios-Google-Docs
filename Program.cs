using System;

namespace Paralelepipedo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Paralelos a = new Paralelos();
            a.altura = random.Next(0, 20);
            a.largura = random.Next(0, 20);
            a.comprimento = random.Next(0, 20);
            Console.WriteLine(a.Volume());
            Console.WriteLine(a.Area());
            Console.WriteLine(a.IsACube());
            Console.WriteLine(a.Is3D());
            Console.WriteLine(a.ToString());
        }
    }
}
