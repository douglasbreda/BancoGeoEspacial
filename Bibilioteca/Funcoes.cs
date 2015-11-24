using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibilioteca
{
    static public class Funcoes
    {
        //classe dedica a funções que são bastante utilizadas

        /// <summary>
        /// Remove as vírgulas adicionadas no fim da string
        /// </summary>
        /// <param name="pString"></param>
        /// <returns></returns>
        static public string RetirarVirgulasDoFimDaString(string pString)
        {
            string sRetorno = "";

            sRetorno = pString.Remove(pString.Length - 1);

            return sRetorno;
        }

        /// <summary>
        /// Verifica se uma tabela possui registros
        /// </summary>
        /// <param name="pTabela"></param>
        /// <returns></returns>
        static public bool VerificarSeTabelaTemDados(DataSet pDataSetPrincipal, string pTabela)
        {
            bool bRetorno = false;
            foreach (DataRow dtb in pDataSetPrincipal.Tables[pTabela].Rows)
            {
                bRetorno = true;
                break;
            }

            return bRetorno;
        }

        /// <summary>
        /// Retira as máscaras do texto
        /// </summary>
        /// <param name="pTexto"></param>
        /// <returns></returns>
        static public string RetirarMascaras(string pTexto)
        {
            return pTexto.Replace("/", "").Replace("-", "").Replace(")", "").Replace(")", "");
        }

    }
}
