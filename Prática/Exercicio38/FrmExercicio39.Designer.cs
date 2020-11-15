namespace Exercicio38
{
    partial class frmExercicio39
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.cbxIdade = new System.Windows.Forms.ComboBox();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.ckbxFeminino = new System.Windows.Forms.CheckBox();
            this.ckbxMasculino = new System.Windows.Forms.CheckBox();
            this.gbxEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbtnOutros = new System.Windows.Forms.RadioButton();
            this.rbtnDivorciado = new System.Windows.Forms.RadioButton();
            this.rbtnViuvo = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.rbtnSolteiro = new System.Windows.Forms.RadioButton();
            this.lblDistância = new System.Windows.Forms.Label();
            this.lstbxDistancia = new System.Windows.Forms.ListBox();
            this.gbxExperienciaAnterior = new System.Windows.Forms.GroupBox();
            this.cbxTempoDeExperiencia = new System.Windows.Forms.ComboBox();
            this.lblTempoDeExperencia = new System.Windows.Forms.Label();
            this.txtNomedaEmpresa = new System.Windows.Forms.TextBox();
            this.lblNomeDaEmpresa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskbxPretensao = new System.Windows.Forms.MaskedTextBox();
            this.btnCandidatar = new System.Windows.Forms.Button();
            this.gbxSexo.SuspendLayout();
            this.gbxEstadoCivil.SuspendLayout();
            this.gbxExperienciaAnterior.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(76, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(123, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Completo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(80, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(641, 26);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(76, 84);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(80, 107);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(167, 26);
            this.txtTelefone.TabIndex = 3;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(76, 151);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(50, 20);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "Idade";
            // 
            // cbxIdade
            // 
            this.cbxIdade.DisplayMember = "18";
            this.cbxIdade.FormattingEnabled = true;
            this.cbxIdade.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75"});
            this.cbxIdade.Location = new System.Drawing.Point(80, 176);
            this.cbxIdade.Name = "cbxIdade";
            this.cbxIdade.Size = new System.Drawing.Size(61, 28);
            this.cbxIdade.TabIndex = 5;
            this.cbxIdade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxIdade_KeyPress);
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.ckbxFeminino);
            this.gbxSexo.Controls.Add(this.ckbxMasculino);
            this.gbxSexo.Location = new System.Drawing.Point(289, 84);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(126, 87);
            this.gbxSexo.TabIndex = 6;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // ckbxFeminino
            // 
            this.ckbxFeminino.AutoSize = true;
            this.ckbxFeminino.Location = new System.Drawing.Point(7, 55);
            this.ckbxFeminino.Name = "ckbxFeminino";
            this.ckbxFeminino.Size = new System.Drawing.Size(93, 24);
            this.ckbxFeminino.TabIndex = 1;
            this.ckbxFeminino.Text = "Feminino";
            this.ckbxFeminino.UseVisualStyleBackColor = true;
            this.ckbxFeminino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ckbxFeminino_KeyPress);
            // 
            // ckbxMasculino
            // 
            this.ckbxMasculino.AutoSize = true;
            this.ckbxMasculino.Checked = true;
            this.ckbxMasculino.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbxMasculino.Location = new System.Drawing.Point(7, 27);
            this.ckbxMasculino.Name = "ckbxMasculino";
            this.ckbxMasculino.Size = new System.Drawing.Size(99, 24);
            this.ckbxMasculino.TabIndex = 0;
            this.ckbxMasculino.Text = "Masculino";
            this.ckbxMasculino.UseVisualStyleBackColor = true;
            this.ckbxMasculino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ckbxMasculino_KeyPress);
            // 
            // gbxEstadoCivil
            // 
            this.gbxEstadoCivil.Controls.Add(this.rbtnOutros);
            this.gbxEstadoCivil.Controls.Add(this.rbtnDivorciado);
            this.gbxEstadoCivil.Controls.Add(this.rbtnViuvo);
            this.gbxEstadoCivil.Controls.Add(this.rbtnCasado);
            this.gbxEstadoCivil.Controls.Add(this.rbtnSolteiro);
            this.gbxEstadoCivil.Location = new System.Drawing.Point(459, 84);
            this.gbxEstadoCivil.Name = "gbxEstadoCivil";
            this.gbxEstadoCivil.Size = new System.Drawing.Size(262, 115);
            this.gbxEstadoCivil.TabIndex = 7;
            this.gbxEstadoCivil.TabStop = false;
            this.gbxEstadoCivil.Text = "Estado Civil";
            // 
            // rbtnOutros
            // 
            this.rbtnOutros.AutoSize = true;
            this.rbtnOutros.Location = new System.Drawing.Point(128, 56);
            this.rbtnOutros.Name = "rbtnOutros";
            this.rbtnOutros.Size = new System.Drawing.Size(75, 24);
            this.rbtnOutros.TabIndex = 4;
            this.rbtnOutros.Text = "Outros";
            this.rbtnOutros.UseVisualStyleBackColor = true;
            this.rbtnOutros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtnOutros_KeyPress);
            // 
            // rbtnDivorciado
            // 
            this.rbtnDivorciado.AutoSize = true;
            this.rbtnDivorciado.Location = new System.Drawing.Point(128, 25);
            this.rbtnDivorciado.Name = "rbtnDivorciado";
            this.rbtnDivorciado.Size = new System.Drawing.Size(120, 24);
            this.rbtnDivorciado.TabIndex = 3;
            this.rbtnDivorciado.Text = "Divorciado(a)";
            this.rbtnDivorciado.UseVisualStyleBackColor = true;
            this.rbtnDivorciado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtnDIvorciado_KeyPress);
            // 
            // rbtnViuvo
            // 
            this.rbtnViuvo.AutoSize = true;
            this.rbtnViuvo.Location = new System.Drawing.Point(7, 85);
            this.rbtnViuvo.Name = "rbtnViuvo";
            this.rbtnViuvo.Size = new System.Drawing.Size(85, 24);
            this.rbtnViuvo.TabIndex = 2;
            this.rbtnViuvo.Text = "Viúvo(a)";
            this.rbtnViuvo.UseVisualStyleBackColor = true;
            this.rbtnViuvo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtnViuvo_KeyPress);
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Location = new System.Drawing.Point(7, 56);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(101, 24);
            this.rbtnCasado.TabIndex = 1;
            this.rbtnCasado.Text = "Casado(a)";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            this.rbtnCasado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtnCasado_KeyPress);
            // 
            // rbtnSolteiro
            // 
            this.rbtnSolteiro.AutoSize = true;
            this.rbtnSolteiro.Checked = true;
            this.rbtnSolteiro.Location = new System.Drawing.Point(7, 26);
            this.rbtnSolteiro.Name = "rbtnSolteiro";
            this.rbtnSolteiro.Size = new System.Drawing.Size(100, 24);
            this.rbtnSolteiro.TabIndex = 0;
            this.rbtnSolteiro.TabStop = true;
            this.rbtnSolteiro.Text = "Solteiro(a)";
            this.rbtnSolteiro.UseVisualStyleBackColor = true;
            this.rbtnSolteiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbtnSolteiro_KeyPress);
            // 
            // lblDistância
            // 
            this.lblDistância.AutoSize = true;
            this.lblDistância.Location = new System.Drawing.Point(76, 220);
            this.lblDistância.Name = "lblDistância";
            this.lblDistância.Size = new System.Drawing.Size(258, 20);
            this.lblDistância.TabIndex = 8;
            this.lblDistância.Text = "Distância entre Empresa e Moradia";
            // 
            // lstbxDistancia
            // 
            this.lstbxDistancia.FormattingEnabled = true;
            this.lstbxDistancia.ItemHeight = 20;
            this.lstbxDistancia.Items.AddRange(new object[] {
            "Até 20 km",
            "Entre 21 e 50 km",
            "Entre 51 e 100 km",
            "maior que 100 km"});
            this.lstbxDistancia.Location = new System.Drawing.Point(80, 243);
            this.lstbxDistancia.Name = "lstbxDistancia";
            this.lstbxDistancia.Size = new System.Drawing.Size(254, 84);
            this.lstbxDistancia.TabIndex = 9;
            this.lstbxDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstbxDistancia_KeyPress);
            // 
            // gbxExperienciaAnterior
            // 
            this.gbxExperienciaAnterior.Controls.Add(this.cbxTempoDeExperiencia);
            this.gbxExperienciaAnterior.Controls.Add(this.lblTempoDeExperencia);
            this.gbxExperienciaAnterior.Controls.Add(this.txtNomedaEmpresa);
            this.gbxExperienciaAnterior.Controls.Add(this.lblNomeDaEmpresa);
            this.gbxExperienciaAnterior.Location = new System.Drawing.Point(351, 205);
            this.gbxExperienciaAnterior.Name = "gbxExperienciaAnterior";
            this.gbxExperienciaAnterior.Size = new System.Drawing.Size(370, 143);
            this.gbxExperienciaAnterior.TabIndex = 12;
            this.gbxExperienciaAnterior.TabStop = false;
            this.gbxExperienciaAnterior.Text = "Experiência Anterior";
            // 
            // cbxTempoDeExperiencia
            // 
            this.cbxTempoDeExperiencia.FormattingEnabled = true;
            this.cbxTempoDeExperiencia.Items.AddRange(new object[] {
            "Até um ano",
            "De um a dois anos",
            "De dois a três anos",
            "De três a cinco anos",
            "Mais de 5 anos"});
            this.cbxTempoDeExperiencia.Location = new System.Drawing.Point(10, 104);
            this.cbxTempoDeExperiencia.Name = "cbxTempoDeExperiencia";
            this.cbxTempoDeExperiencia.Size = new System.Drawing.Size(121, 28);
            this.cbxTempoDeExperiencia.TabIndex = 3;
            this.cbxTempoDeExperiencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxTempoDeExperiencia_KeyPress);
            // 
            // lblTempoDeExperencia
            // 
            this.lblTempoDeExperencia.AutoSize = true;
            this.lblTempoDeExperencia.Location = new System.Drawing.Point(6, 81);
            this.lblTempoDeExperencia.Name = "lblTempoDeExperencia";
            this.lblTempoDeExperencia.Size = new System.Drawing.Size(166, 20);
            this.lblTempoDeExperencia.TabIndex = 2;
            this.lblTempoDeExperencia.Text = "Tempo de Experiência";
            // 
            // txtNomedaEmpresa
            // 
            this.txtNomedaEmpresa.Location = new System.Drawing.Point(10, 52);
            this.txtNomedaEmpresa.Name = "txtNomedaEmpresa";
            this.txtNomedaEmpresa.Size = new System.Drawing.Size(345, 26);
            this.txtNomedaEmpresa.TabIndex = 1;
            this.txtNomedaEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomedaEmpresa_KeyPress);
            // 
            // lblNomeDaEmpresa
            // 
            this.lblNomeDaEmpresa.AutoSize = true;
            this.lblNomeDaEmpresa.Location = new System.Drawing.Point(6, 29);
            this.lblNomeDaEmpresa.Name = "lblNomeDaEmpresa";
            this.lblNomeDaEmpresa.Size = new System.Drawing.Size(139, 20);
            this.lblNomeDaEmpresa.TabIndex = 0;
            this.lblNomeDaEmpresa.Text = "Nome da empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pretensão Salarial (R$)";
            // 
            // mskbxPretensao
            // 
            this.mskbxPretensao.Location = new System.Drawing.Point(80, 368);
            this.mskbxPretensao.Mask = "0000.00";
            this.mskbxPretensao.Name = "mskbxPretensao";
            this.mskbxPretensao.Size = new System.Drawing.Size(167, 26);
            this.mskbxPretensao.TabIndex = 11;
            this.mskbxPretensao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskbxPretensao_KeyPress);
            // 
            // btnCandidatar
            // 
            this.btnCandidatar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCandidatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCandidatar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCandidatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidatar.Location = new System.Drawing.Point(479, 354);
            this.btnCandidatar.Name = "btnCandidatar";
            this.btnCandidatar.Size = new System.Drawing.Size(242, 39);
            this.btnCandidatar.TabIndex = 13;
            this.btnCandidatar.Text = "Candidatar-se";
            this.btnCandidatar.UseVisualStyleBackColor = false;
            this.btnCandidatar.Click += new System.EventHandler(this.btnCandidatar_Click);
            // 
            // frmExercicio39
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.btnCandidatar);
            this.Controls.Add(this.mskbxPretensao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxExperienciaAnterior);
            this.Controls.Add(this.lstbxDistancia);
            this.Controls.Add(this.lblDistância);
            this.Controls.Add(this.gbxEstadoCivil);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.cbxIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmExercicio39";
            this.Text = "Exercício 39";
            this.Load += new System.EventHandler(this.frmExercicio39_Load);
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.gbxEstadoCivil.ResumeLayout(false);
            this.gbxEstadoCivil.PerformLayout();
            this.gbxExperienciaAnterior.ResumeLayout(false);
            this.gbxExperienciaAnterior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.ComboBox cbxIdade;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.CheckBox ckbxFeminino;
        private System.Windows.Forms.CheckBox ckbxMasculino;
        private System.Windows.Forms.GroupBox gbxEstadoCivil;
        private System.Windows.Forms.RadioButton rbtnOutros;
        private System.Windows.Forms.RadioButton rbtnDivorciado;
        private System.Windows.Forms.RadioButton rbtnViuvo;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.RadioButton rbtnSolteiro;
        private System.Windows.Forms.Label lblDistância;
        private System.Windows.Forms.ListBox lstbxDistancia;
        private System.Windows.Forms.GroupBox gbxExperienciaAnterior;
        private System.Windows.Forms.ComboBox cbxTempoDeExperiencia;
        private System.Windows.Forms.Label lblTempoDeExperencia;
        private System.Windows.Forms.TextBox txtNomedaEmpresa;
        private System.Windows.Forms.Label lblNomeDaEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskbxPretensao;
        private System.Windows.Forms.Button btnCandidatar;
    }
}