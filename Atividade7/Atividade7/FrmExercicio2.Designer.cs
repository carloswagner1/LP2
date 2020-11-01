namespace Atividade7
{
    partial class frmExercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercicio2));
            this.lblExercicio2 = new System.Windows.Forms.Label();
            this.lblNumeroN = new System.Windows.Forms.Label();
            this.txtNumeroN = new System.Windows.Forms.TextBox();
            this.txtNumeroH = new System.Windows.Forms.TextBox();
            this.lblNumeroH = new System.Windows.Forms.Label();
            this.btnCalcularH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExercicio2
            // 
            this.lblExercicio2.AutoSize = true;
            this.lblExercicio2.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExercicio2.Location = new System.Drawing.Point(76, 43);
            this.lblExercicio2.Name = "lblExercicio2";
            this.lblExercicio2.Size = new System.Drawing.Size(178, 38);
            this.lblExercicio2.TabIndex = 0;
            this.lblExercicio2.Text = "Exercício 2";
            // 
            // lblNumeroN
            // 
            this.lblNumeroN.AutoSize = true;
            this.lblNumeroN.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroN.Location = new System.Drawing.Point(165, 113);
            this.lblNumeroN.Name = "lblNumeroN";
            this.lblNumeroN.Size = new System.Drawing.Size(148, 33);
            this.lblNumeroN.TabIndex = 1;
            this.lblNumeroN.Text = "Número N";
            // 
            // txtNumeroN
            // 
            this.txtNumeroN.Font = new System.Drawing.Font("Century", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroN.Location = new System.Drawing.Point(83, 149);
            this.txtNumeroN.Multiline = true;
            this.txtNumeroN.Name = "txtNumeroN";
            this.txtNumeroN.Size = new System.Drawing.Size(312, 72);
            this.txtNumeroN.TabIndex = 2;
            this.txtNumeroN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroN_KeyPress);
            // 
            // txtNumeroH
            // 
            this.txtNumeroH.BackColor = System.Drawing.Color.Bisque;
            this.txtNumeroH.Enabled = false;
            this.txtNumeroH.Font = new System.Drawing.Font("Century", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroH.Location = new System.Drawing.Point(421, 149);
            this.txtNumeroH.Multiline = true;
            this.txtNumeroH.Name = "txtNumeroH";
            this.txtNumeroH.Size = new System.Drawing.Size(312, 72);
            this.txtNumeroH.TabIndex = 3;
            this.txtNumeroH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNumeroH
            // 
            this.lblNumeroH.AutoSize = true;
            this.lblNumeroH.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroH.Location = new System.Drawing.Point(503, 113);
            this.lblNumeroH.Name = "lblNumeroH";
            this.lblNumeroH.Size = new System.Drawing.Size(148, 33);
            this.lblNumeroH.TabIndex = 4;
            this.lblNumeroH.Text = "Número H";
            // 
            // btnCalcularH
            // 
            this.btnCalcularH.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularH.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularH.Image")));
            this.btnCalcularH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcularH.Location = new System.Drawing.Point(323, 256);
            this.btnCalcularH.Name = "btnCalcularH";
            this.btnCalcularH.Size = new System.Drawing.Size(171, 137);
            this.btnCalcularH.TabIndex = 5;
            this.btnCalcularH.Text = "Calcular";
            this.btnCalcularH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcularH.UseVisualStyleBackColor = true;
            this.btnCalcularH.Click += new System.EventHandler(this.btnCalcularH_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(817, 448);
            this.Controls.Add(this.btnCalcularH);
            this.Controls.Add(this.lblNumeroH);
            this.Controls.Add(this.txtNumeroH);
            this.Controls.Add(this.txtNumeroN);
            this.Controls.Add(this.lblNumeroN);
            this.Controls.Add(this.lblExercicio2);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmExercicio2";
            this.Text = "Exercício 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExercicio2;
        private System.Windows.Forms.Label lblNumeroN;
        private System.Windows.Forms.TextBox txtNumeroN;
        private System.Windows.Forms.TextBox txtNumeroH;
        private System.Windows.Forms.Label lblNumeroH;
        private System.Windows.Forms.Button btnCalcularH;
    }
}