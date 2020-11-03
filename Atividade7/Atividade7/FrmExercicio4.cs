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
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double verificador;

            if ((txtSalário.Text == string.Empty) || (!double.TryParse(txtSalário.Text, out verificador)))
            {
                MessageBox.Show("Valor Inválido no Salario!", "Atenção!");
                txtSalário.Clear();
            }
            else if ((txtProdução.Text == string.Empty) || (!double.TryParse(txtProdução.Text, out verificador)))
            {
                MessageBox.Show("Valor Invalido na produção!", "Atenção!");
                txtProdução.Clear();
            }
            else if ((txtGratificação.Text == string.Empty) || (!double.TryParse(txtGratificação.Text, out verificador)))
            {
                MessageBox.Show("Valor Invalido na gratificação!","Atenção!");
                txtGratificação.Clear();
            }
            else
            {
                double Sal, Prod, Grat, SalBruto;

                Sal = double.Parse(txtSalário.Text);
                Prod = double.Parse(txtProdução.Text);
                Grat = double.Parse(txtGratificação.Text);

                int bonusA = 0, bonusB = 0, bonusC = 0;
                if (Prod >= 100) bonusA = 1;
                if (Prod >= 120) bonusB = 1;
                if (Prod >= 150) bonusC = 1;

                SalBruto = Sal + Sal * (0.05 * bonusA + 0.1 * bonusB + 0.1 * bonusC) + Grat;

                if (SalBruto >= 7000)
                {
                    if (Prod >= 150 && Grat > 0)
                    {
                        txtSalárioBruto.Text = SalBruto.ToString("C2");
                    }
                    else
                    {
                        txtSalárioBruto.Text = ("R$ 7.000,00");
                    }
                }
                else
                {
                    txtSalárioBruto.Text = SalBruto.ToString("C2");
                }

            }

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txtInscrição_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txtSalário_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txtGratificação_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txtProdução_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
