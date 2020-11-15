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
    public partial class frmExercicio38 : Form
    {
        public frmExercicio38()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            double[,] vendas = new double[7, 5];
            string valor;
            double totalGeral = 0;
            double totalPorDia = 0;

            for (int i = 0; i < vendas.GetLength(0); i++)
            {
                for (int j = 0; j < vendas.GetLength(1); j++)
                {
                    while (true)
                    {
                        valor = Interaction.InputBox("Dia: " + (i + 1) + "\nProduto: " + (j + 1));

                        if (double.TryParse(valor, out vendas[i, j]))
                        {
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Valor Invalido!");
                        }
                    }
                }
            }
            lstBxResultado.BeginUpdate();
            for (int i = 0; i < vendas.GetLength(0); i++)
            {
                for (int j = 0; j < vendas.GetLength(1); j++)
                {
                    totalGeral += vendas[i, j];
                    totalPorDia += vendas[i, j];
                }
                lstBxResultado.Items.Add("Total do Dia " + (i + 1) + ": " + totalPorDia.ToString("C2"));
                totalPorDia = 0;
            }
            lstBxResultado.Items.Add("");
            lstBxResultado.Items.Add("Total Geral: " + totalGeral.ToString("C2"));
            lstBxResultado.EndUpdate();
        }
    }
}
