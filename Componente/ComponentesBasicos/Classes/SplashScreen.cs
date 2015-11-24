using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componente.ComponentesBasicos.Classes
{
    class SplashScreen
    {
        private delegate void CloseDelegate();

        private static SplashScreen splashScreen;

        static public void ShowSplashScreen()
        {
            if (splashScreen != null)
                return;

            Thread thread = new Thread(new ThreadStart(SplashScreen.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static private void ShowForm()
        {
            splashScreen = new SplashScreen();
            
        }
        static public void CloseForm()
        {
            
        }

        static private void CloseFormInternal()
        {
            
        }

    }
}
