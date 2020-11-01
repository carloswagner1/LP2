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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcularH_Click(object sender, EventArgs e)
        {
            int verificador;

            if ((txtNumeroN.Text == string.Empty) || (!int.TryParse(txtNumeroN.Text, out verificador)))
            {
                MessageBox.Show("Valor Invalido!", "Atenção!");
                txtNumeroN.Clear();
                txtNumeroH.Clear();
            }
            else
            {
                int i, n;
                n = int.Parse(txtNumeroN.Text);
                double numDec = 0;
                for (i = 1; i <= n; i++)
                {
                    numDec += 1 / (double)i;
                }
                txtNumeroH.Text = numDec.ToString("N4");
            }
        }

        private void txtNumeroN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
