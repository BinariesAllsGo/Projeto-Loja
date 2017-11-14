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
using Loja.DAL;
using Loja.Modelos;

namespace Loja.UI
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            VendasBLL obj = new VendasBLL();
            cmbCliente.DataSource = obj.ListaDeClientes;
            cmbProduto.DataSource = obj.ListaDeProdutos;
        }

        private void btnIncluirVenda_Click(object sender, EventArgs e)
        {
            try
            {
                Venda venda = new Venda();
                venda.Quantidade = int.Parse(txtQuantidade.Text);
                venda.CodigoCliente = (int)cmbCliente.SelectedValue;
                venda.CodigoProduto = (int)cmbProduto.SelectedValue;
                venda.Data = DateTime.Now;
                venda.Faturado = false;
                VendasBLL obj = new VendasBLL();
                obj.Incluir(venda);
                MessageBox.Show("A venda foi realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
