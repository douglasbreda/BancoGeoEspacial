using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Configuration;

namespace BancoDeDados
{
    public class BancoDeDados
    {

        /// <summary>
        /// Método para Iniciar a conexão com o banco
        /// </summary>
        /// <returns></returns>
        public NpgsqlConnection OpenConnection()
        {
            NpgsqlConnection connection = new NpgsqlConnection(ConfigurationSettings.AppSettings["ConnectionString"].ToString());

            if (connection.State == System.Data.ConnectionState.Open)
                connection.Open();

            return connection;
        }

        public void BeginTransaction()
        {

        }
    }
}
