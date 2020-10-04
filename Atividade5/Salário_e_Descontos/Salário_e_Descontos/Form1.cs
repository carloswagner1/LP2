using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salário_e_Descontos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void btn_Click(object sender, EventArgs e)
        {
            limparCampos(gbxDados);
            limparCampos(gbxResultados);
            limparCampos(gbxEstadoCivil);
            lblMensagem.Text = "";            
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {            
            if (txtNome.Text == "")
            {
                MessageBox.Show("Todos os dados tem que ser preenchidos", "Erro");
            }
            else if (mskbxSalarioBruto.Text == "")
            {
                MessageBox.Show("Todos os dados tem que ser preenchidos", "Erro");
            }
            else if (mskbxNumeroFilhos.Text == "")
            {
                MessageBox.Show("Todos os dados tem que ser preenchidos", "Erro");
            }
            else if (ckbxCasado.Checked == false && ckbxSolteiro.Checked == false)
            {
                MessageBox.Show("Todos os dados tem que ser preenchidos", "Erro");
            }
            else if (ckbxCasado.Checked == true && ckbxSolteiro.Checked == true)
            {
                MessageBox.Show("Selecione apenas uma opção (casado ou solteiro)", "Erro");
            }
            else
            {
                double salarioBruto, salarioLiquido;
                int numeroFilhos;
                string sexo, estadoCivil;

                if (double.TryParse(mskbxSalarioBruto.Text, out salarioBruto) &&
                (int.TryParse(mskbxNumeroFilhos.Text, out numeroFilhos)))
                {
                    mskbxSalarioFamilia.Text = salFamilia(numeroFilhos, salarioBruto / 100).ToString("C");
                    if (aliquotaIRPF(salarioBruto / 100) == 0)
                    {
                        mskbxAliquotaIRPF.Text = "isento";
                        mskbxDescontoIRPF.Text = (aliquotaIRPF(salarioBruto / 100) * salarioBruto / 100).ToString("C");
                    }
                    else
                    {
                        mskbxAliquotaIRPF.Text = aliquotaIRPF(salarioBruto / 100).ToString("P");
                        mskbxDescontoIRPF.Text = (aliquotaIRPF(salarioBruto / 100) * salarioBruto / 100).ToString("C");
                    }
                    if (salarioBruto / 100 > 2801.56)
                    {
                        mskbxAliquotaINSS.Text = "Teto INSS";
                        mskbxDescontoINSS.Text = "R$ 308,17";
                    }
                    else
                    {
                        mskbxAliquotaINSS.Text = aliquotaINSS(salarioBruto / 100).ToString("P");
                        mskbxDescontoINSS.Text = (aliquotaINSS(salarioBruto / 100) * salarioBruto / 100).ToString("C");
                    }
                    if (salarioBruto/100 > 2801.56)
                    {
                        salarioLiquido = salarioBruto / 100 - 308.17 -
                        (aliquotaIRPF(salarioBruto / 100) * salarioBruto / 100) +
                        salFamilia(numeroFilhos, salarioBruto / 100);
                    }
                    else
                    {
                        salarioLiquido = salarioBruto / 100 - (aliquotaINSS(salarioBruto / 100)
                        * salarioBruto / 100) - (aliquotaIRPF(salarioBruto / 100) * 
                        salarioBruto / 100) + salFamilia(numeroFilhos, salarioBruto / 100);
                    }
                    
                    if (rbtnFeminino.Checked == true)
                    {
                        sexo = "feminino";
                    }
                    else
                    {
                        sexo = "masculino";
                    }

                    if (ckbxSolteiro.Checked == true)
                    {
                        estadoCivil = "solteiro(a)";
                    }
                    else
                    {
                        estadoCivil = "casado(a)";
                    }
                    mskbxSalarioLiquido.Text = salarioLiquido.ToString("C");
                    lblMensagem.Text = $"Dados relativos ao(a) funcionário(a):\n" + txtNome.Text + 
                        "\ndo sexo " + sexo + ", " + estadoCivil + " e que possui " + 
                        mskbxNumeroFilhos.Text + " filhos.";
                }
            }
        }

        public static double salFamilia(int numFilhos, double salBrt)
        {
            // função pra salário família
            double salarioFamilia;

            if (salBrt > 435.52)
            {
                if(salBrt <= 654.61)
                {
                    salarioFamilia = 15.74 * numFilhos;
                }
                else
                {
                    salarioFamilia = 0;
                }
            }
            else 
            {
                salarioFamilia = 22.33 * numFilhos;
            }
            return salarioFamilia;
        }

        public static double aliquotaIRPF(double salBrt)
        {
            //função calcular aliquotaIRPF
            double aliquotaIRPF = 0;

            if (salBrt > 1257.12)
            {
                if (salBrt <= 2512.08)
                {
                    aliquotaIRPF = 0.15;
                }
                else
                {
                    aliquotaIRPF = 0.275;
                }
            }
            else
            {
                aliquotaIRPF = 0;
            }
            return aliquotaIRPF;
        }

        public static double aliquotaINSS(double salBrt)
        {
            //função calcular aliquotaINSS
            double aliquotaINSS = 0;

            if (salBrt <= 800.47)
            {
                aliquotaINSS = 0.0765;
            }
            else if (salBrt <= 1050.00)
            {
                aliquotaINSS = 0.0865;
            }
            else if (salBrt <= 1400.77)
            {
                aliquotaINSS = 0.09;
            }
            else if (salBrt <= 2801.56)
            {
                aliquotaINSS = 0.11;
            }
            return aliquotaINSS;
         }

        public static void limparCampos(GroupBox grupo)
        {
            //limpar série de componentes
            foreach (Control componente in grupo.Controls)
            {
                if (componente is TextBox)
                {
                    ((TextBox)componente).Clear();
                }
                else if (componente is MaskedTextBox)
                {
                    ((MaskedTextBox)componente).Clear();
                }
                else if (componente is CheckBox)
                {
                    ((CheckBox)componente).Checked = false;
                }
                else if (componente is RadioButton)
                {
                    ((RadioButton)componente).Checked = false;
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

        private void mskbxSalarioBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void mskbxNumeroFilhos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ckbxSolteiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void ckbxCasado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
