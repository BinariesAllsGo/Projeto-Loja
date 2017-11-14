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
    public class ClientesBLL
    {
        public void Incluir(Cliente cliente)
        {
            //O nome do cliente é obrigatório
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório");
            }
            //E-mail é sempre em letras minúsculas
            cliente.Email = cliente.Email.ToLower();

            //Se tudo está Ok, chama a rotina de inserção.
            CLIENTESDAL obj = new CLIENTESDAL();
            obj.Incluir(cliente);
        }
        public void Alterar(Cliente cliente)
        {
            CLIENTESDAL obj = new CLIENTESDAL();
            obj.Alterar(cliente);
        }
        public void Excluir(int codigo)
        {
            if (codigo < 1)
            {
                throw new Exception("Selecione um cliente antes de excluí-lo.");
            }
            CLIENTESDAL obj = new CLIENTESDAL();
            obj.Excluir(codigo);
        }
        public DataTable Listagem()
        {
            CLIENTESDAL obj = new CLIENTESDAL();
            return obj.Listagem();
        }
    }
}
