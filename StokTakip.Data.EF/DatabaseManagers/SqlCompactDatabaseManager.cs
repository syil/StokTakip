using CommonLibrary.Utilities;
using StokTakip.Data.Base;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace StokTakip.Data.EF.DatabaseManagers
{
    public class SqlCompactDatabaseManager : IDatabaseManager
    {
        private static readonly Logger logger = new Logger();
        private static readonly string emptyDatabaseFile = @".\Data\EmptyStokBase.sdf";
        private static readonly string backupDateTimeFormat = "yyyyMMddHHmmss";
        private string databaseFile;
        private string databaseDirectory;
        private TimeSpan backupPeriod;

        public SqlCompactDatabaseManager()
        {
            this.databaseFile = Environment.ExpandEnvironmentVariables(ConfigurationManager.AppSettings.Get("StokTakip.Data.EF.DataSource"));
            this.backupPeriod = TimeSpan.Parse(ConfigurationManager.AppSettings.Get("StokTakip.Data.EF.BackupPeriod"));
            this.databaseDirectory = Path.GetDirectoryName(databaseFile);

            logger.Debug("Database File: [{0}]", this.databaseFile);
            logger.Debug("Datebase Directory: [{0}]", this.databaseDirectory);
        }

        public List<DateTime> BackupDateList
        {
            get
            {
                List<DateTime> backupDateList = new List<DateTime>();

                var backupFiles = Directory.EnumerateFiles(databaseDirectory, "*.bck");
                if (backupFiles.Any())
                {
                    var backupFileNames = backupFiles.Select(f => Path.GetFileName(f));
                    foreach (string fileName in backupFileNames)
                    {
                        DateTime dt;
                        if (ExtractBackupDateTimeFromFileName(fileName, out dt))
                        {
                            backupDateList.Add(dt);
                        }
                    }

                    backupDateList.Sort();
                    backupDateList.Reverse();
                }

                return backupDateList;
            }
        }

        public void Prepare()
        {
            logger.Info("Preparing database");

            if (!Directory.Exists(this.databaseDirectory))
            {
                Directory.CreateDirectory(this.databaseDirectory);
            }

            File.Copy(emptyDatabaseFile, this.databaseFile);
            logger.Info("New empty database copied [{0}]", this.databaseFile);
        }

        public void Check()
        {
            if (!File.Exists(this.databaseFile))
            {
                logger.Warn("Database file not exists, must be created");
                Prepare();
            }

            DateTime lastBackupDate = BackupDateList.FirstOrDefault();
            if (lastBackupDate != default(DateTime))
            {
                if (DateTime.Now.Subtract(lastBackupDate) > this.backupPeriod)
                {
                    Backup();
                }
            }
            else
            {
                Backup();
            }
        }

        public void Backup()
        {
            string backupDatabaseFile = string.Format("{0}_{1}.bck", this.databaseFile, DateTime.Now.ToString(backupDateTimeFormat));
            File.Copy(this.databaseFile, backupDatabaseFile);
            logger.Info("Database backup created [{0}]", backupDatabaseFile);
        }

        public void Update()
        {
            using (SqlCeConnection connection = new SqlCeConnection(InternalConfiguration.Instance.GetProviderConnectionString()))
            {
                connection.Open();
                
                foreach (string queryFile in Directory.EnumerateFiles(@".\Data\", "*.sql"))
                {
                    string[] queries = File.ReadAllText(queryFile).Split(new string[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);

                    if (queries.Length >= 2)
                    {
                        using (SqlCeCommand expensesUpdateCommand = new SqlCeCommand(queries[0], connection))
                        {
                            int queryCheck = (int)expensesUpdateCommand.ExecuteScalar();

                            if (queryCheck == 0)
                            {
                                for (int i = 1; i < queries.Length; i++)
                                {
                                    expensesUpdateCommand.CommandText = queries[i];
                                    expensesUpdateCommand.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }

                connection.Close();
            }
        }

        public void Restore(DateTime backupDate, bool createCurrentBackup)
        {
            string backupDatabaseFile = string.Format("{0}_{1}.bck", this.databaseFile, backupDate.ToString(backupDateTimeFormat));
            if (File.Exists(backupDatabaseFile))
            {
                if (createCurrentBackup)
                    Backup();

                File.Delete(this.databaseFile);
                File.Move(backupDatabaseFile, this.databaseFile);
            }
            else
            {
                throw new FileNotFoundException("Yedek dosyası bulunamadı", backupDatabaseFile);
            }
        }

        private static bool ExtractBackupDateTimeFromFileName(string fileName, out DateTime backupDate)
        {
            Regex regex = new Regex(@".+_(\d{14})\.bck");
            if (regex.Match(fileName).Groups.Count == 2)
            {
                string captureString = regex.Match(fileName).Groups[1].Value;

                return DateTime.TryParseExact(captureString, backupDateTimeFormat, CultureInfo.CurrentCulture, DateTimeStyles.None, out backupDate);
            }
            else
            {
                backupDate = default(DateTime);
                return false;
            }
        }
    }
}
