using Bibilioteca;
using NegocioPrincipal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Classes
{
    public class Bairro : LogicaNegocio
    {
        #region [Construtores]

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public Bairro()
        {

        }

        #endregion Fim [Construtores]

        #region [Métodos]

        /// <summary>
        /// Retorna todos os bairros cadastrados
        /// </summary>
        /// <returns></returns>
        public DataTable BuscarBairros()
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.AppendLine("  SELECT");
            sbSql.AppendLine("      *");
            sbSql.AppendLine("  FROM");
            sbSql.AppendLine("      bairro");

            return ExecutarComando(sbSql);
        }

        /// <summary>
        /// Retorna a string principal do kml
        /// </summary>
        /// <param name="pCodBairro"></param>
        /// <returns></returns>
        public string BuscarKml(int pCodBairro)
        {
            StringBuilder sbSql = new StringBuilder();
            DataTable dtbDados = new DataTable();
            string sRetorno = "";

            sbSql.AppendLine(" select");
            sbSql.AppendLine("      st_askml(pl_coordenada) as kml");
            sbSql.AppendLine(" from ");
            sbSql.AppendLine("      bairro");
            sbSql.AppendLine(" where");
            sbSql.AppendLine("      bairro.id = " + pCodBairro);

            dtbDados = ExecutarComando(sbSql);

            if (dtbDados.Rows.Count > 0)
                sRetorno = dtbDados.Rows[0]["kml"].ToString();

            return sRetorno;
        }

        /// <summary>
        /// Retorna o número de ocorrências por bairro
        /// </summary>
        /// <param name="pCodBairro"></param>
        /// <returns></returns>
        public int BuscarNumeroOcorrencias(int pCodBairro)
        {
            StringBuilder sbSql = new StringBuilder();
            DataTable dtbOcorrencia = new DataTable();
            int iNumeroOcorrencia = 0;

            sbSql.AppendLine(" select");
            sbSql.AppendLine("      count(*) as qtd");
            sbSql.AppendLine(" from");
            sbSql.AppendLine("      bairro,");
            sbSql.AppendLine("      ocorrencia");
            sbSql.AppendLine(" where");
            sbSql.AppendLine("      bairro.id = " + pCodBairro);
            sbSql.AppendLine("      and st_contains(pl_coordenada, ST_GeomFromText(ST_ASTEXT(ocorrencia.pt_ponto), 4326))");

            dtbOcorrencia = ExecutarComando(sbSql);

            if (dtbOcorrencia.Rows.Count > 0)
                iNumeroOcorrencia = Convert.ToInt32(dtbOcorrencia.Rows[0]["qtd"]);

            return iNumeroOcorrencia;
        }

        #endregion Fim [Métodos]
    }
}
