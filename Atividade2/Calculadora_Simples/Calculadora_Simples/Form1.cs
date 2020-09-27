using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Simples
{
    public partial class Form1 : Form
    {
        double numero1, numero2;
        double resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Clear();
            txtNumero3.Text = String.Empty;
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNumero1.Text, out numero1)) &&
                    (double.TryParse(txtNumero2.Text, out numero2)))
            {
                resultado = numero1 - numero2;
                txtNumero3.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números Inválidos");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNumero1.Text, out numero1)) &&
                    (double.TryParse(txtNumero2.Text, out numero2)))
            {
                resultado = numero1 * numero2;
                txtNumero3.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números Inválidos");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNumero1.Text, out numero1)) &&
                    (double.TryParse(txtNumero2.Text, out numero2)))
            {
                if (numero2 == 0)
                    MessageBox.Show("O número não pode ser zero!");
                else
                {
                    resultado = numero1 / numero2;
                    txtNumero3.Text = resultado.ToString();
                }                
            }
            else
                MessageBox.Show("Números Inválidos");
        }

        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNumero1.Text, out numero1)) &&
                    (double.TryParse(txtNumero2.Text, out numero2)))
            {
                resultado = numero1 + numero2;
                txtNumero3.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números Inválidos");
        }
    }
}
