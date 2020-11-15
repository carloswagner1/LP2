using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Exercicio38
{
    public partial class frmExercicio37 : Form
    {
        public frmExercicio37()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            double[] vetor1 = new double[10];
            double[] vetor2 = new double[10];

            string auxiliar1 = "";
            string auxiliar2 = "";

            for (var i = 0; i < vetor1.Length; i++)
            {
                auxiliar1 = Interaction.InputBox("Digite o número " + (i + 1).ToString(),
                "Entrada de Dados");

                if (double.TryParse(auxiliar1, out vetor1[i]))
                {
                    if (i % 2 == 0)
                        vetor2[i] = vetor1[i] * 5;
                    else
                        vetor2[i] = vetor1[i] + 5;
                }
                else
                {
                    MessageBox.Show("Número Inválido");
                    i--;
                }
            }
            auxiliar1 = "";
            auxiliar2 = "";

            for (var i = 0; i < vetor1.Length; i++)
            {
                auxiliar1 += " " + vetor1[i];
                auxiliar2 += " " + vetor2[i];
            }

            txtMatrizA.Text = auxiliar1.ToString();
            txtMatrizB.Text = auxiliar2.ToString();
        }
    }
}
