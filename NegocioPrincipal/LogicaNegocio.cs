using Bibilioteca;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioPrincipal
{
    //Classe para facilitar as consultas
    public class LogicaNegocio : Component
    {
        /// <summary>
        /// Transação
        /// </summary>
        public virtual NpgsqlTransaction transaction { get; set; }


        /// <summary>
        /// Executar comando DB
        /// </summary>
        /// <param name="sbSql"></param>
        /// <returns></returns>
        public virtual DataTable ExecutarComando(StringBuilder sbSql)
        {
            return Propriedades.oMetodos.ExecutarComando(sbSql.ToString());
        }

        /// <summary>
        /// Executar comando DB
        /// </summary>
        /// <param name="pSql"></param>
        /// <returns></returns>
        public virtual DataTable ExecutarComando(string pSql)
        {
            return Propriedades.oMetodos.ExecutarComando(pSql);
        }

        public virtual DataTable ExecutarComando(NpgsqlCommand pCmd)
        {
            return Propriedades.oMetodos.ExecutarComando(pCmd);
        }

        /// <summary>
        /// Inicia uma transação no banco
        /// </summary>
        public virtual void BeginTransaction()
        {
            transaction = Propriedades.strConnection.BeginTransaction();
            Propriedades.strTransaction = this.transaction;
        }

        /// <summary>
        /// Executa um INSERT, UPDATE ou DELETE
        /// </summary>
        /// <param name="dtsMain"></param>
        public virtual void ExecuteUpdate(DataSet dtsMain)
        {
            Propriedades.oMetodos.ExecutarAtualizacaoBanco(dtsMain, this);
        }

        /// <summary>
        /// Abre a conexão
        /// </summary>
        public virtual void Open()
        {
            Propriedades.strConnection.Open();
        }

        /// <summary>
        /// Fecha a conexão
        /// </summary>
        /// <param name="bCommit">true: commit, false: roolback</param>
        public virtual void CloseTransaction(bool bCommit)
        {
            if (bCommit)
                transaction.Commit();
            else
                transaction.Rollback();
        }
    }
}
