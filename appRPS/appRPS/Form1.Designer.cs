namespace appRPS
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbEscolha = new System.Windows.Forms.ComboBox();
            this.btnComecar = new System.Windows.Forms.Button();
            this.ltbListJogador = new System.Windows.Forms.ListBox();
            this.rbtDuelo = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtTorneio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.ltbPrompt = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ttbNome
            // 
            this.ttbNome.Location = new System.Drawing.Point(8, 31);
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(105, 20);
            this.ttbNome.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(248, 31);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jogador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jogada";
            // 
            // cbbEscolha
            // 
            this.cbbEscolha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEscolha.FormattingEnabled = true;
            this.cbbEscolha.Location = new System.Drawing.Point(128, 31);
            this.cbbEscolha.Name = "cbbEscolha";
            this.cbbEscolha.Size = new System.Drawing.Size(107, 21);
            this.cbbEscolha.TabIndex = 5;
            // 
            // btnComecar
            // 
            this.btnComecar.Location = new System.Drawing.Point(8, 131);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(83, 44);
            this.btnComecar.TabIndex = 8;
            this.btnComecar.Text = "Começar";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // ltbListJogador
            // 
            this.ltbListJogador.FormattingEnabled = true;
            this.ltbListJogador.Location = new System.Drawing.Point(114, 58);
            this.ltbListJogador.Name = "ltbListJogador";
            this.ltbListJogador.Size = new System.Drawing.Size(128, 121);
            this.ltbListJogador.TabIndex = 9;
            // 
            // rbtDuelo
            // 
            this.rbtDuelo.AutoSize = true;
            this.rbtDuelo.Location = new System.Drawing.Point(3, 11);
            this.rbtDuelo.Name = "rbtDuelo";
            this.rbtDuelo.Size = new System.Drawing.Size(53, 17);
            this.rbtDuelo.TabIndex = 10;
            this.rbtDuelo.TabStop = true;
            this.rbtDuelo.Text = "Duelo";
            this.rbtDuelo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtTorneio);
            this.panel1.Controls.Add(this.rbtDuelo);
            this.panel1.Location = new System.Drawing.Point(8, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 68);
            this.panel1.TabIndex = 11;
            // 
            // rbtTorneio
            // 
            this.rbtTorneio.AutoSize = true;
            this.rbtTorneio.Location = new System.Drawing.Point(4, 34);
            this.rbtTorneio.Name = "rbtTorneio";
            this.rbtTorneio.Size = new System.Drawing.Size(61, 17);
            this.rbtTorneio.TabIndex = 11;
            this.rbtTorneio.TabStop = true;
            this.rbtTorneio.Text = "Torneio";
            this.rbtTorneio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Limpar a Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ltbPrompt
            // 
            this.ltbPrompt.FormattingEnabled = true;
            this.ltbPrompt.Location = new System.Drawing.Point(12, 214);
            this.ltbPrompt.Name = "ltbPrompt";
            this.ltbPrompt.Size = new System.Drawing.Size(310, 199);
            this.ltbPrompt.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Saída das Chaves";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(335, 425);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ltbPrompt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ltbListJogador);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.cbbEscolha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.ttbNome);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPS - Rock, Paper, Scissors";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ttbNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbEscolha;
        private System.Windows.Forms.Button btnComecar;
        private System.Windows.Forms.ListBox ltbListJogador;
        private System.Windows.Forms.RadioButton rbtDuelo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtTorneio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ltbPrompt;
        private System.Windows.Forms.Label label3;
    }
}

