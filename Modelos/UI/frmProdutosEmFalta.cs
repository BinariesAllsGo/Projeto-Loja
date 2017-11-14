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
    public partial class frmProdutosEmFalta : Form
    {
        public frmProdutosEmFalta()
        {
            InitializeComponent();
        }

        private void frmProdutosEmFalta_Load(object sender, EventArgs e)
        {
            ProdutosBLL produto = new ProdutosBLL();
            dgvProdutosEmFalta.DataSource = produto.ProdutosEmFalta();
        }
    }
}
