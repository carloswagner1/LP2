namespace Peso_Ideal
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPesoAtual = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mskbxPesoAtual = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAltura = new System.Windows.Forms.MaskedTextBox();
            this.gbxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesoAtual
            // 
            this.lblPesoAtual.AutoSize = true;
            this.lblPesoAtual.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoAtual.Location = new System.Drawing.Point(532, 38);
            this.lblPesoAtual.Name = "lblPesoAtual";
            this.lblPesoAtual.Size = new System.Drawing.Size(143, 28);
            this.lblPesoAtual.TabIndex = 0;
            this.lblPesoAtual.Text = "Peso Atual";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(532, 124);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(89, 28);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura";
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFeminino.Location = new System.Drawing.Point(36, 34);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(117, 25);
            this.rbtnFeminino.TabIndex = 7;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            this.rbtnFeminino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtnFeminino_KeyPress);
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasculino.Location = new System.Drawing.Point(36, 71);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(125, 25);
            this.rbtnMasculino.TabIndex = 8;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            this.rbtnMasculino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtnMasculino_KeyPress);
            // 
            // gbxSexo
            // 
            this.gbxSexo.BackColor = System.Drawing.Color.Bisque;
            this.gbxSexo.Controls.Add(this.rbtnFeminino);
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSexo.Location = new System.Drawing.Point(532, 210);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(233, 119);
            this.gbxSexo.TabIndex = 9;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Bisque;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(523, 349);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(132, 64);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-135, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 450);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // mskbxPesoAtual
            // 
            this.mskbxPesoAtual.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxPesoAtual.Location = new System.Drawing.Point(532, 77);
            this.mskbxPesoAtual.Mask = "000.00";
            this.mskbxPesoAtual.Name = "mskbxPesoAtual";
            this.mskbxPesoAtual.Size = new System.Drawing.Size(212, 36);
            this.mskbxPesoAtual.TabIndex = 12;
            this.mskbxPesoAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskbxPesoAtual_KeyPress);
            // 
            // mskbxAltura
            // 
            this.mskbxAltura.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxAltura.Location = new System.Drawing.Point(532, 163);
            this.mskbxAltura.Mask = "0.00";
            this.mskbxAltura.Name = "mskbxAltura";
            this.mskbxAltura.Size = new System.Drawing.Size(212, 36);
            this.mskbxAltura.TabIndex = 13;
            this.mskbxAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskbxAltura_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mskbxAltura);
            this.Controls.Add(this.mskbxPesoAtual);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPesoAtual);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Peso Ideal";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesoAtual;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox mskbxPesoAtual;
        private System.Windows.Forms.MaskedTextBox mskbxAltura;
    }
}

