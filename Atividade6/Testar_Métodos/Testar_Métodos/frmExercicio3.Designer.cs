﻿namespace Testar_Métodos
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
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnRemover1 = new System.Windows.Forms.Button();
            this.btnRemover2 = new System.Windows.Forms.Button();
            this.btnInverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(204, 132);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(180, 29);
            this.txtPalavra1.TabIndex = 0;
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra1.Location = new System.Drawing.Point(64, 129);
            this.lblPalavra1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(128, 32);
            this.lblPalavra1.TabIndex = 1;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra2.Location = new System.Drawing.Point(417, 129);
            this.lblPalavra2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(128, 32);
            this.lblPalavra2.TabIndex = 2;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(557, 132);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(180, 29);
            this.txtPalavra2.TabIndex = 3;
            // 
            // btnRemover1
            // 
            this.btnRemover1.Location = new System.Drawing.Point(70, 252);
            this.btnRemover1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRemover1.Name = "btnRemover1";
            this.btnRemover1.Size = new System.Drawing.Size(198, 91);
            this.btnRemover1.TabIndex = 4;
            this.btnRemover1.Text = "Remover primeiro do segundo";
            this.btnRemover1.UseVisualStyleBackColor = true;
            this.btnRemover1.Click += new System.EventHandler(this.btnRemover1_Click);
            // 
            // btnRemover2
            // 
            this.btnRemover2.Location = new System.Drawing.Point(306, 252);
            this.btnRemover2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnRemover2.Name = "btnRemover2";
            this.btnRemover2.Size = new System.Drawing.Size(198, 91);
            this.btnRemover2.TabIndex = 5;
            this.btnRemover2.Text = "Remover primeiro do segundo(replace)";
            this.btnRemover2.UseVisualStyleBackColor = true;
            this.btnRemover2.Click += new System.EventHandler(this.btnRemover2_Click);
            // 
            // btnInverter
            // 
            this.btnInverter.Location = new System.Drawing.Point(539, 252);
            this.btnInverter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(198, 91);
            this.btnInverter.TabIndex = 6;
            this.btnInverter.Text = "Inverte Palavra";
            this.btnInverter.UseVisualStyleBackColor = true;
            this.btnInverter.Click += new System.EventHandler(this.btnInverter_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(822, 472);
            this.Controls.Add(this.btnInverter);
            this.Controls.Add(this.btnRemover2);
            this.Controls.Add(this.btnRemover1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.txtPalavra1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmExercicio3";
            this.Text = "Exercicio 3 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnRemover1;
        private System.Windows.Forms.Button btnRemover2;
        private System.Windows.Forms.Button btnInverter;
    }
}