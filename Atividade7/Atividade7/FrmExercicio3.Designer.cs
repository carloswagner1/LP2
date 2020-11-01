namespace Atividade7
{
    partial class frmExercicio3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercicio3));
            this.lblExercicio3 = new System.Windows.Forms.Label();
            this.lblEnunciado3 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lblInformação = new System.Windows.Forms.Label();
            this.lblTextoInvertido = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblÉPalindromo = new System.Windows.Forms.Label();
            this.rchtxtPalindromo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblExercicio3
            // 
            this.lblExercicio3.AutoSize = true;
            this.lblExercicio3.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExercicio3.Location = new System.Drawing.Point(77, 40);
            this.lblExercicio3.Name = "lblExercicio3";
            this.lblExercicio3.Size = new System.Drawing.Size(178, 38);
            this.lblExercicio3.TabIndex = 0;
            this.lblExercicio3.Text = "Exercício 3";
            // 
            // lblEnunciado3
            // 
            this.lblEnunciado3.AutoSize = true;
            this.lblEnunciado3.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado3.Location = new System.Drawing.Point(80, 99);
            this.lblEnunciado3.Name = "lblEnunciado3";
            this.lblEnunciado3.Size = new System.Drawing.Size(483, 23);
            this.lblEnunciado3.TabIndex = 1;
            this.lblEnunciado3.Text = "Digite uma palavra ou frase para ver se é palíndromo";
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(82, 134);
            this.txtTexto.MaxLength = 50;
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(658, 63);
            this.txtTexto.TabIndex = 2;
            this.txtTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTexto_KeyPress);
            // 
            // lblInformação
            // 
            this.lblInformação.AutoSize = true;
            this.lblInformação.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformação.Location = new System.Drawing.Point(80, 235);
            this.lblInformação.Name = "lblInformação";
            this.lblInformação.Size = new System.Drawing.Size(145, 23);
            this.lblInformação.TabIndex = 3;
            this.lblInformação.Text = "Texto invertido";
            // 
            // lblTextoInvertido
            // 
            this.lblTextoInvertido.AutoSize = true;
            this.lblTextoInvertido.BackColor = System.Drawing.Color.Linen;
            this.lblTextoInvertido.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoInvertido.Location = new System.Drawing.Point(80, 267);
            this.lblTextoInvertido.Name = "lblTextoInvertido";
            this.lblTextoInvertido.Size = new System.Drawing.Size(0, 23);
            this.lblTextoInvertido.TabIndex = 4;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Image = ((System.Drawing.Image)(resources.GetObject("btnVerificar.Image")));
            this.btnVerificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVerificar.Location = new System.Drawing.Point(610, 312);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(130, 82);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblÉPalindromo
            // 
            this.lblÉPalindromo.AutoSize = true;
            this.lblÉPalindromo.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblÉPalindromo.Location = new System.Drawing.Point(80, 344);
            this.lblÉPalindromo.Name = "lblÉPalindromo";
            this.lblÉPalindromo.Size = new System.Drawing.Size(122, 23);
            this.lblÉPalindromo.TabIndex = 6;
            this.lblÉPalindromo.Text = "Palíndromo?";
            // 
            // rchtxtPalindromo
            // 
            this.rchtxtPalindromo.Enabled = false;
            this.rchtxtPalindromo.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchtxtPalindromo.Location = new System.Drawing.Point(219, 344);
            this.rchtxtPalindromo.Name = "rchtxtPalindromo";
            this.rchtxtPalindromo.Size = new System.Drawing.Size(100, 50);
            this.rchtxtPalindromo.TabIndex = 7;
            this.rchtxtPalindromo.Text = "";
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(823, 459);
            this.Controls.Add(this.rchtxtPalindromo);
            this.Controls.Add(this.lblÉPalindromo);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblTextoInvertido);
            this.Controls.Add(this.lblInformação);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblEnunciado3);
            this.Controls.Add(this.lblExercicio3);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmExercicio3";
            this.Text = "Exercício 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExercicio3;
        private System.Windows.Forms.Label lblEnunciado3;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label lblInformação;
        private System.Windows.Forms.Label lblTextoInvertido;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblÉPalindromo;
        private System.Windows.Forms.RichTextBox rchtxtPalindromo;
    }
}