using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokTakip.Core;
using StokTakip.Core.Presenters;
using StokTakip.Core.Views;
using StokTakip.Data.Entities;
using StokTakip.Data.Entities.Enums;
using StokTakip.UI.Helpers;

namespace StokTakip.UI.Forms
{
    public partial class AddExpenseForm : Form, IAddExpenseView
    {
        private Expense editedExpense;
        protected AddExpensePresenter presenter;

        public AddExpenseForm()
        {
            InitializeComponent();

            this.presenter = new AddExpensePresenter(this);
            this.presenter.Initialize();

            WindowsApiHelper.DrawTopBorder(this.ActionsPanel, Color.LightGray);
            WindowsApiHelper.CueBanner(CategoryDropDown, false, "Kategori seçin");
        }

        public AddExpenseForm(Expense expense)
            : this()
        {
            this.editedExpense = expense;

            this.CategoryDropDown.Text = expense.Category;
            this.ExpenseDatePicker.Value = this.ExpenseTimePicker.Value = expense.ExpenseDate;
            this.AmountNumericUpDown.Value = expense.Amount;
            this.NoteTextBox.Text = expense.Description;

            HeaderTextLabel.Text = "Gideri Güncelle";
            AddExpenseButton.Text = "Güncelle";
        }

        public IEnumerable<string> CategoryList
        {
            set
            {
                this.CategoryDropDown.DataSource = value;
                this.CategoryDropDown.SelectedIndex = -1;
            }
        }

        public Expense Expense
        {
            get
            {
                if (ValidateForm())
                {
                    if (Edit)
                    {
                        editedExpense.ExpenseDate = ExpenseDatePicker.Value.Date.Add(ExpenseTimePicker.Value.TimeOfDay);
                        editedExpense.Amount = AmountNumericUpDown.Value;
                        editedExpense.Description = NoteTextBox.Text;
                        editedExpense.Category = CategoryDropDown.Text;

                        return editedExpense;
                    }
                    else
                    {
                        return new Expense
                        {
                            ExpenseDate = ExpenseDatePicker.Value.Date.Add(ExpenseTimePicker.Value.TimeOfDay),
                            Amount = AmountNumericUpDown.Value,
                            Description = NoteTextBox.Text,
                            Category = CategoryDropDown.Text,
                            CreateDate = DateTime.Now,
                            Status = ExpenseStatus.Active
                        };
                    }
                   
                }
                else
                {
                    return null;
                }
            }
        }

        public bool Edit
        {
            get
            {
                if (editedExpense != null)
                    return true;
                else
                    return false;
            }
        }

        public void ShowMessage(string message, string group, MessageType type)
        {
            MessageLabel.Text = message;
            MessageLabel.BackColor = type.GetColor();

            if (type == MessageType.Success)
            {
                this.Close();
            }
        }

        protected bool ValidateForm()
        {
            if (AmountNumericUpDown.Value <= 0m)
            {
                this.ShowMessage("Lütfen geçerli bir tutar girin", "AddExpense", MessageType.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(NoteTextBox.Text))
            {
                this.ShowMessage("Lütfen gider için bir açıklama girin", "AddExpense", MessageType.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(CategoryDropDown.Text))
            {
                this.ShowMessage("Lütfen gider için bir kategori belirtin", "AddExpense", MessageType.Warning);
                return false;
            }

            return true;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (Edit)
            {
                this.presenter.UpdateExpense();
            }
            else
            {
                this.presenter.AddExpense();
            }
           
        }
    }
}
