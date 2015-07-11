using log4net;
using Microsoft.Practices.Unity;
using StokTakip.Core.Views;
using StokTakip.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Core.Presenters
{
    public class MainPresenter : DataPresenterBase<IMainView>
    {
        public MainPresenter(IMainView view)
            : base(view)
        {
            
        }

        public override void Initialize()
        {
            RefreshView();
        }

        public void RefreshView()
        {
            RefreshItems(true);
            RefreshActionLogs(true);

            this.view.ShowMessage("Listeler yenilendi", "RefreshView", MessageType.Information);
        }

        protected void RefreshItems(bool showError)
        {
            try
            {
                var itemList = this.repositoryContainer.Item.SearchByName(this.view.ItemFilterText).OrderBy(i => i.Name);
                this.view.SetItemList(itemList);
            }
            catch (Exception ex)
            {
                this.logger.Error(ex);

                if (showError)
                    this.view.ShowMessage("Öğeler alınamadı", "RefreshItems", MessageType.Error);
            }
        }

        protected void RefreshActionLogs(bool showError)
        {
            try
            {
                var actionLogList = this.repositoryContainer.Action.GetList().OrderByDescending(a => a.ActionDate);
                this.view.SetActionLogList(actionLogList);
            }
            catch (Exception ex)
            {
                this.logger.Error(ex);

                if (showError)
                    this.view.ShowMessage("Olaylar alınamadı", "RefreshActionLogs", MessageType.Error);
            }
        }

        public void GetItemActionLogs()
        {
            try
            {
                if (this.view.SelectedItem != null)
                {
                    var actionLogList = this.repositoryContainer.Action.GetItemActions(this.view.SelectedItem).OrderByDescending(a => a.ActionDate);
                    this.view.SetActionLogList(actionLogList);
                }
            }
            catch (Exception ex)
            {
                this.logger.Error(ex);
                this.view.ShowMessage("Olaylar alınamadı", "RefreshActionLogs", MessageType.Error);
            }
        }

        public void DeleteItem()
        {
            try
            {
                if (this.view.SelectedItem != null)
                {
                    this.repositoryContainer.RunTransactionalWork(() =>
                    {
                        this.repositoryContainer.Action.DeleteItemActions(this.view.SelectedItem);
                        this.repositoryContainer.Item.Delete(this.view.SelectedItem);
                    });

                    this.view.ShowMessage(string.Format("\"{0}\" silindi", this.view.SelectedItem.Name), "DeleteItem", MessageType.Success);

                    this.RefreshItems(false);
                    this.RefreshActionLogs(false);
                }
            }
            catch (Exception ex)
            {
                this.logger.Error(ex);
                this.view.ShowMessage("Öğe silinemedi", "DeleteItem", MessageType.Error);
            }
        }

        public void UndoLastAction()
        {
            try
            {
                if (this.view.SelectedItem != null)
                {
                    this.repositoryContainer.Action.UndoLastItemAction(this.view.SelectedItem);

                    this.view.ShowMessage(string.Format("\"{0}\" için en son olay kaydı geri alındı", this.view.SelectedItem.Name), "UndoLastAction", MessageType.Success);

                    this.RefreshItems(false);
                    this.RefreshActionLogs(false);
                }
            }
            catch (Exception ex)
            {
                this.logger.Error(ex);
                this.view.ShowMessage("Geri alma başarısız", "UndoLastAction", MessageType.Error);
            }
        }
    }
}
