using NegocioPrincipal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Classes
{
    public class Ocorrencia : LogicaNegocio
    {
        #region [Construtores]

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public Ocorrencia()
        {

        }

        #endregion Fim [Construtores]

        #region [Métodos]

        /// <summary>
        /// Retorna as ocorrências
        /// </summary>
        /// <returns></returns>
        public DataTable BuscarOcorrencias()
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.AppendLine("   select");
            sbSql.AppendLine("      ocorrencia.id,");
            sbSql.AppendLine("      ocorrencia.descricao,");
            sbSql.AppendLine("      ocorrencia.tipo,");
            sbSql.AppendLine("      st_x(pt_ponto) as pt_x,");
            sbSql.AppendLine("      st_y(pt_ponto) as pt_y");
            sbSql.AppendLine("    from");
            sbSql.AppendLine("      ocorrencia");

            return ExecutarComando(sbSql);
        }

        /// <summary>
        /// Retorna o kml 
        /// </summary>
        /// <param name="pCodBairro"></param>
        /// <returns></returns>
        public string BuscarKml(int pCodOcorrencia)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.AppendLine(" select");
            sbSql.AppendLine("      st_askml(pt_ponto) as kml");
            sbSql.AppendLine(" from ");
            sbSql.AppendLine("      ocorrencia");
            sbSql.AppendLine(" where");
            sbSql.AppendLine("      ocorrencia.id = " + pCodOcorrencia);

            return ExecutarComando(sbSql).Rows[0]["kml"].ToString();
        }


        #endregion Fim [Métodos]
    }
}
