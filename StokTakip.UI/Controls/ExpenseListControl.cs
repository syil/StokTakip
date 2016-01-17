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
using StokTakip.Core.Presenters;
using StokTakip.Core;
using StokTakip.Data.Entities;
using StokTakip.UI.Forms;
using CommonLibrary.Extensions;

namespace StokTakip.UI.Controls
{
    public partial class ExpenseListControl : UserControl, IExpenseView
    {
        private const int ExpenseIdColumnIndex = 4;

        protected List<Expense> expenseList;
        protected ExpensePresenter presenter;

        public DateTime EndDate
        {
            get
            {
                return EndDatePicker.Value.Date.AddDays(1);
            }
        }

        public List<Expense> ExpenseList
        {
            set
            {
                this.expenseList = value;

                RefreshExpenseListView();
                RefreshSummary();
            }
        }

        public DateTime StartDate
        {
            get
            {
                return StartDatePicker.Value.Date;
            }
        }

        public IEnumerable<string> CategoryList
        {
            set
            {
                CategoryDropDown.Items.Insert(0, "Tüm Kategoriler");
                foreach (string category in value)
                {
                    CategoryDropDown.Items.Add(category);
                }
                CategoryDropDown.SelectedIndex = 0;
            }
        }

        public string SelectedCategory
        {
            get
            {
                if (CategoryDropDown.SelectedIndex == 0)
                {
                    return string.Empty;
                }
                else
                {
                    return CategoryDropDown.Text;
                }
            }
        }

        public Expense SelectedExpense
        {
            get
            {
                if (ExpenseListView.SelectedItems.Count == 1)
                {
                    int expenseId = ExpenseListView.SelectedItems[0].SubItems[ExpenseIdColumnIndex].Text.ToInt32(0);
                    var expense = expenseList.Where(e => e.Id == expenseId).FirstOrDefault();

                    return expense;
                }
                else
                {
                    return null;
                }
            }
        }

        public ExpenseListControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                this.presenter = new ExpensePresenter(this);
                this.presenter.Initialize();
            }

            this.StartDatePicker.Value = DateTime.Now.AddMonths(-1);
            this.ExpenseListView.ContextMenu = ExpenseContextMenu;
        }

        private void RefreshExpenseListView()
        {
            ExpenseListView.Items.Clear();

            ListViewItem newItem;

            foreach (var item in this.expenseList)
            {
                newItem = new ListViewItem(new string[] {
                    item.Category,
                    item.Description,
                    item.ExpenseDate.ToString("dd MMMM yyyy HH:mm, dddd"),
                    item.Amount.ToString("C2"),
                    item.Id.ToString()
                });

                ExpenseListView.Items.Add(newItem);
            }
        }

        private void RefreshSummary()
        {
            SummaryInformationLabel.Text = string.Format("Listelenen giderlerin toplamı: [{0:C2}]", this.expenseList.Sum(e => e.Amount));
        }

        public void ShowMessage(string message, string group, MessageType type)
        {
            var parentView = this.ParentForm as IView;

            if (parentView != null)
            {
                parentView.ShowMessage(message, group, type);
            }
        }

        private void ReportFilters_ValueChanged(object sender, EventArgs e)
        {
            if (this.presenter != null && this.presenter.IsInitialized)
            {
                this.presenter.RefreshView();
            }
        }

        private void DeleteExpenseMenuItem_Click(object sender, EventArgs e)
        {
            var expense = this.SelectedExpense;

            if (expense != null)
            {
                if (MessageBox.Show(
                    string.Format("Seçili gideri silmek istiyor musunuz?\n\nAçıklama: {0}\nKategori: {1}\nTarih: {2}\nTutar: {3}",
                        expense.Description, expense.Category, expense.CreateDate, expense.Amount),
                    "Silme işlemini onayla",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.presenter.DeleteExpense();
                }
            }

            this.presenter.RefreshView();
        }

        private void EditExpenseMenuItem_Click(object sender, EventArgs e)
        {
            AddExpenseForm form = new AddExpenseForm(this.SelectedExpense);
            form.ShowDialog(this);

            this.presenter.RefreshView();
        }

        private void ExpenseContextMenu_Popup(object sender, EventArgs e)
        {
            if (ExpenseListView.SelectedItems.Count == 0)
            {
                DeleteExpenseMenuItem.Enabled = EditExpenseMenuItem.Enabled = false;
            }
            else
            {
                DeleteExpenseMenuItem.Enabled = EditExpenseMenuItem.Enabled = true;
            }
        }

        private void ExpenseListView_DoubleClick(object sender, EventArgs e)
        {
            AddExpenseForm form = new AddExpenseForm(this.SelectedExpense);
            form.ShowDialog(this);

            this.presenter.RefreshView();
        }
    }
}
