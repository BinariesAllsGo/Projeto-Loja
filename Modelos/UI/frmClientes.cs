using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.BLL;
using Loja.Modelos;

namespace Loja.UI
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        public void AtualizaGrid()
        {
            ClientesBLL obj = new ClientesBLL();
            dgvClientes.DataSource = obj.Listagem();
   
            txtCodigo.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
            txtTelefone.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
        }
        
        private void frmClientes_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            txtNome.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Nome = txtNome.Text;
                cliente.Email = txtEmail.Text;
                cliente.Telefone = txtTelefone.Text;
                ClientesBLL obj = new ClientesBLL();
                obj.Incluir(cliente);
                MessageBox.Show("O cliente foi incluído com sucesso!");
                txtCodigo.Text = Convert.ToString(cliente.Codigo);
                AtualizaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado para alteração.");
            }
            else
                try
                {
                    Cliente cliente = new Cliente();
                    cliente.Codigo = int.Parse(txtCodigo.Text);
                    cliente.Nome = txtNome.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.Telefone = txtTelefone.Text;
                    ClientesBLL obj = new ClientesBLL();
                    obj.Alterar(cliente);
                    MessageBox.Show("O cliente foi alterado com sucesso!");
                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado antes da exclusão.");
            }
            else
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                ClientesBLL obj = new ClientesBLL();
                obj.Excluir(codigo);
                MessageBox.Show("O cliente foi excluído com sucesso!");
                AtualizaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
            txtTelefone.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
        }
    }
}
