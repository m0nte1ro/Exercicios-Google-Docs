using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Insira uma largura: ");
            r.largura=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insira um comprimento: ");
            r.comprimento=Int32.Parse(Console.ReadLine());

            r.Area();
            r.Quadrado();
            r.ToString();
        }
    }
}
