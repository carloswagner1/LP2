using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peso_Ideal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, pesoAtual, pesoIdeal;

            if (double.TryParse(mskbxAltura.Text, out altura) &&
                (double.TryParse(mskbxPesoAtual.Text, out pesoAtual)))
            {
                if (rbtnFeminino.Checked)
                    pesoIdeal = (62.1 * altura) - 44.7;
                else
                    pesoIdeal = (72.7 * altura) - 58;

                if (pesoAtual == pesoIdeal)
                    MessageBox.Show("Seu peso ideal é " + pesoIdeal.ToString("N2") + " Kg.\n" + "Você está com o peso ideal.", "Peso Ideal");
                else
                    if (pesoAtual > pesoIdeal)
                    MessageBox.Show("Seu peso ideal é " + pesoIdeal.ToString("N2") + " Kg.\n" + "Regime Obrigatório Já!!!", "Peso Ideal");
                else
                    MessageBox.Show("Seu peso ideal é " + pesoIdeal.ToString("N2") + " Kg.\n" + "Coma bastante massas e doces.", "Peso Ideal");
            }
            else
                MessageBox.Show("Valor inválido.");
        }

        private void mskbxPesoAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }

        }

        private void mskbxAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void rbtnFeminino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void rbtnMasculino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
