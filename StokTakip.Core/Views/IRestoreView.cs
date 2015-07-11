using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Core.Views
{
    public interface IRestoreView : IView
    {
        void SetBackupDateList(IEnumerable<DateTime> backupDates);
        DateTime SelectedRestoreDate { get; }
        bool CreateBackup { get; }
    }
}
