using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFernando.Modelo
{
    internal class Controle
    {
        private string ra;
        private string nome;
        private string idade;
        private string resultado;
        private string erro;
        private int idadei;

        public string Resultado { get => resultado; }
        public string Erro { get => erro;}

        public Controle(string nome, string idade)
        {
            this.nome = nome;
            this.idade = idade;
            Validacao validacao = new Validacao(nome, idade);
            resultado = validacao.Erro;
        }

    }
}
