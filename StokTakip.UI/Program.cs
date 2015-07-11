using CommonLib;
using log4net.Config;
using StokTakip.Core;
using System;
using System.Windows.Forms;

namespace StokTakip.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            XmlConfigurator.Configure();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var applicationContext = new StokTakipApplicationContext(args);
            if (applicationContext.IsRestoreMode)
            {
                applicationContext.MainForm = new Forms.RestoreForm();
            }
            else
            {
                applicationContext.MainForm = new Forms.MainForm();
            }
            Application.Run(applicationContext);
        }
    }
}
