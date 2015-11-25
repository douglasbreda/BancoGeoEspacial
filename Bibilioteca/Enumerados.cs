using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibilioteca
{
    /// <summary>
    /// Define o modo de navegação
    /// </summary>
    public enum eNumeradoTipoNavegacao
    {
        /// <summary>
        /// Modo Navegação
        /// </summary>
        navigation = 0,
        /// <summary>
        /// Modo de inclusão
        /// </summary>
        inclusion = 1,
        /// <summary>
        /// Modo de alteração
        /// </summary>
        change = 2,
        /// <summary>
        ///  Modo de exclusão
        /// </summary>
        exclusion = 3
    }

    /// <summary>
    /// Define qual é o tipo do dado geoespacial que está sendo inserido
    /// </summary>
    public enum eTipoDadoGeografico
    {
        /// <summary>
        /// Tipo POINT
        /// </summary>
        point = 0,
        /// <summary>
        /// Tipo POLYGON
        /// </summary>
        polygon = 1
    }
}
