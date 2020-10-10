using System;
using System.Collections.Generic;
using System.Text;

namespace Retangulo
{
    class Retangulo
    {
        private float _largura, _comprimento;
        public Retangulo()
        {
            _largura = 0;
            _comprimento = 0;
        }
        public Retangulo(float largura, float comprimento)
        {
            this._largura = largura;
            this._comprimento = comprimento;
        }

        public float largura
        {
            get { return _largura; }
            set
            {
                if (value > 20)
                {
                    _largura = 20;
                }
                else
                {
                    _largura = value;
                }
            }
        }

        public float comprimento
        {
            get { return _comprimento; }
            set
            {
                if (value > 20)
                {
                    _comprimento = 20;
                }
                else
                {
                    _comprimento = value;
                }
            }
        }
        /*
        public float GetLargura()
        {
            return largura;
        }
        public void SetLargura(float largura)
        {
            this.largura = largura;
        }
        public float GetComprimento()
        {
            return comprimento;
        }
        public void SetComprimento(float comprimento)
        {
            this.comprimento = comprimento;
        }
        */
        public float Area()
        {
            Console.WriteLine(_largura * _comprimento);
            return _largura * _comprimento;
        }

        public bool Quadrado()
        {
            if (_largura == _comprimento)
            {
                Console.WriteLine("É um quadrado");
                return true;
            }
            else
            {
                Console.WriteLine("Não é um quadrado");
                return false;
            }
        }

        public string ToString()
        {
            Console.WriteLine("O retangulo mede: " + _largura + "cm * " + _comprimento + "cm.");
            return "";
        }
    }
}
