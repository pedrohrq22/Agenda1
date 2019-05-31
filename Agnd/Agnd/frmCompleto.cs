using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Oracle.DataAccess.Client;

namespace Agnd
{
    public partial class frmCompleto : Form
    {
        public frmCompleto()
        {
            InitializeComponent();
        }
        //==============================================           
        private void frmCompleto_Load(object sender, EventArgs e)
        {
            //txtCod.Text = "1";
            PreencherUF();
            txtNome.Focus();
            if (txtCod.Text != "")
            {
                clnAgenda ObjClnAgenda = new clnAgenda();
                ObjClnAgenda.Cod = Convert.ToInt16(txtCod.Text);
                OracleDataReader ObjDrDados;
                ObjDrDados = ObjClnAgenda.ListarUsuario();

                if (ObjDrDados.Read())
                {
                    txtNome.Text = ObjDrDados["nome"].ToString();
                    txtMaskTel.Text = ObjDrDados["tel"].ToString();
                    txtMaskCep.Text = ObjDrDados["cep"].ToString();
                    txtEnd.Text = ObjDrDados["endereco"].ToString();
                    cboUF.Text = ObjDrDados["UF"].ToString();
                    txtNr.Text = ObjDrDados["nr"].ToString();
                    txtBairro.Text = ObjDrDados["bairro"].ToString();
                    txtCidade.Text = ObjDrDados["cidade"].ToString();
                }
            }
            txtNome.Focus();
        }
        //============================================================
        public void PreencherUF()
        {
            clnAgenda objAgenda = new clnAgenda();
            cboUF.DataSource = objAgenda.PreencherUF().Tables[0];
            cboUF.ValueMember = "UF";
            cboUF.DisplayMember = "UF";
            cboUF.SelectedIndex = -1;
        }
        //============================================

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if  ((txtNome.Text == "") ||
                (txtMaskTel.Text == "") ||
                (txtNr.Text == "") ||
                (txtMaskCep.Text == "") ||
                (txtEnd.Text == "") ||
                (cboUF.Text == "") ||
                (txtBairro.Text == "") ||
                (txtCidade.Text == ""))
            {
                MessageBox.Show("Os Campos com * são Obrigatórios", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }
            else
            {
                clnAgenda Agenda = new clnAgenda();
                Agenda.Nome = txtNome.Text;
                Agenda.Tel = txtMaskTel.Text;
                Agenda.Nr = txtNr.Text;
                Agenda.Cep = txtMaskCep.Text;
                Agenda.Endereco = txtEnd.Text;
                Agenda.UF = cboUF.Text;
                Agenda.Bairro = txtBairro.Text;
                Agenda.Cidade = txtCidade.Text;

                if (txtCod.Text == "")
                {
                    Agenda.Gravar();
                    MessageBox.Show("Registro Gravado com Sucesso", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtCod.Text != "")
                {
                    Agenda.Cod = Convert.ToInt32(txtCod.Text);
                    Agenda.Alterar();
                    MessageBox.Show("Registro de número " + txtCod.Text + " alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            { Close(); }
        }
    }
}