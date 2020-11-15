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
            Form fc = Application.OpenForms["frmExercicio37"];

            if (fc != null)
                fc.Close();

            frmExercicio37 FrmExercicio37 = new frmExercicio37();
            FrmExercicio37.MdiParent = this;
            FrmExercicio37.WindowState = FormWindowState.Maximized;
            FrmExercicio37.Show();
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
