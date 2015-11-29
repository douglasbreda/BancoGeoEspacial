﻿using NegocioPrincipal;
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
            sbSql.AppendLine(" select");
            sbSql.AppendLine("      st_askml(pl_coordenada) as kml");
            sbSql.AppendLine(" from ");
            sbSql.AppendLine("      bairro");

            return ExecutarComando(sbSql).Rows[0]["kml"].ToString();
        }

        #endregion Fim [Métodos]
    }
}
