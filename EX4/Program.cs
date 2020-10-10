using System;

namespace Disciplina
{
    class Program
    {
        static void Main(string[] args)
        {
            //Disciplina a = new Disciplina("OOP", "Jaime Fins", "Artes", 9,13,true,false); <- Override a qualquer restrições. Estúpido, não sei o porquê de estar aqui...
            Disciplina a = new Disciplina();
            a.nomeDisc = "OOP";
            a.nomeDoc = "Jaime Fins";
            a.nomeCur = "Artes";
            a.cargaHor = 12;
            a.numAlunos = -17;
            a.semestral = true;
            a.anual = true;
            Console.WriteLine(a.ToString());
            a.cargaHorariaGlobal();
            a.informacaoCompleta();
        }
    }
}
