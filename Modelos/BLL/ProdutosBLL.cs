using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.Modelos;
using Loja.DAL;
using System.Collections;
using System.Data;

namespace Loja.BLL
{
    public class ProdutosBLL
    {
        public ArrayList ProdutosEmFalta()
        {

            PRODUTOSDAL obj = new PRODUTOSDAL();
            return obj.ProdutosEmFalta();
        }
        public void Incluir(Produto produto)
        {
            // Nome do produto é obrigatório
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório.");
            }
            // O preço do produto não pode ser negativo
            if (produto.Preco < 0)
            {
                throw new Exception("Preço do produto não pode ser negativo.");
            }
            // O estoque do produto não pode ser negativo
            if (produto.Estoque < 0)
            {
                throw new Exception("Estoque do produto não pode ser negativo.");
            }
            //Se tudo estiver ok, chama a rotina de gravação
            PRODUTOSDAL obj = new PRODUTOSDAL();
            obj.Incluir(produto);
        }
        public void Alterar(Produto produto)
        {
            PRODUTOSDAL obj = new PRODUTOSDAL();
            obj.Alterar(produto);
        }
        public void Excluir(int codigo)
        {
            PRODUTOSDAL obj = new PRODUTOSDAL();
            obj.Excluir(codigo);
        }
        public DataTable Listagem()
        {
            PRODUTOSDAL obj = new PRODUTOSDAL();
            return obj.Listagem();
        }
    }
}
