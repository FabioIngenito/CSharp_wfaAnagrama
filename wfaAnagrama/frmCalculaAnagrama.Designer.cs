namespace wfaAnagrama
{
    partial class frmCalculaAnagrama
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
            this.lstAnagrama = new System.Windows.Forms.ListBox();
            this.lblDigitePalavra = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.btnCalculaAnagrama = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstAnagrama
            // 
            this.lstAnagrama.FormattingEnabled = true;
            this.lstAnagrama.Location = new System.Drawing.Point(103, 32);
            this.lstAnagrama.Name = "lstAnagrama";
            this.lstAnagrama.Size = new System.Drawing.Size(128, 472);
            this.lstAnagrama.TabIndex = 3;
            // 
            // lblDigitePalavra
            // 
            this.lblDigitePalavra.AutoSize = true;
            this.lblDigitePalavra.Location = new System.Drawing.Point(12, 9);
            this.lblDigitePalavra.Name = "lblDigitePalavra";
            this.lblDigitePalavra.Size = new System.Drawing.Size(85, 13);
            this.lblDigitePalavra.TabIndex = 0;
            this.lblDigitePalavra.Text = "Digite a Palavra:";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(103, 6);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(128, 20);
            this.txtPalavra.TabIndex = 1;
            this.txtPalavra.Text = "123";
            // 
            // btnCalculaAnagrama
            // 
            this.btnCalculaAnagrama.Location = new System.Drawing.Point(15, 32);
            this.btnCalculaAnagrama.Name = "btnCalculaAnagrama";
            this.btnCalculaAnagrama.Size = new System.Drawing.Size(75, 49);
            this.btnCalculaAnagrama.TabIndex = 2;
            this.btnCalculaAnagrama.Text = "Calcula &Anagrama";
            this.btnCalculaAnagrama.UseVisualStyleBackColor = true;
            this.btnCalculaAnagrama.Click += new System.EventHandler(this.btnCalculaAnagrama_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 104);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(15, 120);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(75, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // frmCalculaAnagrama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 506);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstAnagrama);
            this.Controls.Add(this.lblDigitePalavra);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.btnCalculaAnagrama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculaAnagrama";
            this.ShowIcon = false;
            this.Text = "Calcula Anagrama C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox lstAnagrama;
        internal System.Windows.Forms.Label lblDigitePalavra;
        internal System.Windows.Forms.TextBox txtPalavra;
        internal System.Windows.Forms.Button btnCalculaAnagrama;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

