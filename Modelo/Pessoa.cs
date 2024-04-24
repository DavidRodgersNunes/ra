using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFernando.Modelo
{
    internal class Pessoa
    {
        private string nome;
        private int idadei;
        private string cocatenar;
        private string idade;

        public Pessoa(string nome, string idade)
        {
            Validacao validacao = new Validacao(nome, idade);
            nome = validacao.Nome;
            idade = validacao.Idade;
            this.Pess (nome, idade);
        }

        private void Pess(string nome,string idade)
        {
            this.cocatenar = this.nome + this.idadei;
        }
    }
}
