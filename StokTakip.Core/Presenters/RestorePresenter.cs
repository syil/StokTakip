using CommonLib.IoC;
using StokTakip.Core.Views;
using StokTakip.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Core.Presenters
{
    public class RestorePresenter : PresenterBase<IRestoreView>
    {
        private IDatabaseManager databaseManager;

        public RestorePresenter(IRestoreView view)
            : base(view)
        {
            this.databaseManager = DependencyResolver.Instance.Resolve<IDatabaseManager>();
        }

        public override void Initialize()
        {
            try
            {
                this.view.SetBackupDateList(databaseManager.BackupDateList);
            }
            catch (Exception ex)
            {
                this.logger.Error(ex);

                this.view.ShowMessage("Geri yükleme listesi alınamadı", "Initialize", MessageType.Error);
            }
        }

        public bool Restore()
        {
            try
            {
                this.databaseManager.Restore(this.view.SelectedRestoreDate, this.view.CreateBackup);
                this.view.ShowMessage("Geri yükleme başarılı", "Restore", MessageType.Information);

                return true;
            }
            catch (Exception ex)
            {
                this.logger.Error(ex);
                this.view.ShowMessage("Geri yükleme başarısız", "Restore", MessageType.Error);

                return false;
            }
        }
    }
}
