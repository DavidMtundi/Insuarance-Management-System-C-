using GunaTutorial;
using Insuarance.InsuaranceForms;
using Microsoft_Store_Design_Concept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Insuarance
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
          //  Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InsuaranceModels.DatabasesConnections.GlobalConfig.initializeConnections(false, true);
            Application.Run(new LoginPageForm());
        }
    }
}
