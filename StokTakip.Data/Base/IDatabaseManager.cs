using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.Base
{
    public interface IDatabaseManager
    {
        List<DateTime> BackupDateList { get; }
        void Prepare();
        void Check();
        void Backup();
        void Update();
        void Restore(DateTime backupDate, bool createCurrentBackup);
    }
}
