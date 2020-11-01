using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade7
{
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnEspaçosEmBranco_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int i = 0;
            string v = rchtxtTexto.Text;

            if (v == "")
            {
                MessageBox.Show("A caixa de texto está vazia.\nInsira um texto no local indicado.", "Atenção!");
            }
            else
            {
                while (i < rchtxtTexto.Text.Length)
                {
                    if (Char.IsWhiteSpace(rchtxtTexto.Text[i]))
                    {
                        contador++;
                    }
                    i++;
                }
                MessageBox.Show("O texto informado tem " + contador + " espaços em branco.", "Contador de Espaço em Branco");
            }
        }

        private void btnOcorrênciasR_Click(object sender, EventArgs e)
        {
            string v = rchtxtTexto.Text;

            if (v == "")
            {
                MessageBox.Show("A caixa de texto está vazia.\nInsira um texto no local indicado.", "Atenção!");
            }
            else
            {
                int contador = 0;

                foreach (char c in rchtxtTexto.Text)
                {
                    if (c == 'R' || c == 'r')
                        contador++;
                }
                MessageBox.Show("O texto informado tem  " + contador + " ocorrência das letras 'r' ou 'R'.", "Ocorrência da Letra R");
            }
        }

        private void btnParesdeLetras_Click(object sender, EventArgs e)
        {
            string v = rchtxtTexto.Text;

            if (v == "")
            {
                MessageBox.Show("A caixa de texto está vazia.\nInsira um texto no local indicado.", "Atenção!");
            }
            else
            {
                int i, contador = 0;

                for (i = 1; i < rchtxtTexto.Text.Length; i++)
                {
                    if (rchtxtTexto.Text[i - 1] == rchtxtTexto.Text[i])
                        contador++;
                }
                MessageBox.Show("O Texto informado tem " + contador + " ocorrências de pares de letras iguais.", "Par de Letras Seguidas");
            }
        }

        private void Rchtxt_Contador(object sender, EventArgs e)
        {
            int n;

            n = rchtxtTexto.Text.Length;
            rchtxtContador.Text = n.ToString();
        }
    }
}
