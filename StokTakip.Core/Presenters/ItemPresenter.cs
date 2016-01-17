using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Core.Views;

namespace StokTakip.Core.Presenters
{
    public class ItemPresenter : DataPresenterBase<IItemView>
    {
        public ItemPresenter(IItemView view) 
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
            RefreshItems(true);

            this.view.ShowMessage("Öğeler yenilendi", "RefreshItems", MessageType.Information);
        }

        protected void RefreshItems(bool showError)
        {
            try
            {
                var itemList = this.repositoryContainer.Item.SearchByName(this.view.ItemFilterText).OrderBy(i => i.Name);
                this.view.ItemList = itemList;
            }
            catch (Exception ex)
            {
                this.logger.Exception(ex);

                if (showError)
                    this.view.ShowMessage("Öğeler alınamadı", "RefreshItems", MessageType.Error);
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
                }
            }
            catch (Exception ex)
            {
                this.logger.Exception(ex);
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
                }
            }
            catch (Exception ex)
            {
                this.logger.Exception(ex);
                this.view.ShowMessage("Geri alma başarısız", "UndoLastAction", MessageType.Error);
            }
        }
    }
}
