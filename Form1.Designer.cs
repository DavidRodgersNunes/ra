namespace TrabalhoFernando
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblMostraAluno = new System.Windows.Forms.Label();
            this.lblReceber = new System.Windows.Forms.Label();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.lblMostraIdade = new System.Windows.Forms.Label();
            this.lblMostraMatricula = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblIdd = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(23, 168);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblMostraAluno
            // 
            this.lblMostraAluno.AutoSize = true;
            this.lblMostraAluno.Location = new System.Drawing.Point(275, 56);
            this.lblMostraAluno.Name = "lblMostraAluno";
            this.lblMostraAluno.Size = new System.Drawing.Size(40, 13);
            this.lblMostraAluno.TabIndex = 3;
            this.lblMostraAluno.Text = "Aluno -";
            // 
            // lblReceber
            // 
            this.lblReceber.AutoSize = true;
            this.lblReceber.Location = new System.Drawing.Point(33, 20);
            this.lblReceber.Name = "lblReceber";
            this.lblReceber.Size = new System.Drawing.Size(82, 13);
            this.lblReceber.TabIndex = 4;
            this.lblReceber.Text = "Receber Dados";
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(275, 20);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(76, 13);
            this.lblMostrar.TabIndex = 5;
            this.lblMostrar.Text = "Mostrar Dados";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(20, 55);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(20, 83);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 7;
            this.lblIdade.Text = "Idade";
            this.lblIdade.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(60, 53);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(120, 20);
            this.txbNome.TabIndex = 8;
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(60, 80);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(121, 20);
            this.txbIdade.TabIndex = 9;
            // 
            // lblMostraIdade
            // 
            this.lblMostraIdade.AutoSize = true;
            this.lblMostraIdade.Location = new System.Drawing.Point(275, 83);
            this.lblMostraIdade.Name = "lblMostraIdade";
            this.lblMostraIdade.Size = new System.Drawing.Size(40, 13);
            this.lblMostraIdade.TabIndex = 10;
            this.lblMostraIdade.Text = "Idade -";
            // 
            // lblMostraMatricula
            // 
            this.lblMostraMatricula.AutoSize = true;
            this.lblMostraMatricula.Location = new System.Drawing.Point(275, 111);
            this.lblMostraMatricula.Name = "lblMostraMatricula";
            this.lblMostraMatricula.Size = new System.Drawing.Size(40, 13);
            this.lblMostraMatricula.TabIndex = 11;
            this.lblMostraMatricula.Text = "RA     -";
            this.lblMostraMatricula.Click += new System.EventHandler(this.lblMatricula_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(276, 168);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(322, 55);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(0, 13);
            this.lblAluno.TabIndex = 13;
            // 
            // lblIdd
            // 
            this.lblIdd.AutoSize = true;
            this.lblIdd.Location = new System.Drawing.Point(322, 83);
            this.lblIdd.Name = "lblIdd";
            this.lblIdd.Size = new System.Drawing.Size(0, 13);
            this.lblIdd.TabIndex = 14;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(322, 111);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(0, 13);
            this.lblMatricula.TabIndex = 15;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(370, 173);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(73, 13);
            this.lblErro.TabIndex = 16;
            this.lblErro.Text = "......................";
            this.lblErro.Click += new System.EventHandler(this.lblErro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 567);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblIdd);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblMostraMatricula);
            this.Controls.Add(this.lblMostraIdade);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.lblReceber);
            this.Controls.Add(this.lblMostraAluno);
            this.Controls.Add(this.btnSalvar);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblMostraAluno;
        private System.Windows.Forms.Label lblReceber;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.Label lblMostraIdade;
        private System.Windows.Forms.Label lblMostraMatricula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblIdd;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblErro;
    }
}

