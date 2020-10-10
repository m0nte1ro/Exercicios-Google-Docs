using System;
using System.Collections.Generic;
using System.Text;

namespace Paralelepipedo
{
    class Paralelos
    {
        private int _altura;
        private int _largura;
        private int _comprimento;
        public Paralelos()
        {
            _altura = 0;
            _largura = 0;
            _comprimento = 0;
        }
        public Paralelos(int altura, int largura, int comprimento)
        {
            this._altura = altura;
            this._largura = largura;
            this._comprimento = comprimento;
        }
        public Paralelos(int valor)
        {
            this._altura = valor;
            this._largura = valor;
            this._comprimento = valor;
        }
        public int altura { get { return _altura; } set { if (value < 0) _altura = 0; else _altura = value; } }
        public int largura { get { return _largura; } set { if (value < 0) _largura = 0; else _largura = value; } }
        public int comprimento { get { return _comprimento; } set { if (value < 0) _comprimento = 0; else _comprimento = value; } }
        public int Volume()
        {
            return altura * largura * comprimento;
        }
        public int Area()
        {
            return 2*(altura*largura + altura*comprimento + largura*comprimento);
        }
        public bool IsACube()
        {
            return (altura == largura && largura == comprimento) ?  true : false;
        }
        public bool Is3D()
        {
            return (altura > 0 && largura > 0 && comprimento > 0) ? true : false;
        }
        public override string ToString()
        {
            return "Altura= " + altura + "; Largura= " + largura + "; Comprimento= " + comprimento;
        }
    }
}
