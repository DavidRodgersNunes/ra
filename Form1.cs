using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoFernando.Modelo;
using static System.Net.Mime.MediaTypeNames;

namespace TrabalhoFernando
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public void validar()
        {
            Controle controle = new Controle(txbNome.Text, txbIdade.Text);
            lblErro.Text = controle.Resultado;
        }
        public void aluno()
        {
            Aluno aluno = new Aluno();
            lblAluno.Text = aluno.RA1;
        }
          
        private void txbRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.validar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Aluno();
        }

        private void lblMatricula_Click(object sender, EventArgs e)
        {

        }

        private void lblErro_Click(object sender, EventArgs e)
        {

        }
    }
}
