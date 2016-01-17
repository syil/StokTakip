using CommonLibrary.Utilities;
using CommonLibrary.IoC;
using log4net.Config;
using StokTakip.Data.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;

namespace StokTakip.Core
{
    public class StokTakipApplicationContext : ApplicationContext
    {
        private static readonly Logger logger = new Logger();

        public bool IsRestoreMode { get; private set; }
        public bool RunningOnAnotherInstance
        {
            get
            {
                return CheckIfAlreadyRunningInstance();
            }
        }

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
            
                var databaseManager = DependencyResolver.Instance.Resolve<IDatabaseManager>();
                databaseManager.Check();
                
                if (ApplicationDeployment.IsNetworkDeployed)
                {
                    var currentDeployment = ApplicationDeployment.CurrentDeployment;

                    if (currentDeployment.IsFirstRun)
                    {
                        logger.Info("First run for version : [{0}]", currentDeployment.UpdatedVersion);

                        databaseManager.Update();
                    }
                }
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
