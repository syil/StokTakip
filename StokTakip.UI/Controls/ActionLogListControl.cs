using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokTakip.Core.Views;
using StokTakip.UI.Helpers;
using StokTakip.Data.Entities;
using StokTakip.Core.Presenters;
using StokTakip.Core;
using CommonLibrary.Extensions;

namespace StokTakip.UI.Controls
{
    public partial class ActionLogListControl : UserControl, IActionLogView
    {
        private const int ActionLogIdColumnIndex = 6;

        protected List<ActionLog> actionLogs;
        protected ActionLogPresenter presenter;
        protected Item selectedItem;

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

        public Item SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;

                if (value != null)
                {
                    this.ActionLogFilterLabel.Text = string.Format("\"{0}\" için listeleniyor", selectedItem.Name);
                }
                else
                {
                    this.ActionLogFilterLabel.Text = "Tüm öğeler için listeleniyor";
                }

                this.presenter.RefreshView();
            }
        }

        public IEnumerable<ActionLog> ActionLogList
        {
            set
            {
                this.actionLogs = value.ToList();

                RefreshActionLogListView();
            }
        }

        public ActionLogListControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                this.presenter = new ActionLogPresenter(this);
                this.presenter.Initialize();
            }

            WindowsApiHelper.SetListViewStyle(ActionLogListView);
        }

        public new void Refresh()
        {
            this.presenter.RefreshView();
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
                }, (short)actionLog.ActionType, itemGroup);

                ActionLogListView.Items.Add(newItem);
            }
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
