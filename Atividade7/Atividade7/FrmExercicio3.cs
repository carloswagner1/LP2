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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if ((txtTexto.Text == string.Empty))
            {
                MessageBox.Show("Caixa de texto está vazia.\nInsira uma palavra ou texto para verificação.", "Atenção!");
            }
            else
            {
                txtTexto.Text = txtTexto.Text.ToUpper();

                txtTexto.Text = txtTexto.Text.Replace(" ", "");

                string texto = txtTexto.Text;
                char[] arr = texto.ToCharArray();
                Array.Reverse(arr);
                texto = "";
                foreach (char c in arr)
                    texto = texto + c.ToString();
                lblTextoInvertido.Text = (texto);

                if (String.Compare(txtTexto.Text, lblTextoInvertido.Text) == 0)
                {
                    rchtxtPalindromo.Text = ("Sim");
                }
                else
                {
                    rchtxtPalindromo.Text = ("Não");
                }
            }
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
