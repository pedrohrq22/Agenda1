namespace Agnd
{
    partial class frmCompleto
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
            this.lblCódigo = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtNr = new System.Windows.Forms.TextBox();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaskTel = new System.Windows.Forms.MaskedTextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtMaskCep = new System.Windows.Forms.MaskedTextBox();
            this.gbDadosAgenda = new System.Windows.Forms.GroupBox();
            this.gbDadosAgenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo.Location = new System.Drawing.Point(9, 19);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(49, 15);
            this.lblCódigo.TabIndex = 0;
            this.lblCódigo.Text = "Código:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(4, 278);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(82, 35);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(513, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "*Campos Obrigatórios";
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(58, 16);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(49, 21);
            this.txtCod.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(65, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(368, 21);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(5, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(54, 16);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "*Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(463, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "*Telefone:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(5, 74);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(42, 16);
            this.lblCEP.TabIndex = 11;
            this.lblCEP.Text = "*Cep:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(143, 74);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(77, 16);
            this.lblEndereco.TabIndex = 12;
            this.lblEndereco.Text = "*Endereço:";
            this.lblEndereco.UseMnemonic = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(555, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "*Nº";
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnd.Location = new System.Drawing.Point(217, 72);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(216, 21);
            this.txtEnd.TabIndex = 5;
            // 
            // txtNr
            // 
            this.txtNr.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNr.Location = new System.Drawing.Point(580, 69);
            this.txtNr.Name = "txtNr";
            this.txtNr.Size = new System.Drawing.Size(67, 21);
            this.txtNr.TabIndex = 7;
            // 
            // cboUF
            // 
            this.cboUF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(483, 70);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(43, 23);
            this.cboUF.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(448, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "*UF:";
            // 
            // txtMaskTel
            // 
            this.txtMaskTel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaskTel.Location = new System.Drawing.Point(531, 32);
            this.txtMaskTel.Mask = "00 0000-0000";
            this.txtMaskTel.Name = "txtMaskTel";
            this.txtMaskTel.Size = new System.Drawing.Size(89, 21);
            this.txtMaskTel.TabIndex = 3;
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(282, 218);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(116, 38);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(592, 278);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 35);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBairro.Location = new System.Drawing.Point(5, 114);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(56, 16);
            this.lblBairro.TabIndex = 22;
            this.lblBairro.Text = "*Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(65, 112);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(261, 21);
            this.txtBairro.TabIndex = 8;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(351, 114);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(62, 16);
            this.lblCidade.TabIndex = 24;
            this.lblCidade.Text = "*Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(409, 112);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(238, 21);
            this.txtCidade.TabIndex = 9;
            // 
            // txtMaskCep
            // 
            this.txtMaskCep.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaskCep.Location = new System.Drawing.Point(65, 69);
            this.txtMaskCep.Mask = "00000-000";
            this.txtMaskCep.Name = "txtMaskCep";
            this.txtMaskCep.Size = new System.Drawing.Size(72, 21);
            this.txtMaskCep.TabIndex = 4;
            // 
            // gbDadosAgenda
            // 
            this.gbDadosAgenda.Controls.Add(this.txtEnd);
            this.gbDadosAgenda.Controls.Add(this.cboUF);
            this.gbDadosAgenda.Controls.Add(this.txtMaskTel);
            this.gbDadosAgenda.Controls.Add(this.txtNr);
            this.gbDadosAgenda.Controls.Add(this.label8);
            this.gbDadosAgenda.Controls.Add(this.label9);
            this.gbDadosAgenda.Controls.Add(this.txtCidade);
            this.gbDadosAgenda.Controls.Add(this.txtMaskCep);
            this.gbDadosAgenda.Controls.Add(this.label5);
            this.gbDadosAgenda.Controls.Add(this.lblCidade);
            this.gbDadosAgenda.Controls.Add(this.lblNome);
            this.gbDadosAgenda.Controls.Add(this.txtBairro);
            this.gbDadosAgenda.Controls.Add(this.lblCEP);
            this.gbDadosAgenda.Controls.Add(this.lblBairro);
            this.gbDadosAgenda.Controls.Add(this.lblEndereco);
            this.gbDadosAgenda.Controls.Add(this.txtNome);
            this.gbDadosAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosAgenda.Location = new System.Drawing.Point(4, 42);
            this.gbDadosAgenda.Name = "gbDadosAgenda";
            this.gbDadosAgenda.Size = new System.Drawing.Size(663, 156);
            this.gbDadosAgenda.TabIndex = 27;
            this.gbDadosAgenda.TabStop = false;
            this.gbDadosAgenda.Text = "Dados Agenda:";
            // 
            // frmCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(672, 316);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbDadosAgenda);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCódigo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGravar);
            this.MaximizeBox = false;
            this.Name = "frmCompleto";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCompleto_Load);
            this.gbDadosAgenda.ResumeLayout(false);
            this.gbDadosAgenda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblCódigo;
        public System.Windows.Forms.Button btnImprimir;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblCEP;
        public System.Windows.Forms.Label lblEndereco;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtEnd;
        public System.Windows.Forms.TextBox txtNr;
        public System.Windows.Forms.ComboBox cboUF;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.MaskedTextBox txtMaskTel;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Label lblBairro;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.Label lblCidade;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.MaskedTextBox txtMaskCep;
        public System.Windows.Forms.GroupBox gbDadosAgenda;

    }
}