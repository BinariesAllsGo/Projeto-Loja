using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.DAL;
using Loja.BLL;
using Loja.Modelos;

namespace Loja.UI
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        public void AtualizaGrid()
        {
            ProdutosBLL obj = new ProdutosBLL();
            dgvProdutos.DataSource = obj.Listagem();
            txtCodigo.Text = dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgvProdutos[1, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtPreco.Text = dgvProdutos[2, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtEstoque.Text = dgvProdutos[3, dgvProdutos.CurrentRow.Index].Value.ToString();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            txtNome.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtPreco.Text = "";
            txtEstoque.Text = "";
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Produto produto = new Produto();
                produto.Nome = txtNome.Text;
                produto.Preco = Convert.ToDecimal(txtPreco.Text);
                produto.Estoque = Convert.ToInt32(txtEstoque.Text);
                ProdutosBLL obj = new ProdutosBLL();
                obj.Incluir(produto);
                MessageBox.Show("O produto foi incluído com sucesso!");
                txtCodigo.Text = Convert.ToString(produto.Codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            AtualizaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Um produto precisa ser selecionado para alteração.");
            }
            else
                try
                {
                    Produto produto = new Produto();
                    produto.Codigo = int.Parse(txtCodigo.Text);
                    produto.Nome = txtNome.Text;
                    produto.Preco = Convert.ToDecimal(txtPreco.Text);
                    produto.Estoque = Convert.ToInt32(txtEstoque.Text);
                    ProdutosBLL obj = new ProdutosBLL();
                    obj.Alterar(produto);
                    MessageBox.Show("O produto foi atualizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            AtualizaGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Um produto deve ser selecionado antes da exclusão.");
            }
            else
                try
                {
                    int codigo = Convert.ToInt32(txtCodigo.Text);
                    ProdutosBLL obj = new ProdutosBLL();
                    obj.Excluir(codigo);
                    MessageBox.Show("O produto foi excluído com sucesso!");
                    AtualizaGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            AtualizaGrid();
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgvProdutos[1, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtPreco.Text = dgvProdutos[2, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtEstoque.Text = dgvProdutos[3, dgvProdutos.CurrentRow.Index].Value.ToString();
        }
    }
}
