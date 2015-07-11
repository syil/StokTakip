using StokTakip.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StokTakip.Core.Presenters
{
    public class AddItemPresenter : DataPresenterBase<IAddItemView>
    {
        public AddItemPresenter(IAddItemView view)
            : base(view)
        {

        }

        public void AddItem()
        {
            var newItem = this.view.NewItem;

            if (newItem != null)
            {
                this.view.ShowMessage("Ekleniyor...", "AddItem", MessageType.Wait);
                try
                {
                    this.repositoryContainer.Item.AddNew(newItem);
                    this.view.ShowMessage("Öğe eklendi", "AddItem", MessageType.Success);
                }
                catch (Exception ex)
                {
                    this.logger.Error(ex);
                    this.view.ShowMessage("Öğe eklenirken bir sorun oluştu", "AddItem", MessageType.Error);
                } 
            }
        }
    }
}
