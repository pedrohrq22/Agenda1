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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //CarregaDataGrid();
            btnalterar.Enabled = false;
            btnConsultar.Enabled = false;
            btnexcluir.Enabled = false;
            btnRelatorio.Enabled = false;
            btnLimpaList.Enabled = false;
        }

        public void CarregaDataGrid()
        {
            clnAgenda ObjAgenda = new clnAgenda();

            dgv.DataSource = ObjAgenda.Listar(txtDescricao.Text).Tables[0];

            dgv.Columns[0].HeaderText = ("Código");
            dgv.Columns[1].HeaderText = ("Cliente");
            dgv.Columns[2].HeaderText = ("Contatos");

            dgv.AutoResizeColumns();

            if (dgv.RowCount == 0)
            {
                btnRelatorio.Enabled = false;
                btnConsultar.Enabled = false;
                btnalterar.Enabled = false;
                btnexcluir.Enabled = false;
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: " + txtDescricao.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.DataSource = null;
                txtDescricao.Text = "";
                txtDescricao.Focus();
            }
            else
            btnRelatorio.Enabled = true;
            btnConsultar.Enabled = true;
            btnalterar.Enabled = true;
            btnexcluir.Enabled = true;
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            frmCompleto ObjCadastroAgenda = new frmCompleto();
            ObjCadastroAgenda.Text = ">>> Consultar <<<";
            ObjCadastroAgenda.btnGravar.Visible = false;
            ObjCadastroAgenda.gbDadosAgenda.Enabled = false;
            ObjCadastroAgenda.txtCod.Enabled = false;
            ObjCadastroAgenda.cboUF.DropDownStyle = ComboBoxStyle.DropDownList;
            ObjCadastroAgenda.txtCod.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            ObjCadastroAgenda.ShowDialog();
            CarregaDataGrid();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            frmCompleto objCadastroAgenda = new frmCompleto();
            objCadastroAgenda.Text = ">>> Novo Cadastro <<<";
            objCadastroAgenda.txtCod.Enabled = false;
            objCadastroAgenda.ShowDialog();
            CarregaDataGrid();
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            frmCompleto objCadastroAgenda = new frmCompleto();
            objCadastroAgenda.Text = ">>> Alterar <<<";
            objCadastroAgenda.txtCod.Enabled = false;
            objCadastroAgenda.btnGravar.Text = "&Alterar";
            objCadastroAgenda.txtCod.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            objCadastroAgenda.txtNome.Focus();
            objCadastroAgenda.ShowDialog();
            CarregaDataGrid();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir o registro? " + Convert.ToString(dgv.CurrentRow.Cells[0].Value),
            "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (DialogResult.Yes == resultado)
            {
                clnAgenda ObjAgenda = new clnAgenda();
                ObjAgenda.Cod = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
                ObjAgenda.ExcluirLogicamente();
                MessageBox.Show("Registro excluído com sucesso.", "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("OPERAÇÃO CANCELADA", " CANCELAMENTO DE E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregaDataGrid();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            CarregaDataGrid();
            btnalterar.Enabled = true;
            btnConsultar.Enabled = true;
            btnexcluir.Enabled = true;
            btnRelatorio.Enabled = true;
            btnLimpaList.Enabled = true;
        }
        private void btnLimpaList_Click(object sender, EventArgs e)
        {
            dgv.Columns.Clear();
            btnalterar.Enabled = false;
            btnConsultar.Enabled = false;
            btnexcluir.Enabled = false;
            btnRelatorio.Enabled = false;
            btnLimpaList.Enabled = false;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
             Close();
        }

       
    }
}