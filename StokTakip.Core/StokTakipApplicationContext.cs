using CommonLib;
using CommonLib.IoC;
using log4net.Config;
using StokTakip.Data.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip.Core
{
    public class StokTakipApplicationContext : ApplicationContext
    {
        private static readonly Logger logger = new Logger(typeof(StokTakipApplicationContext));

        public bool IsRestoreMode { get; private set; }

        public StokTakipApplicationContext(string[] args)
            : base()
        {
            logger.Debug("Application Context Creating");

            if (args.Contains("/restore-mode"))
            {
                this.IsRestoreMode = true;
            }
            else
            {
                this.IsRestoreMode = false;

                if (CheckIfAlreadyRunningInstance())
                {
                    MessageBox.Show("Uygulama zaten çalışıyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            
                var databaseManager = DependencyResolver.Instance.Resolve<IDatabaseManager>();
                databaseManager.Check();
            }
        }

        private static bool CheckIfAlreadyRunningInstance()
        {
            var currentProcess = Process.GetCurrentProcess();
            var isAnotherInstanceExists = Process.GetProcessesByName(currentProcess.ProcessName).Any(p => p.Id != currentProcess.Id);

            return isAnotherInstanceExists;
        }
    }
}
