using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace wfaAnagrama
{
    public partial class frmCadeado : Form
    {
        public frmCadeado()
        {
            InitializeComponent();
        }

        private void btnCalcule_Click(object sender, EventArgs e)
        {
            List<string> lstStrLetras = new List<string>();
            string[] arrStrSequenciaAberto;
            string[] arrStrOpcoesLetras;
            string strSequenciaAberto = string.Empty;
            int intTamanhoSequenciaAberto;

            lblSeraAbertoEm.Text = "";

            arrStrSequenciaAberto = txtSequenciaAberto.Text.Split();
            arrStrOpcoesLetras = txtOpcoesLetras.Text.Split();

            foreach (string str in arrStrSequenciaAberto)
                strSequenciaAberto = strSequenciaAberto + str;

            intTamanhoSequenciaAberto = (int)nudChavesSeletoras.Value;

            GeraNovaPalavra(lstStrLetras, arrStrOpcoesLetras, intTamanhoSequenciaAberto, string.Empty);

            lstCadeado.Items.Clear();

            foreach (string letra in lstStrLetras)
            {
                lstCadeado.Items.Add(string.Format("{0}", letra));

                if (letra == strSequenciaAberto)
                {
                    lstCadeado.SetSelected(lstCadeado.Items.Count-1, true);
                    lblSeraAbertoEm.Text = letra;
                }
            }
        }

        private void GeraNovaPalavra(List<string> lista, string[] array, int tamanho, string palavraAtual)
        {
            string palavraCorrente = palavraAtual;

            for (int i = 0; i < array.Length; i++)
            {
                palavraCorrente += array[i];

                if (palavraCorrente.Length >= tamanho)
                {
                    lista.Add(palavraCorrente);
                    palavraCorrente = palavraAtual;
                }
                else
                {
                    GeraNovaPalavra(lista, array, tamanho, palavraCorrente);
                    palavraCorrente = palavraAtual;
                }
            }
        }
    }
}


