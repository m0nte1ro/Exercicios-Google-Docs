using System;
using System.Collections.Generic;
using System.Text;

namespace Disciplina
{
    class Disciplina
    {
        private string _nomeDis, _nomeDoc, _nomeCur;
        private int _cargaHor, _numAlunos;
        private bool _semestral, _anual;
        public Disciplina()
        {
            _nomeDis = "";
            _nomeDoc = "";
            _nomeCur = "";
            _cargaHor = 0;
            _numAlunos = 0;
            _semestral = false;
            _anual = false;
        }
        public Disciplina(string nomeDisc, string nomeDoc, string nomeCur, int cargaHor, int numAlunos, bool semestral, bool anual)//Para quê isto? Porque não usar os GET SET embaixo em vez disto? Se existe para quê usar variaveis privadas de todo?
        {
            this._nomeDis = nomeDisc;
            this._nomeDoc = nomeDoc;
            this._nomeCur = nomeCur;
            this._cargaHor = cargaHor;
            this._numAlunos = numAlunos;
            this._semestral = semestral;
            this._anual = anual;
        }
        public string nomeDisc { get { return _nomeDis; } set { _nomeDis = value; } }
        public string nomeDoc { get { return _nomeDoc; } set { _nomeDoc = value; } }
        public string nomeCur { get { return _nomeCur; } set { if (value.ToLower() == "djd" || value.ToLower() == "artes" || value.ToLower() == "tcm") _nomeCur = value; else _nomeCur = "NDF"; } }
        public int cargaHor { get { return _cargaHor; } set { if (value > 0 && value < 8) _cargaHor = value; if (value < 0) value = -value; if (value > 8) _cargaHor = 8; else _cargaHor = value;  } }
        public int numAlunos { get { return _numAlunos; } set { if (value < 0) _numAlunos = -value; else _numAlunos = value; } }
        public bool semestral { get { return _semestral; } set { if (_anual == true) _semestral = false; else _semestral = value; } }
        public bool anual { get { return _anual; } set { if (_semestral == true) _anual = false; else _anual = value; } }
        public override string ToString()
        {
            return "Disciplina: " + _nomeDis + ".\nDocente: " + _nomeDoc + ".\nCurso: " + _nomeCur;
        }
        public void cargaHorariaGlobal()
        {
            Console.WriteLine("Carga horária global: " + _cargaHor * 15 + " horas.");
        }
        public void informacaoCompleta()
        {
            Console.WriteLine("Disciplina: " + _nomeDis + ".\nDocente: " + _nomeDoc + ".\nCurso: " + _nomeCur + ".\nCarga horária semanal: " + _cargaHor + ".\nNúmero de alunos: " + _numAlunos + ".\nSemestral: " + _semestral + ".\nAnual: " + _anual + ".");
        }
    }
}
