using BancoDeDados;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibilioteca
{
    static public class Propriedades
    {
        #region [Attributes]

        public static MetodosDB oMetodos = new MetodosDB();

        #endregion End [Attributes]

        #region [Properties]

        /// <summary>
        /// Armazena a string de conexão
        /// </summary>
        public static NpgsqlConnection strConnection { get; set; }

        /// <summary>
        /// Armazena a transação atual
        /// </summary>
        public static NpgsqlTransaction strTransaction { get; set; }

        /// <summary>
        /// Instancia os métodos para conexão
        /// </summary>
        public static MetodosDB oMetodoDB
        {
            get { return oMetodos; }
            set { oMetodos = value; }
        }

        /// <summary>
        /// Armazena o código do usuário
        /// </summary>
        public static int CodigoUsuario { get; set; }

        /// <summary>
        /// Armazena o nome do usuário
        /// </summary>
        public static string NomeUsuario { get; set; }

        /// <summary>
        /// Incrementa a barra de progresso
        /// </summary>
        public static int ContadorBarraProgresso { get; set; }

        #endregion End [Properties]

        #region [Methods]

        /// <summary>
        /// Inicia uma conexão com o banco informado no arquivo de configuração
        /// </summary>
        /// <returns></returns>
        static public string OpenConnectionDB()
        {
            string sMsgConnection = "";

            strConnection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
            try
            {
                strConnection.Open();
                sMsgConnection = "Conexão bem sucedida";
            }
            catch (Exception ex)
            {
                strConnection.Close();
                sMsgConnection = "Ocorreu um erro ao realizar a conexão: \n" + ex.Message.ToString();
            }

            return sMsgConnection;
        }

        #endregion End [Methods]

    }
}
