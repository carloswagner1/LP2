namespace Atividade7
{
    partial class frmExercicio4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercicio4));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblNumIncrição = new System.Windows.Forms.Label();
            this.lblSalário = new System.Windows.Forms.Label();
            this.lblGratificação = new System.Windows.Forms.Label();
            this.lblProdução = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtInscrição = new System.Windows.Forms.TextBox();
            this.txtSalário = new System.Windows.Forms.TextBox();
            this.txtGratificação = new System.Windows.Forms.TextBox();
            this.txtProdução = new System.Windows.Forms.TextBox();
            this.txtSalárioBruto = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(39, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(70, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(39, 107);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(70, 25);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Cargo";
            // 
            // lblNumIncrição
            // 
            this.lblNumIncrição.AutoSize = true;
            this.lblNumIncrição.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumIncrição.Location = new System.Drawing.Point(383, 107);
            this.lblNumIncrição.Name = "lblNumIncrição";
            this.lblNumIncrição.Size = new System.Drawing.Size(159, 25);
            this.lblNumIncrição.TabIndex = 2;
            this.lblNumIncrição.Text = "Nº de Inscrição";
            // 
            // lblSalário
            // 
            this.lblSalário.AutoSize = true;
            this.lblSalário.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalário.Location = new System.Drawing.Point(39, 165);
            this.lblSalário.Name = "lblSalário";
            this.lblSalário.Size = new System.Drawing.Size(83, 25);
            this.lblSalário.TabIndex = 3;
            this.lblSalário.Text = "Salário";
            // 
            // lblGratificação
            // 
            this.lblGratificação.AutoSize = true;
            this.lblGratificação.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGratificação.Location = new System.Drawing.Point(383, 165);
            this.lblGratificação.Name = "lblGratificação";
            this.lblGratificação.Size = new System.Drawing.Size(131, 25);
            this.lblGratificação.TabIndex = 4;
            this.lblGratificação.Text = "Gratificação";
            // 
            // lblProdução
            // 
            this.lblProdução.AutoSize = true;
            this.lblProdução.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdução.Location = new System.Drawing.Point(39, 223);
            this.lblProdução.Name = "lblProdução";
            this.lblProdução.Size = new System.Drawing.Size(103, 25);
            this.lblProdução.TabIndex = 5;
            this.lblProdução.Text = "Produção";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(541, 303);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(230, 38);
            this.lblSalarioBruto.TabIndex = 6;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(128, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(655, 30);
            this.txtNome.TabIndex = 7;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(128, 102);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(242, 30);
            this.txtCargo.TabIndex = 8;
            this.txtCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCargo_KeyPress);
            // 
            // txtInscrição
            // 
            this.txtInscrição.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInscrição.Location = new System.Drawing.Point(548, 102);
            this.txtInscrição.Name = "txtInscrição";
            this.txtInscrição.Size = new System.Drawing.Size(235, 30);
            this.txtInscrição.TabIndex = 9;
            this.txtInscrição.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInscrição_KeyPress);
            // 
            // txtSalário
            // 
            this.txtSalário.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalário.Location = new System.Drawing.Point(128, 160);
            this.txtSalário.Name = "txtSalário";
            this.txtSalário.Size = new System.Drawing.Size(242, 30);
            this.txtSalário.TabIndex = 10;
            this.txtSalário.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalário_KeyPress);
            // 
            // txtGratificação
            // 
            this.txtGratificação.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGratificação.Location = new System.Drawing.Point(548, 160);
            this.txtGratificação.Name = "txtGratificação";
            this.txtGratificação.Size = new System.Drawing.Size(235, 30);
            this.txtGratificação.TabIndex = 11;
            this.txtGratificação.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGratificação_KeyPress);
            // 
            // txtProdução
            // 
            this.txtProdução.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdução.Location = new System.Drawing.Point(148, 218);
            this.txtProdução.Name = "txtProdução";
            this.txtProdução.Size = new System.Drawing.Size(222, 30);
            this.txtProdução.TabIndex = 12;
            this.txtProdução.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProdução_KeyPress);
            // 
            // txtSalárioBruto
            // 
            this.txtSalárioBruto.Enabled = false;
            this.txtSalárioBruto.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalárioBruto.Location = new System.Drawing.Point(548, 344);
            this.txtSalárioBruto.Name = "txtSalárioBruto";
            this.txtSalárioBruto.Size = new System.Drawing.Size(235, 46);
            this.txtSalárioBruto.TabIndex = 13;
            this.txtSalárioBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(44, 282);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(306, 108);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular Salário Bruto";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(815, 448);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalárioBruto);
            this.Controls.Add(this.txtProdução);
            this.Controls.Add(this.txtGratificação);
            this.Controls.Add(this.txtSalário);
            this.Controls.Add(this.txtInscrição);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblProdução);
            this.Controls.Add(this.lblGratificação);
            this.Controls.Add(this.lblSalário);
            this.Controls.Add(this.lblNumIncrição);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmExercicio4";
            this.Text = "Exercício 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblNumIncrição;
        private System.Windows.Forms.Label lblSalário;
        private System.Windows.Forms.Label lblGratificação;
        private System.Windows.Forms.Label lblProdução;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtInscrição;
        private System.Windows.Forms.TextBox txtSalário;
        private System.Windows.Forms.TextBox txtGratificação;
        private System.Windows.Forms.TextBox txtProdução;
        private System.Windows.Forms.TextBox txtSalárioBruto;
        private System.Windows.Forms.Button btnCalcular;
    }
}