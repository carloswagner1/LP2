using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triângulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txt_A.Clear();
            txt_B.Clear();
            txt_C.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if (txt_A.Text == "" || txt_B.Text == "" || txt_C.Text == "")
            {
                MessageBox.Show("Todos os valores devem ser informados!!!", "Atenção");
            }
            else
                if ((double.TryParse(txt_A.Text, out a)) &&
                     (double.TryParse(txt_B.Text, out b)) &&
                        (double.TryParse(txt_C.Text, out c)))
            {
                if ((Math.Abs(b-c) > a) || (a > b + c) || (Math.Abs(a-c) > b) || (b > a + c) || (Math.Abs(a-b) > c) || (c > a + b))
                {
                    MessageBox.Show("Os valores informados não formam um triângulo!!!");
                }
                else
                {
                    if (a != b && a != c && b != c)
                    {
                        MessageBox.Show("Triângulo Escaleno.", "Tipo de Triângulo");
                    }
                    else
                        if (a == b && a == c)
                    {
                        MessageBox.Show("Triângulo Equilátero.", "Tipo de Triângulo");

                    }
                    else 
                        if (a == b || a == c || b == c)
                    {
                        MessageBox.Show("Triângulo Isósceles.", "Tipo de Triângulo");
                    }
                }
            }
                
        }

        private void txt_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txt_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txt_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
