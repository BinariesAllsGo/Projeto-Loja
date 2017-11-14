using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.Modelos;
using Loja.DAL;
using System.Data;

namespace Loja.BLL
{
    public class VendasBLL
    {
        //Este é um campo privado para armazenar uma instância da classe DAL.
        private VENDASDAL objDAL;
        //Esse é o construtor da classe VendasBLL
        public VendasBLL()
        {
            objDAL = new VENDASDAL();
        }
        public DataTable ListaDeProdutos
        {
            get
            {
                return objDAL.ListaDeProdutos;
            }
        }
        public DataTable ListaDeClientes
        {
            get
            {
                return objDAL.ListaDeClientes;
            }
        }
        public void Incluir(Venda venda)
        {
            objDAL.Incluir(venda);
        }
    }
}
