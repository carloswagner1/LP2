namespace Salário_e_Descontos
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lbl_SalarioFamilia = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.lbl_IRRF = new System.Windows.Forms.Label();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lbl_SalárioLíquido = new System.Windows.Forms.Label();
            this.lbl_DescontoINSS = new System.Windows.Forms.Label();
            this.lbl_DescontoIRPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.gbxEstadoCivil = new System.Windows.Forms.GroupBox();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.ckbxSolteiro = new System.Windows.Forms.CheckBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.mskbxSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.gbxDados = new System.Windows.Forms.GroupBox();
            this.mskbxNumeroFilhos = new System.Windows.Forms.MaskedTextBox();
            this.gbxResultados = new System.Windows.Forms.GroupBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.mskbxAliquotaIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxAliquotaINSS = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalarioLiquido = new System.Windows.Forms.MaskedTextBox();
            this.mskbxSalarioFamilia = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescontoIRPF = new System.Windows.Forms.MaskedTextBox();
            this.mskbxDescontoINSS = new System.Windows.Forms.MaskedTextBox();
            this.gbxSexo.SuspendLayout();
            this.gbxEstadoCivil.SuspendLayout();
            this.gbxDados.SuspendLayout();
            this.gbxResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(14, 31);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(143, 23);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Completo";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(14, 73);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(117, 23);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Salário Bruto";
            // 
            // lbl_SalarioFamilia
            // 
            this.lbl_SalarioFamilia.AutoSize = true;
            this.lbl_SalarioFamilia.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalarioFamilia.Location = new System.Drawing.Point(14, 114);
            this.lbl_SalarioFamilia.Name = "lbl_SalarioFamilia";
            this.lbl_SalarioFamilia.Size = new System.Drawing.Size(130, 23);
            this.lbl_SalarioFamilia.TabIndex = 2;
            this.lbl_SalarioFamilia.Text = "Salário Família";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilhos.Location = new System.Drawing.Point(14, 115);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(157, 23);
            this.lblFilhos.TabIndex = 3;
            this.lblFilhos.Text = "Número de Filhos";
            // 
            // lbl_IRRF
            // 
            this.lbl_IRRF.AutoSize = true;
            this.lbl_IRRF.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IRRF.Location = new System.Drawing.Point(358, 74);
            this.lbl_IRRF.Name = "lbl_IRRF";
            this.lbl_IRRF.Size = new System.Drawing.Size(122, 23);
            this.lbl_IRRF.TabIndex = 4;
            this.lbl_IRRF.Text = "Alíquota IRPF";
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINSS.Location = new System.Drawing.Point(358, 34);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(125, 23);
            this.lblINSS.TabIndex = 5;
            this.lblINSS.Text = "Alíquota INSS";
            // 
            // lbl_SalárioLíquido
            // 
            this.lbl_SalárioLíquido.AutoSize = true;
            this.lbl_SalárioLíquido.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SalárioLíquido.Location = new System.Drawing.Point(14, 154);
            this.lbl_SalárioLíquido.Name = "lbl_SalárioLíquido";
            this.lbl_SalárioLíquido.Size = new System.Drawing.Size(132, 23);
            this.lbl_SalárioLíquido.TabIndex = 6;
            this.lbl_SalárioLíquido.Text = "Salário Líquido";
            // 
            // lbl_DescontoINSS
            // 
            this.lbl_DescontoINSS.AutoSize = true;
            this.lbl_DescontoINSS.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescontoINSS.Location = new System.Drawing.Point(14, 34);
            this.lbl_DescontoINSS.Name = "lbl_DescontoINSS";
            this.lbl_DescontoINSS.Size = new System.Drawing.Size(135, 23);
            this.lbl_DescontoINSS.TabIndex = 7;
            this.lbl_DescontoINSS.Text = "Desconto INSS";
            // 
            // lbl_DescontoIRPF
            // 
            this.lbl_DescontoIRPF.AutoSize = true;
            this.lbl_DescontoIRPF.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescontoIRPF.Location = new System.Drawing.Point(14, 74);
            this.lbl_DescontoIRPF.Name = "lbl_DescontoIRPF";
            this.lbl_DescontoIRPF.Size = new System.Drawing.Size(132, 23);
            this.lbl_DescontoIRPF.TabIndex = 8;
            this.lbl_DescontoIRPF.Text = "Desconto IRPF";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(177, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(580, 27);
            this.txtNome.TabIndex = 9;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasculino);
            this.gbxSexo.Controls.Add(this.rbtnFeminino);
            this.gbxSexo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSexo.Location = new System.Drawing.Point(451, 60);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(142, 79);
            this.gbxSexo.TabIndex = 18;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasculino.Location = new System.Drawing.Point(28, 47);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(96, 23);
            this.rbtnMasculino.TabIndex = 1;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFeminino.Location = new System.Drawing.Point(28, 24);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(92, 23);
            this.rbtnFeminino.TabIndex = 0;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // gbxEstadoCivil
            // 
            this.gbxEstadoCivil.Controls.Add(this.ckbxCasado);
            this.gbxEstadoCivil.Controls.Add(this.ckbxSolteiro);
            this.gbxEstadoCivil.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEstadoCivil.Location = new System.Drawing.Point(615, 60);
            this.gbxEstadoCivil.Name = "gbxEstadoCivil";
            this.gbxEstadoCivil.Size = new System.Drawing.Size(142, 79);
            this.gbxEstadoCivil.TabIndex = 19;
            this.gbxEstadoCivil.TabStop = false;
            this.gbxEstadoCivil.Text = "Estado Civil";
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxCasado.Location = new System.Drawing.Point(28, 48);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(99, 23);
            this.ckbxCasado.TabIndex = 1;
            this.ckbxCasado.Text = "Casado(a)";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // ckbxSolteiro
            // 
            this.ckbxSolteiro.AutoSize = true;
            this.ckbxSolteiro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxSolteiro.Location = new System.Drawing.Point(28, 25);
            this.ckbxSolteiro.Name = "ckbxSolteiro";
            this.ckbxSolteiro.Size = new System.Drawing.Size(102, 23);
            this.ckbxSolteiro.TabIndex = 0;
            this.ckbxSolteiro.Text = "Solteiro(a)";
            this.ckbxSolteiro.UseVisualStyleBackColor = true;
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.Linen;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Image = ((System.Drawing.Image)(resources.GetObject("btnValidar.Image")));
            this.btnValidar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnValidar.Location = new System.Drawing.Point(719, 258);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(78, 71);
            this.btnValidar.TabIndex = 20;
            this.btnValidar.Text = "Validar";
            this.btnValidar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Linen;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(719, 354);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(78, 70);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btn_Click);
            // 
            // mskbxSalarioBruto
            // 
            this.mskbxSalarioBruto.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mskbxSalarioBruto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalarioBruto.Location = new System.Drawing.Point(177, 69);
            this.mskbxSalarioBruto.Mask = "$00000.00";
            this.mskbxSalarioBruto.Name = "mskbxSalarioBruto";
            this.mskbxSalarioBruto.Size = new System.Drawing.Size(185, 27);
            this.mskbxSalarioBruto.TabIndex = 10;
            this.mskbxSalarioBruto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // gbxDados
            // 
            this.gbxDados.Controls.Add(this.mskbxNumeroFilhos);
            this.gbxDados.Controls.Add(this.lblNome);
            this.gbxDados.Controls.Add(this.txtNome);
            this.gbxDados.Controls.Add(this.mskbxSalarioBruto);
            this.gbxDados.Controls.Add(this.lblSalario);
            this.gbxDados.Controls.Add(this.gbxEstadoCivil);
            this.gbxDados.Controls.Add(this.lblFilhos);
            this.gbxDados.Controls.Add(this.gbxSexo);
            this.gbxDados.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDados.Location = new System.Drawing.Point(12, 33);
            this.gbxDados.Name = "gbxDados";
            this.gbxDados.Size = new System.Drawing.Size(785, 155);
            this.gbxDados.TabIndex = 26;
            this.gbxDados.TabStop = false;
            this.gbxDados.Text = "Dados do Funcionário";
            // 
            // mskbxNumeroFilhos
            // 
            this.mskbxNumeroFilhos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxNumeroFilhos.Location = new System.Drawing.Point(177, 111);
            this.mskbxNumeroFilhos.Mask = "00";
            this.mskbxNumeroFilhos.Name = "mskbxNumeroFilhos";
            this.mskbxNumeroFilhos.Size = new System.Drawing.Size(185, 27);
            this.mskbxNumeroFilhos.TabIndex = 11;
            // 
            // gbxResultados
            // 
            this.gbxResultados.Controls.Add(this.lblMensagem);
            this.gbxResultados.Controls.Add(this.mskbxAliquotaIRPF);
            this.gbxResultados.Controls.Add(this.mskbxAliquotaINSS);
            this.gbxResultados.Controls.Add(this.mskbxSalarioLiquido);
            this.gbxResultados.Controls.Add(this.mskbxSalarioFamilia);
            this.gbxResultados.Controls.Add(this.mskbxDescontoIRPF);
            this.gbxResultados.Controls.Add(this.mskbxDescontoINSS);
            this.gbxResultados.Controls.Add(this.lbl_DescontoINSS);
            this.gbxResultados.Controls.Add(this.lbl_DescontoIRPF);
            this.gbxResultados.Controls.Add(this.lbl_SalarioFamilia);
            this.gbxResultados.Controls.Add(this.lbl_SalárioLíquido);
            this.gbxResultados.Controls.Add(this.lbl_IRRF);
            this.gbxResultados.Controls.Add(this.lblINSS);
            this.gbxResultados.Enabled = false;
            this.gbxResultados.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxResultados.Location = new System.Drawing.Point(12, 224);
            this.gbxResultados.Name = "gbxResultados";
            this.gbxResultados.Size = new System.Drawing.Size(701, 200);
            this.gbxResultados.TabIndex = 27;
            this.gbxResultados.TabStop = false;
            this.gbxResultados.Text = "Resultados Apurados";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(358, 110);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(84, 19);
            this.lblMensagem.TabIndex = 27;
            this.lblMensagem.Text = "Mensagem";
            // 
            // mskbxAliquotaIRPF
            // 
            this.mskbxAliquotaIRPF.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxAliquotaIRPF.Location = new System.Drawing.Point(489, 70);
            this.mskbxAliquotaIRPF.Name = "mskbxAliquotaIRPF";
            this.mskbxAliquotaIRPF.Size = new System.Drawing.Size(141, 27);
            this.mskbxAliquotaIRPF.TabIndex = 26;
            // 
            // mskbxAliquotaINSS
            // 
            this.mskbxAliquotaINSS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxAliquotaINSS.Location = new System.Drawing.Point(489, 29);
            this.mskbxAliquotaINSS.Name = "mskbxAliquotaINSS";
            this.mskbxAliquotaINSS.Size = new System.Drawing.Size(141, 27);
            this.mskbxAliquotaINSS.TabIndex = 16;
            // 
            // mskbxSalarioLiquido
            // 
            this.mskbxSalarioLiquido.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalarioLiquido.Location = new System.Drawing.Point(164, 150);
            this.mskbxSalarioLiquido.Name = "mskbxSalarioLiquido";
            this.mskbxSalarioLiquido.Size = new System.Drawing.Size(162, 27);
            this.mskbxSalarioLiquido.TabIndex = 15;
            // 
            // mskbxSalarioFamilia
            // 
            this.mskbxSalarioFamilia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxSalarioFamilia.Location = new System.Drawing.Point(164, 110);
            this.mskbxSalarioFamilia.Name = "mskbxSalarioFamilia";
            this.mskbxSalarioFamilia.Size = new System.Drawing.Size(162, 27);
            this.mskbxSalarioFamilia.TabIndex = 14;
            // 
            // mskbxDescontoIRPF
            // 
            this.mskbxDescontoIRPF.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxDescontoIRPF.Location = new System.Drawing.Point(164, 70);
            this.mskbxDescontoIRPF.Name = "mskbxDescontoIRPF";
            this.mskbxDescontoIRPF.Size = new System.Drawing.Size(162, 27);
            this.mskbxDescontoIRPF.TabIndex = 13;
            // 
            // mskbxDescontoINSS
            // 
            this.mskbxDescontoINSS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskbxDescontoINSS.Location = new System.Drawing.Point(164, 30);
            this.mskbxDescontoINSS.Name = "mskbxDescontoINSS";
            this.mskbxDescontoINSS.Size = new System.Drawing.Size(162, 27);
            this.mskbxDescontoINSS.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 445);
            this.Controls.Add(this.gbxResultados);
            this.Controls.Add(this.gbxDados);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnValidar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Salário e Descontos";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.gbxEstadoCivil.ResumeLayout(false);
            this.gbxEstadoCivil.PerformLayout();
            this.gbxDados.ResumeLayout(false);
            this.gbxDados.PerformLayout();
            this.gbxResultados.ResumeLayout(false);
            this.gbxResultados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lbl_SalarioFamilia;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.Label lbl_IRRF;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lbl_SalárioLíquido;
        private System.Windows.Forms.Label lbl_DescontoINSS;
        private System.Windows.Forms.Label lbl_DescontoIRPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.GroupBox gbxEstadoCivil;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.CheckBox ckbxSolteiro;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioBruto;
        private System.Windows.Forms.GroupBox gbxDados;
        private System.Windows.Forms.GroupBox gbxResultados;
        private System.Windows.Forms.MaskedTextBox mskbxNumeroFilhos;
        private System.Windows.Forms.MaskedTextBox mskbxDescontoINSS;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.MaskedTextBox mskbxAliquotaIRPF;
        private System.Windows.Forms.MaskedTextBox mskbxAliquotaINSS;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioLiquido;
        private System.Windows.Forms.MaskedTextBox mskbxSalarioFamilia;
        private System.Windows.Forms.MaskedTextBox mskbxDescontoIRPF;
    }
}

