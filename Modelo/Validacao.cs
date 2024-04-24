using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoFernando.Modelo
{
    internal class Validacao
    {
        private string nome;
        private string idade;
        private int idadei;
        private string erro;

        public string Nome { get => nome; }
        public int Idadei { get => idadei; }
        public string Erro { get => erro; }
        public string Idade { get => idade; set => idade = value; }

        public Validacao(string nome, string idade)
        {
            this.nome = nome;
            this.Idade = idade;
            this.Validar(nome, idade);
        }

        private void Validar(string nome, string idade)
        {
            erro = "Salvo com sucesso";

            try
            {
                
                this.idadei = Convert.ToInt32(idade);
                string pattern = @"[^\w\s]"; // Identifica qualquer caractere que não seja alfanumérico

                if (Regex.IsMatch(nome, pattern))
                {
                    this.erro = "O nome não pode conter caracteres especiais.";
                }

                else if (this.idadei < 1 || this.idadei > 120)
                {
                    erro = "Digite uma idade entre 18 a 120 anos";
                }

            }
            catch
            {
                erro = "Preencha os campos com valores validos";
            }
        }

    }
    
}
