using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Core.Views;

namespace StokTakip.Core.Presenters
{
    public class ActionLogPresenter : DataPresenterBase<IActionLogView>
    {
        public ActionLogPresenter(IActionLogView view)
            : base(view)
        {

        }

        public override void Initialize()
        {
            RefreshView();

            base.Initialize();
        }

        public void RefreshView()
        {
            RefreshActionLogs(true);

            this.view.ShowMessage("Olaylar yenilendi", "RefreshItems", MessageType.Information);
        }

        protected void RefreshActionLogs(bool showError)
        {
            try
            {
                if (this.view.SelectedItem != null)
                {
                    var actionLogList = this.repositoryContainer.Action.GetItemActions(this.view.SelectedItem).OrderByDescending(a => a.ActionDate);
                    this.view.ActionLogList =actionLogList;
                }
                else
                {
                    var actionLogList = this.repositoryContainer.Action.GetList().OrderByDescending(a => a.ActionDate);
                    this.view.ActionLogList = actionLogList;
                }
                
            }
            catch (Exception ex)
            {
                this.logger.Exception(ex);

                if (showError)
                    this.view.ShowMessage("Olaylar alınamadı", "RefreshActionLogs", MessageType.Error);
            }
        }
    }
}
