using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFernando.Modelo
{
    internal class Aluno:Pessoa
    {
        private string RA;
        private string digit;
        private string resdigit;

        public string RA1 { get => RA; set => RA = value; }

        public Aluno(string nome, int idadei, string idade) : base(nome, idade)
        {
            this.Alun(nome, idadei);
        }

        private void Alun(string nome, int idadei)
        {
            this.digit = nome.Substring(0, 2);
            this.resdigit = nome.Substring(2);
            this.RA1 = this.digit + idadei + this.resdigit;
        }
    }
}
