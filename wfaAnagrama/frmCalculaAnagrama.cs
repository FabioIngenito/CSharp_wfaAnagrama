using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    //
    // Created by SharpDevelop.
    // User: TriW
    // Date: 2012-02-23
    // Time: 09:01
    // 
    // To change this template use Tools | Options | Coding | Edit Standard Headers.
    //
    // Anagrama 
    // https://social.msdn.microsoft.com/Forums/pt-BR/2aeeca51-e09a-4334-8b4f-891584504769/anagramas?forum=504

namespace wfaAnagrama
{
    public partial class frmCalculaAnagrama : Form
    {
        List<string> anagramas = new List<string>();

        public frmCalculaAnagrama()
        {
            InitializeComponent();
        }

        private void btnCalculaAnagrama_Click(object sender, EventArgs e)
        {
            anagramas.Clear();
            Anagrama(txtPalavra.Text);
            lstAnagrama.Items.Clear();
            txtTotal.Clear();

            foreach (String anagrama1 in anagramas)
                lstAnagrama.Items.Add(anagrama1);

            txtTotal.Text = lstAnagrama.Items.Count.ToString();
        }

        // cria todos os anagramas da palavra envia em STR
        public void Anagrama(string Str)
        {
            Anagrama(ref Str, Str.Length);
        }

        // Metodo recuricivo de permutaçoes circulares
        public void Anagrama(ref string Str, int Lg)
        {
            if (Lg == 1)
            {
                if (!anagramas.Contains(Str))
                    anagramas.Add(Str);
            }
            else
            {
                string strTmp = Str;
                for (int i = 0; i < Lg; i++)
                {
                    strTmp = strTmp.Substring(1, Lg - 1) + strTmp[0] + strTmp.Substring(Lg);
                    Anagrama(ref strTmp, Lg - 1);
                }
            }
        }
    }
}
