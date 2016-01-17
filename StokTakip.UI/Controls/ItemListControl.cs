using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokTakip.UI.Helpers;
using StokTakip.Data.Entities;
using CommonLibrary.Extensions;
using StokTakip.Core.Views;
using StokTakip.Core;
using StokTakip.Core.Presenters;
using StokTakip.UI.Forms;

namespace StokTakip.UI.Controls
{
    public partial class ItemListControl : UserControl, IItemView
    {
        public event EventHandler ActionLogListNeedsUpdated;

        private const int ItemIdColumnIndex = 3;

        protected List<Item> items;
        protected ItemPresenter presenter;

        public string ItemFilterText
        {
            get
            {
                return ItemFilterTextBox.Text;
            }
        }

        public Item SelectedItem
        {
            get
            {
                if (ItemListView.SelectedItems.Count == 1)
                {
                    int itemId = ItemListView.SelectedItems[0].SubItems[ItemIdColumnIndex].Text.ToInt32(0);
                    Item item = items.Where(it => it.Id == itemId).FirstOrDefault();

                    return item;
                }
                else
                {
                    return null;
                }
            }
        }

        public IEnumerable<Item> ItemList
        {
            set
            {
                this.items = value.ToList();

                RefreshItemListView();
            }
        }

        public ItemListControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                this.presenter = new ItemPresenter(this);
                this.presenter.Initialize(); 
            }

            WindowsApiHelper.SetListViewStyle(ItemListView);
            WindowsApiHelper.CueBanner(ItemFilterTextBox, false, "Öğe Arama");
            ItemListView.ContextMenu = ItemListContextMenu;
        }

        protected void OnActionLogListNeedsUpdated()
        {
            EventHandler temp = ActionLogListNeedsUpdated;
            if (temp != null)
            {
                temp(this, EventArgs.Empty);
            }
        }

        public new void Refresh()
        {
            this.presenter.RefreshView();
        }

        private void RefreshItemListView()
        {
            ItemListView.Items.Clear();

            ListViewItem newItem;

            foreach (var item in this.items)
            {
                newItem = new ListViewItem(new string[] {
                    item.Name,
                    string.Format("{0} adet", item.Quantity),
                    string.Format("{0:d} tarihinde eklendi", item.InsertDate),
                    item.Id.ToString()
                }, 0);

                ItemListView.Items.Add(newItem);
            }
        }

        private void DeleteItemMenuItem_Click(object sender, EventArgs e)
        {
            if (this.SelectedItem != null)
            {
                var result = MessageBox.Show("Seçili öğeyi silmek istediğinize emin misiniz? Bu öğe ile birlikte ilişkili olay geçmişi de temizlenecektir.", "Silme onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    this.presenter.DeleteItem();

                    OnActionLogListNeedsUpdated();
                }
            }
            
        }

        private void ItemFilterTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (ItemFilterTextBox.Text.Length != 1) // 0 ya da 2' den fazla karakter var ise
            {
                this.presenter.RefreshView();
            }
        }

        private void ItemFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemFilterTextBox.Text.Length != 1) // 0 ya da 2' den fazla karakter var ise
            {
                this.presenter.RefreshView();
            }
        }

        private void UndoLastActionMenuItem_Click(object sender, EventArgs e)
        {
            if (this.SelectedItem != null)
            {
                var lastAction = this.SelectedItem.ActionLogs.OrderByDescending(a => a.ActionDate).FirstOrDefault();

                if (lastAction != null)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("\"{0}\" öğesi için en son yapılmış olan aşağıdaki kaydı geri almak istediğinize emin misiniz?", lastAction.Item.Name).AppendLine().AppendLine();
                    sb.AppendFormat("Tarihi: {0:dd.MM.yyyy hh:mm:ss}", lastAction.ActionDate).AppendLine();
                    sb.AppendFormat("Değişim: {0} adet {1}", Math.Abs(lastAction.Change), lastAction.ActionType.GetStringValue()).AppendLine();
                    sb.AppendFormat("Öğenin şu anki miktarı: {0}", lastAction.NewQuantity).AppendLine();
                    sb.AppendFormat("Geri alındıktan sonra miktarı: {0}", lastAction.OldQuantity).AppendLine();

                    var result = MessageBox.Show(sb.ToString(), "Geri alma işlemi onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        this.presenter.UndoLastAction();

                        OnActionLogListNeedsUpdated();
                    }
                }
            }
        }

        private void ItemListContextMenu_Popup(object sender, EventArgs e)
        {
            if (this.SelectedItem != null)
            {
                ListActionLogsOfItemMenuItem.Text = "Olayları Listele";
                UndoLastActionMenuItem.Enabled = true;
                DeleteItemMenuItem.Enabled = true;
            }
            else
            {
                ListActionLogsOfItemMenuItem.Text = "Tüm Olayları Listele";
                UndoLastActionMenuItem.Enabled = false;
                DeleteItemMenuItem.Enabled = false;
            }
        }

        private void ListActionLogsOfItemMenuItem_Click(object sender, EventArgs e)
        {
            OnActionLogListNeedsUpdated();
        }

        private void ItemListView_DoubleClick(object sender, EventArgs e)
        {
            AddActionLogForm form = new AddActionLogForm(this.SelectedItem);
            form.ShowDialog(this);
        }

        private void NewActionMenuItem_Click(object sender, EventArgs e)
        {
            AddActionLogForm form = new AddActionLogForm(this.SelectedItem);
            form.ShowDialog(this);
        }

        public void ShowMessage(string message, string group, MessageType type)
        {
            var parentView = this.ParentForm as IView;
            if (parentView != null)
            {
                parentView.ShowMessage(message, group, type);
            }
        }
    }
}
