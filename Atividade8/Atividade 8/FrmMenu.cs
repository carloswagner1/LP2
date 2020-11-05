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
using System.Collections;

namespace Atividade_8
{
    public partial class frmAtividade8 : Form
    {
        public frmAtividade8()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            double[] vetor = new double[20];
            string auxiliar = "";
            string saida = "";

            for(var i = 0; i< vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite o número " + (i + 1).ToString(),
                "Entrada de Dados");

                if (double.TryParse(auxiliar, out vetor[i]))
                {
                    vetor[i] = Convert.ToDouble(auxiliar);
                    saida = vetor[i].ToString() + "\n" + saida;
                }                    
                else
                {
                    MessageBox.Show("Número Inválido");
                    i--;
                }
            }
            MessageBox.Show(saida);
        }

        private void frmExercicio2_Click(object sender, EventArgs e)
        {
            double[] vetor = new double[20];
            string auxiliar = "";


            for (var i = 0; i < vetor.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite o número " + (i + 1).ToString(),
                "Entrada de Dados");

                if (double.TryParse(auxiliar, out vetor[i]))
                {
                    vetor[i] = Convert.ToDouble(auxiliar);                
                }
                else
                {
                    MessageBox.Show("Número Inválido");
                    i--;
                }
            }
            Array.Reverse(vetor);
            string saida = "";
            foreach (double x in vetor)
                saida += x + "\n";
            MessageBox.Show(saida);
        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            double[] quantidade = new double[10];
            double[] preço = new double[10];
            string auxiliar = "";
            string auxiliar2 = "";

            for (var i = 0; i < quantidade.Length; i++)
            {
                auxiliar = Interaction.InputBox("Digite a quantidade da mercadoria " + (i + 1).ToString(),
                "Entrada de Quantidades");

                if (double.TryParse(auxiliar, out quantidade[i]))
                {
                    quantidade[i] = Convert.ToDouble(auxiliar);
                }
                else
                {
                    MessageBox.Show("Número Inválido");
                    i--;
                }
                auxiliar2 = Interaction.InputBox("Digite o preço da mercadoria " + (i + 1).ToString(),
                    "Entrada de Preço");

                if (double.TryParse(auxiliar2, out preço[i]))
                {
                    preço[i] = Convert.ToDouble(auxiliar2);
                }
                else
                {
                    MessageBox.Show("Número Inválido", "Atenção!!!");
                    i--;
                }
            }
            double total = 0;
            for (var i = 0; i < quantidade.Length; i++)
            {
                total += quantidade[i] * preço[i];
            }
            MessageBox.Show("O faturamento total é de: " + total.ToString("C2"));
        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            string[] Alunos = {"Viviane", "André", "Hélio", "Denise", "Junior",
                "Leonardo", "Jose", "Nelma", "Tobby"};
            Int32 I, Total = 0;
            Int32 N = Alunos.Length;
            for (I = 0; I < N - 1; I++)
            {
                Total += Alunos[I].Length;
            }
            MessageBox.Show("A resposta é: " + Total,"Exercício 4");
        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            ArrayList Nomes = new ArrayList(10);

            for (int i = 0; i < 10; i++)
            {
                Nomes.Add("Ana");
                Nomes.Add("André");
                Nomes.Add("Debora");
                Nomes.Add("Fatima");
                Nomes.Add("João");
                Nomes.Add("Janete");
                Nomes.Add("Otavio");
                Nomes.Add("Marcelo");
                Nomes.Add("Pedro");
                Nomes.Add("Thais");

            }

            Nomes.Remove("Otavio");
            string NomesJuntos = "";
            for (int i = 0; i < 9; i++)
            {
                NomesJuntos += Nomes[i] + " ";
            }
            MessageBox.Show(NomesJuntos, "Nome dos Alunos");
        }

        private void btnExercicio6_Click(object sender, EventArgs e)
        {
            double[,] notasAlunos = new double[20, 3];
            double[] medias = new double[20];
            string nota;
            string Saida = "";

            for (int i = 0; i < 20; i++)
            {
                medias[i] = 0;
                for (int j = 0; j < 3; j++)
                {
                    while (true)
                    {
                        nota = Interaction.InputBox("Aluno: " + (i + 1) + "\n Nota: " + (j + 1));

                        if (double.TryParse(nota, out notasAlunos[i, j]) && (notasAlunos[i,j] <= 10))
                        {
                            medias[i] += notasAlunos[i, j];
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Numero Invalido!");
                        }
                    }

                }

            }
            for (int i = 0; i < 20; i++)
            {

                Saida += "Aluno " + (i + 1) + ": " + "média: " + (medias[i] / 3).ToString("N2") + "\n";
            }
            MessageBox.Show(Saida, "Médias Finais");

        }

        private void btnExercicio7_Click(object sender, EventArgs e)
        {
            frmExercicio7 frm = new frmExercicio7();
            frm.Show();
        }
    }
}
