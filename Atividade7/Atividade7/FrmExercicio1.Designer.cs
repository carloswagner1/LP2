namespace Atividade7
{
    partial class frmExercicio1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.lblExercicio1 = new System.Windows.Forms.Label();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.lblCaracteres = new System.Windows.Forms.Label();
            this.btnEspaçosEmBranco = new System.Windows.Forms.Button();
            this.btnOcorrênciasR = new System.Windows.Forms.Button();
            this.btnParesdeLetras = new System.Windows.Forms.Button();
            this.rchtxtContador = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(82, 149);
            this.rchtxtTexto.MaxLength = 100;
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(650, 81);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            this.rchtxtTexto.TextChanged += new System.EventHandler(this.Rchtxt_Contador);
            // 
            // lblExercicio1
            // 
            this.lblExercicio1.AutoSize = true;
            this.lblExercicio1.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExercicio1.Location = new System.Drawing.Point(75, 38);
            this.lblExercicio1.Name = "lblExercicio1";
            this.lblExercicio1.Size = new System.Drawing.Size(178, 38);
            this.lblExercicio1.TabIndex = 1;
            this.lblExercicio1.Text = "Exercício 1";
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AutoSize = true;
            this.lblEnunciado.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(78, 124);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(292, 23);
            this.lblEnunciado.TabIndex = 2;
            this.lblEnunciado.Text = "Insira seu texto na caixa abaixo";
            // 
            // lblCaracteres
            // 
            this.lblCaracteres.AutoSize = true;
            this.lblCaracteres.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteres.Location = new System.Drawing.Point(81, 238);
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.Size = new System.Drawing.Size(89, 20);
            this.lblCaracteres.TabIndex = 3;
            this.lblCaracteres.Text = "Caracteres";
            // 
            // btnEspaçosEmBranco
            // 
            this.btnEspaçosEmBranco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEspaçosEmBranco.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspaçosEmBranco.Location = new System.Drawing.Point(85, 321);
            this.btnEspaçosEmBranco.Name = "btnEspaçosEmBranco";
            this.btnEspaçosEmBranco.Size = new System.Drawing.Size(194, 68);
            this.btnEspaçosEmBranco.TabIndex = 5;
            this.btnEspaçosEmBranco.Text = "Contar Espaços em Branco";
            this.btnEspaçosEmBranco.UseVisualStyleBackColor = true;
            this.btnEspaçosEmBranco.Click += new System.EventHandler(this.btnEspaçosEmBranco_Click);
            // 
            // btnOcorrênciasR
            // 
            this.btnOcorrênciasR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOcorrênciasR.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcorrênciasR.Location = new System.Drawing.Point(313, 321);
            this.btnOcorrênciasR.Name = "btnOcorrênciasR";
            this.btnOcorrênciasR.Size = new System.Drawing.Size(194, 68);
            this.btnOcorrênciasR.TabIndex = 6;
            this.btnOcorrênciasR.Text = "Ocorrências da Letra R";
            this.btnOcorrênciasR.UseVisualStyleBackColor = true;
            this.btnOcorrênciasR.Click += new System.EventHandler(this.btnOcorrênciasR_Click);
            // 
            // btnParesdeLetras
            // 
            this.btnParesdeLetras.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnParesdeLetras.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParesdeLetras.Location = new System.Drawing.Point(538, 321);
            this.btnParesdeLetras.Name = "btnParesdeLetras";
            this.btnParesdeLetras.Size = new System.Drawing.Size(194, 68);
            this.btnParesdeLetras.TabIndex = 7;
            this.btnParesdeLetras.Text = "Ocorrências de Pares de Letras";
            this.btnParesdeLetras.UseVisualStyleBackColor = true;
            this.btnParesdeLetras.Click += new System.EventHandler(this.btnParesdeLetras_Click);
            // 
            // rchtxtContador
            // 
            this.rchtxtContador.Enabled = false;
            this.rchtxtContador.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtContador.Location = new System.Drawing.Point(174, 236);
            this.rchtxtContador.Name = "rchtxtContador";
            this.rchtxtContador.Size = new System.Drawing.Size(39, 29);
            this.rchtxtContador.TabIndex = 8;
            this.rchtxtContador.Text = "";
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(814, 454);
            this.Controls.Add(this.rchtxtContador);
            this.Controls.Add(this.btnParesdeLetras);
            this.Controls.Add(this.btnOcorrênciasR);
            this.Controls.Add(this.btnEspaçosEmBranco);
            this.Controls.Add(this.lblCaracteres);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.lblExercicio1);
            this.Controls.Add(this.rchtxtTexto);
            this.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmExercicio1";
            this.Text = "Exercício 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Label lblExercicio1;
        private System.Windows.Forms.Label lblEnunciado;
        private System.Windows.Forms.Label lblCaracteres;
        private System.Windows.Forms.Button btnEspaçosEmBranco;
        private System.Windows.Forms.Button btnOcorrênciasR;
        private System.Windows.Forms.Button btnParesdeLetras;
        private System.Windows.Forms.RichTextBox rchtxtContador;
    }
}