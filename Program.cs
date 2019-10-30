using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace myPaint
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fmSplash SplashScreen = new fmSplash();
            SplashScreen.Show();
            while (SplashScreen.tmSplash.Enabled)
            {
                Application.DoEvents();
            }
            Application.Run(new fmMain(SplashScreen));
        }
    }
}
