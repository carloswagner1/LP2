using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercicio38;
using Microsoft.VisualBasic;

namespace Prática
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void exercício36ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio36"];

            if (fc != null)
                fc.Close();

            frmExercicio36 FrmExercicio36 = new frmExercicio36();
            FrmExercicio36.MdiParent = this;
            FrmExercicio36.WindowState = FormWindowState.Maximized;
            FrmExercicio36.Show();
        }

        private void exercício37ToolStripMenuItem_Click(object sender, EventArgs e)
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

            MessageBox.Show(auxiliar1 + "\n", "Matriz 1");
            MessageBox.Show(auxiliar2 + "\n", "Matriz 2");
        }

        private void exercício38ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio38"];

            if (fc != null)
                fc.Close();

            frmExercicio38 FrmExercicio38 = new frmExercicio38();
            FrmExercicio38.MdiParent = this;
            FrmExercicio38.WindowState = FormWindowState.Maximized;
            FrmExercicio38.Show();
        }

        private void exercício39ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmExercicio39"];

            if (fc != null)
                fc.Close();

            frmExercicio39 FrmExercicio39 = new frmExercicio39();
            FrmExercicio39.MdiParent = this;
            FrmExercicio39.WindowState = FormWindowState.Maximized;
            FrmExercicio39.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
