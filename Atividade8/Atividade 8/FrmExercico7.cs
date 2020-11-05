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

namespace Atividade_8
{
    public partial class frmExercicio7 : Form
    {
        public frmExercicio7()
        {
            InitializeComponent();
        }
        int[] qntChars = new int[5];
        string[] nomes = new string[5];
        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string nome;
            string[] nomesSemEspaco = new string[5];
            int[] qntChars = new int[5];
            for (int i = 0; i < 5; i++)
            {
                nome = Interaction.InputBox("Nome(" + (i + 1) + "): ");
                nomes[i] = nome;
                nome = nome.Replace(" ", "");
                qntChars[i] = nome.Length;
            }
            lstbxExibirNomes.BeginUpdate();
            for (int i = 0; i < 5; i++)
            {
                lstbxExibirNomes.Items.Add("O nome " + nomes[i] + " tem " + qntChars[i] + " caracteres\n");
            }

            lstbxExibirNomes.EndUpdate();
        }
    }
}
