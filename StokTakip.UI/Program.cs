using log4net.Config;
using StokTakip.Core;
using System;
using System.Windows.Forms;
using System.Deployment.Application;
using CommonLibrary.Utilities;

namespace StokTakip.UI
{
    static class Program
    {
        private static readonly Logger logger = new Logger();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            try
            {
                XmlConfigurator.Configure();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                var applicationContext = new StokTakipApplicationContext(args);

                if (!applicationContext.RunningOnAnotherInstance)
                {
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
                else
                {
                    MessageBox.Show("Uygulama zaten çalışıyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Stok Takip çalışırken beklenmeyen bir hata meydana geldi.\n\n{0}", ex.ToString()), "Uygulamada bir sorun oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Exception(ex);
            }
        }
    }
}
