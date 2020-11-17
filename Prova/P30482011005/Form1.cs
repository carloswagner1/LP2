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

namespace P30482011005
{
    public partial class frmAvaliacao : Form
    {
        public frmAvaliacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] vendas = new double[5, 4];
            string valor;
            double totalPorMes = 0;
            double totalGeral = 0;

            for (int i = 0; i < vendas.GetLength(0); i++)
            {
                for (int j = 0; j < vendas.GetLength(1); j++)
                {
                    while (true)
                    {
                        valor = Interaction.InputBox("Mês: " + (i + 1) + "\nSemana: " + (j + 1), "Entrada de dados");

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
            lstbxResultado.BeginUpdate();
            for (int i = 0; i < vendas.GetLength(0); i++)
            {
                for (int j = 0; j < vendas.GetLength(1); j++)
                {
                    lstbxResultado.Items.Add("Total da Semana " + (j + 1) + " do Mês " + (i+1) + ": " + vendas[i,j].ToString("C2"));
                    totalGeral += vendas[i, j];
                    totalPorMes += vendas[i, j];
                }               
                lstbxResultado.Items.Add(">>>Total do mês " + (i + 1) + ": " + totalPorMes.ToString("C2"));
                totalPorMes = 0;
                lstbxResultado.Items.Add("--------------------");
            }
            lstbxResultado.Items.Add("--------------------");
            lstbxResultado.Items.Add("Total Geral: " + totalGeral.ToString("C2"));
            lstbxResultado.EndUpdate();
        }
    }
}
