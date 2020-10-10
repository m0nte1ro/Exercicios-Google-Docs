using System;

namespace AlunoIsmai
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno("Joao Feijão Grande Latão", "TIWM", 33683, 2);
            Aluno b = new Aluno("Ricardo Lindão Grande Morcão", "TIWM", 33682, 2);
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            a.PrimeiroUltimoNome();
            b.PrimeiroUltimoNome();
            Console.WriteLine("Aluno A inscrito antes de aluno B? " + a.InscritoAntes(a,b));
        }
    }
}
