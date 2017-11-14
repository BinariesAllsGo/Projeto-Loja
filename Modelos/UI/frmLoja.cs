using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.UI
{
    public partial class frmLoja : Form
    {
        public frmLoja()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes obj = new frmClientes();
            obj.MdiParent = this;
            obj.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutos obj = new frmProdutos();
            obj.MdiParent = this;
            obj.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendas obj = new frmVendas();
            obj.MdiParent = this;
            obj.Show();
        }

        private void produtosEmFaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutosEmFalta obj = new frmProdutosEmFalta();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
