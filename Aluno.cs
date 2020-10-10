using System;
using System.Collections.Generic;
using System.Text;

namespace AlunoIsmai
{
    class Aluno
    {
        private string _nome, _curso;
        private int _numero, _ano;
        public Aluno(string nome, string curso, int numero, int ano) //Dá override a qualquer Get Set, certo? Que adianta ter as variaveis privadas se podem ser adulteradas assim?
        {
            this._nome = nome;
            this._curso = curso;
            this._numero = numero;
            this._ano = ano;
        }
        public override string ToString() //Só dá para fazer assim? Não dá como em baixo, onde faço o CW no método sem ter de repetir código? Eu sei que posso fazer CW na mesma aqui, mas ia ter um o CW e o Return com código repetido...
        {
            return _nome + " " + _numero + " " + _ano + "ºano " + _curso;
        }
        public void PrimeiroUltimoNome()
        {
            string[] primeiroUltimo = _nome.Split(' '); //Criei o array só para facilitar a leitura.
            Console.WriteLine(primeiroUltimo[0] + " " + primeiroUltimo[primeiroUltimo.Length - 1]);
        }
        public bool InscritoAntes(Aluno a1, Aluno a2) //Consegui isto completamente ao calhas, só na tentativa erro. MIND BLOWN.
        {
            return a1._numero < a2._numero ? true : false;
        }
    }
}
