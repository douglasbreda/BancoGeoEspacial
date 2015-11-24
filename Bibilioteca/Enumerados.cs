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
}
