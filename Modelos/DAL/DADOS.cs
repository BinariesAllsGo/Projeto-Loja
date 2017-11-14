using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Loja.Modelos;

namespace Loja.DAL
{
    class Dados

    {
        public static string StringDeConexao
        {
            get
            {
                return "Data Source= DESKTOP-5MMDB6V\\SQLEXPRESS; Initial Catalog= Loja; Integrated Security= true";
            }
        }
    }
}
