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
    public partial class frmExercicio39 : Form
    {
        public frmExercicio39()
        {
            InitializeComponent();
        }

        private void frmExercicio39_Load(object sender, EventArgs e)
        {

        }

        private void btnCandidatar_Click(object sender, EventArgs e)
        {
            double salarioPretendido = 0;

            if ((txtNome.Text == "") || (txtTelefone.Text == "") || (cbxIdade.Text == string.Empty) ||
                (cbxIdade.SelectedIndex == -1) || (lstbxDistancia.SelectedIndex == -1) ||
                (txtNomedaEmpresa.Text=="") || (cbxTempoDeExperiencia.SelectedIndex == -1) ||
                    (!double.TryParse(mskbxPretensao.Text, out salarioPretendido)))
                {
                MessageBox.Show("Valor inválido ou campo em branco", "Atenção!!!");
            }
            else if(ckbxFeminino.Checked == true && ckbxMasculino.Checked == true)
            { 
                MessageBox.Show("Selecione apenas uma opção (masculino ou feminino)", "Erro");
            }
            else if (ckbxFeminino.Checked == false && ckbxMasculino.Checked == false)
            {
                MessageBox.Show("Selecione uma opção (masculino ou feminino)", "Erro");
            }

            else
            {
                if (cbxTempoDeExperiencia.SelectedIndex == 0)
                {
                    MessageBox.Show("Recebemos a sua candidatura.\nEntretanto, você não preenche os requisitos para a vaga.\n" +
                        "Agradecemos a sua participação.", "Mensagem de feedback");
                }

                else if (cbxTempoDeExperiencia.SelectedIndex == 1)
                {
                    MessageBox.Show("Recebemos a sua candidatura.\nEm breve entraremos em contato para a realização de um teste.", "Mensagem de feedback");
                }

                else if (lstbxDistancia.SelectedIndex == 3)
                {
                    MessageBox.Show("Recebemos a sua candidatura.\nEntretanto, você não preenche os requisitos para a vaga " +
                        "em razão da empresa não fornecer transporte para deslocamento.\nAgradecemos a sua participação.",
                        "Mensagem de feedback");
                }

                else if (salarioPretendido < 1000 || salarioPretendido > 2500)
                {
                    MessageBox.Show("Recebemos a sua candidatura.\nEntretanto, você não preenche os requisitos para a vaga.\n" +
                        "Agradecemos a sua participação.", "Mensagem de feedback");
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

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void cbxIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void ckbxMasculino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void ckbxFeminino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void rbtnSolteiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void rbtnCasado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void rbtnViuvo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void rbtnDIvorciado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void rbtnOutros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void lstbxDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void txtNomedaEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void cbxTempoDeExperiencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }

        private void mskbxPretensao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
