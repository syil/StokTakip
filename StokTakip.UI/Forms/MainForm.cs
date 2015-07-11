using StokTakip.Core;
using StokTakip.Core.Presenters;
using StokTakip.Core.Views;
using StokTakip.Data.Entities;
using StokTakip.UI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip.UI.Forms
{
    public partial class MainForm : Form, IMainView
    {
        protected const int ItemIdColumnIndex = 3;
        protected const int ActionLogIdColumnIndex = 6;
        protected static readonly Size DefaultIconSize = new Size(24, 24);

        protected MainPresenter presenter;
        protected List<Item> items;
        protected List<ActionLog> actionLogs;

        public MainForm()
        {
            InitializeComponent();

            this.presenter = new MainPresenter(this);
            this.presenter.Initialize();

            WindowsApiHelper.SetListViewStyle(ItemListView);
            WindowsApiHelper.SetListViewStyle(ActionLogListView);
            WindowsApiHelper.CueBanner(ItemFilterTextBox, false, "Öğe Arama");

            ItemListView.ContextMenu = ItemListContextMenu;
        }

        #region IMainView Members

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

        public ActionLog SelectedActionLog
        {
            get 
            {
                if (ActionLogListView.SelectedItems.Count == 1)
                {
                    int logId = ActionLogListView.SelectedItems[0].SubItems[ActionLogIdColumnIndex].Text.ToInt32(0);
                    ActionLog actionLog = actionLogs.Where(log => log.Id == logId).FirstOrDefault();

                    return actionLog;
                }
                else
                {
                    return null;
                }
            }
        }

        public void SetActionLogList(IEnumerable<ActionLog> actionLogs)
        {
            this.actionLogs = actionLogs.ToList();

            RefreshActionLogListView();
        }

        public void SetItemList(IEnumerable<Item> items)
        {
            this.items = items.ToList();

            RefreshItemListView();
        }

        public void ShowMessage(string message, string group, MessageType type)
        {
            this.StatusTextLabel.Text = message;
            this.StatusPictureBox.Image = ImageHelper.GetSolidImage(type.GetColor(), DefaultIconSize);
        }
        #endregion

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

        private void RefreshActionLogListView()
        {
            ActionLogListView.Items.Clear();
            ActionLogListView.Groups.Clear();

            ListViewItem newItem;
            ListViewGroup itemGroup;

            foreach (var actionLog in this.actionLogs)
            {
                string groupKey = actionLog.ActionDate.ToString("d");
                if (ActionLogListView.Groups[groupKey] == null)
                {
                    itemGroup = new ListViewGroup(groupKey, actionLog.ActionDate.ToString("dd MMMM yyyy, dddd"));
                    ActionLogListView.Groups.Add(itemGroup);
                }
                else
                {
                    itemGroup = ActionLogListView.Groups[groupKey];
                }

                newItem = new ListViewItem(new string[] {
                    actionLog.Item.Name,
                    actionLog.ActionDate.ToString("T"),
                    actionLog.OldQuantity.ToString(),
                    actionLog.NewQuantity.ToString(),
                    Math.Abs(actionLog.Change).ToString(),
                    actionLog.Description,
                    actionLog.Id.ToString()
                }, (short)actionLog.Type, itemGroup);

                ActionLogListView.Items.Add(newItem);
            }
        }

        private void OpenAddActionForm()
        {
            AddActionLogForm form = new AddActionLogForm(this.SelectedItem);
            form.ShowDialog(this);

            this.presenter.RefreshView();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void AddNewItemLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddItemForm form = new AddItemForm();
            form.ShowDialog(this);

            this.presenter.RefreshView();
        }

        private void AddNewActionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenAddActionForm();
        }

        private void DeleteItemMenuItem_Click(object sender, EventArgs e)
        {
            if (this.SelectedItem != null)
            {
                var result = MessageBox.Show("Seçili öğeyi silmek istediğinize emin misiniz? Bu öğe ile birlikte ilişkili olay geçmişi de temizlenecektir.", "Silme onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (result == DialogResult.Yes)
                this.presenter.DeleteItem(); 
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

        private void NewActionMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddActionForm();
        }

        private void ListActionLogsOfItemMenuItem_Click(object sender, EventArgs e)
        {
            if (this.SelectedItem != null)
            {
                this.presenter.GetItemActionLogs();

                this.ActionLogFilterLabel.Text = string.Format("\"{0}\" için listeleniyor", this.SelectedItem.Name);
            }
            else
            {
                this.presenter.RefreshView();

                this.ActionLogFilterLabel.Text = "Tüm öğeler için listeleniyor";
            }
        }

        private void UndoLastActionMenuItem_Click(object sender, EventArgs e)
        {
            if (this.SelectedItem != null)
            {
                var lastAction = this.actionLogs.Where(a => a.Item.Id == this.SelectedItem.Id).FirstOrDefault();

                if (lastAction != null)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("\"{0}\" öğesi için en son yapılmış olan aşağıdaki kaydı geri almak istediğinize emin misiniz?", lastAction.Item.Name).AppendLine().AppendLine();
                    sb.AppendFormat("Tarihi: {0:dd.MM.yyyy hh:mm:ss}", lastAction.ActionDate).AppendLine();
                    sb.AppendFormat("Değişim: {0} adet {1}", lastAction.Change, lastAction.Type).AppendLine();
                    sb.AppendFormat("Öğenin şu anki miktarı: {0}", lastAction.NewQuantity).AppendLine();
                    sb.AppendFormat("Geri alındıktan sonra miktarı: {0}", lastAction.OldQuantity).AppendLine();

                    var result = MessageBox.Show(sb.ToString(), "Geri alma işlemi onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        this.presenter.UndoLastAction();
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

        private void ItemListView_DoubleClick(object sender, EventArgs e)
        {
            OpenAddActionForm();
        }

        private void OpenReportsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var reportForm = new ReportForm();
            reportForm.ShowDialog();
        }

        private void ReturnToRestorePointLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Application.ExecutablePath, "/restore-mode");
            Application.Exit();
        }
    }
}
