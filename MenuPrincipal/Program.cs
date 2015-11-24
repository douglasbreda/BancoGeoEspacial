using Bibilioteca;
using Componente;
using Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuPrincipal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Propriedades.OpenConnectionDB();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            formLogin oLogin = new formLogin();
            oLogin.ShowDialog();

            if (oLogin.Validou)
                Application.Run(new formMenuPrincipal());

            //formMenuInicial oMenu = new formMenuInicial();
            //oMenu.Show();

        }
    }
}
