namespace wfaAnagrama
{
    partial class frmCadeado
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
            this.btnCalcule = new System.Windows.Forms.Button();
            this.lblSequenciaAberto = new System.Windows.Forms.Label();
            this.lstCadeado = new System.Windows.Forms.ListBox();
            this.txtSequenciaAberto = new System.Windows.Forms.TextBox();
            this.lblListaCompletaOpcoes = new System.Windows.Forms.Label();
            this.txtOpcoesLetras = new System.Windows.Forms.TextBox();
            this.lblOpcoesLetras = new System.Windows.Forms.Label();
            this.nudChavesSeletoras = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidadeChavesSeletoras = new System.Windows.Forms.Label();
            this.lblSeraAbertoEmLabel = new System.Windows.Forms.Label();
            this.lblSeraAbertoEm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudChavesSeletoras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcule
            // 
            this.btnCalcule.Location = new System.Drawing.Point(15, 184);
            this.btnCalcule.Name = "btnCalcule";
            this.btnCalcule.Size = new System.Drawing.Size(75, 23);
            this.btnCalcule.TabIndex = 8;
            this.btnCalcule.Text = "&Calcule";
            this.btnCalcule.UseVisualStyleBackColor = true;
            this.btnCalcule.Click += new System.EventHandler(this.btnCalcule_Click);
            // 
            // lblSequenciaAberto
            // 
            this.lblSequenciaAberto.AutoSize = true;
            this.lblSequenciaAberto.Location = new System.Drawing.Point(12, 50);
            this.lblSequenciaAberto.Name = "lblSequenciaAberto";
            this.lblSequenciaAberto.Size = new System.Drawing.Size(139, 13);
            this.lblSequenciaAberto.TabIndex = 0;
            this.lblSequenciaAberto.Text = "Sequência Aberto (espaço):";
            // 
            // lstCadeado
            // 
            this.lstCadeado.FormattingEnabled = true;
            this.lstCadeado.Location = new System.Drawing.Point(447, 38);
            this.lstCadeado.Name = "lstCadeado";
            this.lstCadeado.Size = new System.Drawing.Size(341, 524);
            this.lstCadeado.TabIndex = 10;
            // 
            // txtSequenciaAberto
            // 
            this.txtSequenciaAberto.Location = new System.Drawing.Point(157, 47);
            this.txtSequenciaAberto.Name = "txtSequenciaAberto";
            this.txtSequenciaAberto.Size = new System.Drawing.Size(261, 20);
            this.txtSequenciaAberto.TabIndex = 1;
            this.txtSequenciaAberto.Text = "A B A A B B A B A B";
            // 
            // lblListaCompletaOpcoes
            // 
            this.lblListaCompletaOpcoes.AutoSize = true;
            this.lblListaCompletaOpcoes.Location = new System.Drawing.Point(444, 13);
            this.lblListaCompletaOpcoes.Name = "lblListaCompletaOpcoes";
            this.lblListaCompletaOpcoes.Size = new System.Drawing.Size(134, 13);
            this.lblListaCompletaOpcoes.TabIndex = 9;
            this.lblListaCompletaOpcoes.Text = "Lista Completa de Opções:";
            // 
            // txtOpcoesLetras
            // 
            this.txtOpcoesLetras.Location = new System.Drawing.Point(157, 73);
            this.txtOpcoesLetras.Name = "txtOpcoesLetras";
            this.txtOpcoesLetras.Size = new System.Drawing.Size(261, 20);
            this.txtOpcoesLetras.TabIndex = 3;
            this.txtOpcoesLetras.Text = "A B";
            // 
            // lblOpcoesLetras
            // 
            this.lblOpcoesLetras.AutoSize = true;
            this.lblOpcoesLetras.Location = new System.Drawing.Point(12, 76);
            this.lblOpcoesLetras.Name = "lblOpcoesLetras";
            this.lblOpcoesLetras.Size = new System.Drawing.Size(138, 13);
            this.lblOpcoesLetras.TabIndex = 2;
            this.lblOpcoesLetras.Text = "Opções de Letras (espaço):";
            // 
            // nudChavesSeletoras
            // 
            this.nudChavesSeletoras.Location = new System.Drawing.Point(157, 99);
            this.nudChavesSeletoras.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudChavesSeletoras.Name = "nudChavesSeletoras";
            this.nudChavesSeletoras.Size = new System.Drawing.Size(74, 20);
            this.nudChavesSeletoras.TabIndex = 5;
            this.nudChavesSeletoras.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblQuantidadeChavesSeletoras
            // 
            this.lblQuantidadeChavesSeletoras.AutoSize = true;
            this.lblQuantidadeChavesSeletoras.Location = new System.Drawing.Point(12, 101);
            this.lblQuantidadeChavesSeletoras.Name = "lblQuantidadeChavesSeletoras";
            this.lblQuantidadeChavesSeletoras.Size = new System.Drawing.Size(119, 13);
            this.lblQuantidadeChavesSeletoras.TabIndex = 4;
            this.lblQuantidadeChavesSeletoras.Text = "QTD Chaves Seletoras:";
            // 
            // lblSeraAbertoEmLabel
            // 
            this.lblSeraAbertoEmLabel.AutoSize = true;
            this.lblSeraAbertoEmLabel.Location = new System.Drawing.Point(12, 127);
            this.lblSeraAbertoEmLabel.Name = "lblSeraAbertoEmLabel";
            this.lblSeraAbertoEmLabel.Size = new System.Drawing.Size(83, 13);
            this.lblSeraAbertoEmLabel.TabIndex = 6;
            this.lblSeraAbertoEmLabel.Text = "Será Aberto em:";
            // 
            // lblSeraAbertoEm
            // 
            this.lblSeraAbertoEm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeraAbertoEm.Location = new System.Drawing.Point(157, 127);
            this.lblSeraAbertoEm.Name = "lblSeraAbertoEm";
            this.lblSeraAbertoEm.Size = new System.Drawing.Size(261, 18);
            this.lblSeraAbertoEm.TabIndex = 7;
            // 
            // frmCadeado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 571);
            this.Controls.Add(this.lblSeraAbertoEm);
            this.Controls.Add(this.lblSeraAbertoEmLabel);
            this.Controls.Add(this.lblQuantidadeChavesSeletoras);
            this.Controls.Add(this.nudChavesSeletoras);
            this.Controls.Add(this.txtOpcoesLetras);
            this.Controls.Add(this.lblOpcoesLetras);
            this.Controls.Add(this.lblListaCompletaOpcoes);
            this.Controls.Add(this.txtSequenciaAberto);
            this.Controls.Add(this.lstCadeado);
            this.Controls.Add(this.lblSequenciaAberto);
            this.Controls.Add(this.btnCalcule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadeado";
            this.ShowIcon = false;
            this.Text = "CADEADO C#";
            ((System.ComponentModel.ISupportInitialize)(this.nudChavesSeletoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcule;
        private System.Windows.Forms.Label lblSequenciaAberto;
        private System.Windows.Forms.ListBox lstCadeado;
        private System.Windows.Forms.TextBox txtSequenciaAberto;
        private System.Windows.Forms.Label lblListaCompletaOpcoes;
        private System.Windows.Forms.TextBox txtOpcoesLetras;
        private System.Windows.Forms.Label lblOpcoesLetras;
        private System.Windows.Forms.NumericUpDown nudChavesSeletoras;
        private System.Windows.Forms.Label lblQuantidadeChavesSeletoras;
        private System.Windows.Forms.Label lblSeraAbertoEmLabel;
        private System.Windows.Forms.Label lblSeraAbertoEm;
    }
}

