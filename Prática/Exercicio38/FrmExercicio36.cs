using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio38
{
    public partial class frmExercicio36 : Form
    {
        public frmExercicio36()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int numero = 0;


            if ((txtNumero.Text == string.Empty) || (!int.TryParse(txtNumero.Text, out numero)) ||
                (numero <= 0) || (numero > 50))
            {
                MessageBox.Show("Valor Invalido!\nDigite novamente o valor.", "Atenção!");
                txtNumero.Clear();
                txtResultado.Clear();
            }
            else
            {
                int i;
                double resultado = 0;
                for (i = 0; i <= numero; i++)
                {
                    resultado += (double) i/(i+1);
                }
                //MessageBox.Show(resultado.ToString("N4"));
                txtResultado.Text = resultado.ToString("N4");
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
