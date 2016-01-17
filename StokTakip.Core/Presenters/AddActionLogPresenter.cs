using StokTakip.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StokTakip.Core.Presenters
{
    public class AddActionLogPresenter : DataPresenterBase<IAddActionLogView>
    {
        public AddActionLogPresenter(IAddActionLogView view)
            : base(view)
        {

        }

        public override void Initialize()
        {
            this.Refresh();

            base.Initialize();
        }

        public void Refresh()
        {
            try
            {
                var items = this.repositoryContainer.Item.GetList();
                this.view.SetItemList(items);
            }
            catch (Exception ex)
            {
                this.logger.Exception(ex);
                this.view.ShowMessage("Öğeler çekilirken sorun oluştu", "RefreshItems", MessageType.Error);
            }
        }

        public void AddActionLog()
        {
            var newActionLog = this.view.NewActionLog;

            if (newActionLog != null)
            {
                this.view.ShowMessage("Ekleniyor...", "AddActionLog", MessageType.Wait);
                try
                {
                    var item = newActionLog.Item;
                    item.Quantity = newActionLog.NewQuantity;

                    this.repositoryContainer.Item.Update(item);
                    this.repositoryContainer.Action.AddNew(newActionLog);
                    this.view.ShowMessage("Olay eklendi", "AddActionLog", MessageType.Success);
                }
                catch (Exception ex)
                {
                    this.logger.Exception(ex);
                    this.view.ShowMessage("Olay eklenirken bir sorun oluştu", "AddActionLog", MessageType.Error);
                }
            }
        }
    }
}
