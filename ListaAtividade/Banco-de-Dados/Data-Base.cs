using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade.Banco_de_Dados
{
    internal class Data_Base
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=senacmarcelo;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

    }

}
