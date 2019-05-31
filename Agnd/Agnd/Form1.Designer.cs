namespace Agnd
{
    partial class FrmPrincipal
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
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblmenu = new System.Windows.Forms.Label();
            this.lblfiltros = new System.Windows.Forms.Label();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gbAgenda = new System.Windows.Forms.GroupBox();
            this.btnLimpaList = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbAgenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(85, 61);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(342, 20);
            this.txtDescricao.TabIndex = 0;
            // 
            // lblmenu
            // 
            this.lblmenu.AutoSize = true;
            this.lblmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenu.Location = new System.Drawing.Point(9, 293);
            this.lblmenu.Name = "lblmenu";
            this.lblmenu.Size = new System.Drawing.Size(68, 15);
            this.lblmenu.TabIndex = 1;
            this.lblmenu.Text = "M E N U :";
            // 
            // lblfiltros
            // 
            this.lblfiltros.AutoSize = true;
            this.lblfiltros.BackColor = System.Drawing.SystemColors.Control;
            this.lblfiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblfiltros.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltros.Location = new System.Drawing.Point(12, 16);
            this.lblfiltros.Name = "lblfiltros";
            this.lblfiltros.Size = new System.Drawing.Size(67, 25);
            this.lblfiltros.TabIndex = 2;
            this.lblfiltros.Text = "Filtros:";
            this.lblfiltros.UseMnemonic = false;
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescricao.Location = new System.Drawing.Point(9, 61);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(80, 18);
            this.lbldescricao.TabIndex = 3;
            this.lbldescricao.Text = "Descrição:";
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(65, 315);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(75, 23);
            this.btnnovo.TabIndex = 4;
            this.btnnovo.Text = "&Novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(146, 315);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(227, 315);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 23);
            this.btnalterar.TabIndex = 6;
            this.btnalterar.Text = "&Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(308, 315);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 7;
            this.btnexcluir.Text = "&Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Location = new System.Drawing.Point(6, 369);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(95, 23);
            this.btnRelatorio.TabIndex = 10;
            this.btnRelatorio.Text = "&R E L A T Ó R I O ";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 87);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(496, 183);
            this.dgv.TabIndex = 11;
            // 
            // gbAgenda
            // 
            this.gbAgenda.BackColor = System.Drawing.SystemColors.Control;
            this.gbAgenda.Controls.Add(this.btnLimpaList);
            this.gbAgenda.Controls.Add(this.btnSair);
            this.gbAgenda.Controls.Add(this.btnpesquisar);
            this.gbAgenda.Controls.Add(this.txtDescricao);
            this.gbAgenda.Controls.Add(this.lblmenu);
            this.gbAgenda.Controls.Add(this.btnRelatorio);
            this.gbAgenda.Controls.Add(this.dgv);
            this.gbAgenda.Controls.Add(this.btnnovo);
            this.gbAgenda.Controls.Add(this.btnConsultar);
            this.gbAgenda.Controls.Add(this.btnalterar);
            this.gbAgenda.Controls.Add(this.btnexcluir);
            this.gbAgenda.Controls.Add(this.lblfiltros);
            this.gbAgenda.Controls.Add(this.lbldescricao);
            this.gbAgenda.Location = new System.Drawing.Point(3, -14);
            this.gbAgenda.Name = "gbAgenda";
            this.gbAgenda.Size = new System.Drawing.Size(513, 398);
            this.gbAgenda.TabIndex = 12;
            this.gbAgenda.TabStop = false;
            this.gbAgenda.Text = "groupBox1";
            // 
            // btnLimpaList
            // 
            this.btnLimpaList.Location = new System.Drawing.Point(433, 276);
            this.btnLimpaList.Name = "btnLimpaList";
            this.btnLimpaList.Size = new System.Drawing.Size(75, 32);
            this.btnLimpaList.TabIndex = 15;
            this.btnLimpaList.Text = "Limpar Lista";
            this.btnLimpaList.UseVisualStyleBackColor = true;
            this.btnLimpaList.Click += new System.EventHandler(this.btnLimpaList_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(438, 363);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 35);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Location = new System.Drawing.Point(433, 56);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(75, 29);
            this.btnpesquisar.TabIndex = 13;
            this.btnpesquisar.Text = "&Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(520, 387);
            this.Controls.Add(this.gbAgenda);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbAgenda.ResumeLayout(false);
            this.gbAgenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblmenu;
        private System.Windows.Forms.Label lblfiltros;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox gbAgenda;
        private System.Windows.Forms.Button btnpesquisar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpaList;
    }
}

