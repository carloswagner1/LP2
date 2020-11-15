namespace Exercicio38
{
    partial class frmExercicio37
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblMatrizA = new System.Windows.Forms.Label();
            this.lblMatrizB = new System.Windows.Forms.Label();
            this.txtMatrizA = new System.Windows.Forms.TextBox();
            this.txtMatrizB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(58, 138);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(195, 154);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblMatrizA
            // 
            this.lblMatrizA.AutoSize = true;
            this.lblMatrizA.Location = new System.Drawing.Point(282, 135);
            this.lblMatrizA.Name = "lblMatrizA";
            this.lblMatrizA.Size = new System.Drawing.Size(67, 20);
            this.lblMatrizA.TabIndex = 1;
            this.lblMatrizA.Text = "Matriz A";
            // 
            // lblMatrizB
            // 
            this.lblMatrizB.AutoSize = true;
            this.lblMatrizB.Location = new System.Drawing.Point(282, 225);
            this.lblMatrizB.Name = "lblMatrizB";
            this.lblMatrizB.Size = new System.Drawing.Size(67, 20);
            this.lblMatrizB.TabIndex = 2;
            this.lblMatrizB.Text = "Matriz B";
            // 
            // txtMatrizA
            // 
            this.txtMatrizA.Enabled = false;
            this.txtMatrizA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatrizA.Location = new System.Drawing.Point(286, 158);
            this.txtMatrizA.Name = "txtMatrizA";
            this.txtMatrizA.Size = new System.Drawing.Size(453, 44);
            this.txtMatrizA.TabIndex = 3;
            // 
            // txtMatrizB
            // 
            this.txtMatrizB.Enabled = false;
            this.txtMatrizB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatrizB.Location = new System.Drawing.Point(286, 248);
            this.txtMatrizB.Name = "txtMatrizB";
            this.txtMatrizB.Size = new System.Drawing.Size(453, 44);
            this.txtMatrizB.TabIndex = 4;
            // 
            // frmExercicio37
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 427);
            this.Controls.Add(this.txtMatrizB);
            this.Controls.Add(this.txtMatrizA);
            this.Controls.Add(this.lblMatrizB);
            this.Controls.Add(this.lblMatrizA);
            this.Controls.Add(this.btnIniciar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercicio37";
            this.Text = "Exercício 37";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblMatrizA;
        private System.Windows.Forms.Label lblMatrizB;
        private System.Windows.Forms.TextBox txtMatrizA;
        private System.Windows.Forms.TextBox txtMatrizB;
    }
}