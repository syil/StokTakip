using StokTakip.Core.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokTakip.Core.Presenters;
using StokTakip.Data.Entities;
using StokTakip.Core;
using StokTakip.Data.Entities.Enums;
using StokTakip.UI.Helpers;

namespace StokTakip.UI.Forms
{
    public partial class AddActionLogForm : Form, IAddActionLogView
    {
        protected AddActionLogPresenter presenter;

        protected int QuantitySign
        {
            get
            {
                if (ChangeQuantitySignButton.Text == "-")
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
        }

        protected Item SelectedItem
        {
            get
            {
                if (ItemsComboBox.SelectedIndex > -1)
                {
                     return ItemsComboBox.SelectedValue as Item;
                }
                else
                {
                    return null;
                }
            }
        }

        protected int Difference
        {
            get
            {
                int difference = (int)QuantityNumericUpDown.Value;
                difference = difference * this.QuantitySign;

                return difference;
            }
        }

        public AddActionLogForm(Item selectedItem)
        {
            InitializeComponent();
            this.presenter = new AddActionLogPresenter(this);
            this.presenter.Initialize();

            WindowsApiHelper.DrawTopBorder(this.ActionsPanel, Color.LightGray);
            ItemsComboBox.SelectedItem = selectedItem;
        }

        public void SetItemList(IEnumerable<Item> items)
        {
            ItemsComboBox.DataSource = items.ToList();
        }

        public ActionLog NewActionLog
        {
            get 
            {
                if (ValidateForm())
                {
                    return new ActionLog
                    {
                        ActionDate = DateTime.Now,
                        Description = NoteTextBox.Text,
                        Item = this.SelectedItem,
                        ActionType = this.Difference > 0 ? ActionType.Increase : ActionType.Decrease,
                        NewQuantity = this.SelectedItem.Quantity + this.Difference,
                        OldQuantity = this.SelectedItem.Quantity,
                        Change = this.Difference
                    };
                }
                else
                {
                    return null;
                }
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
            if (this.SelectedItem != null)
            {
                if (this.Difference == 0)
                {
                    this.ShowMessage("Ürün adedinde değişiklik yok", "AddActionLog", MessageType.Warning);
                    return false;
                }

                int newQuantity = this.SelectedItem.Quantity + this.Difference;

                if (newQuantity < 0)
                {
                    this.ShowMessage("Ürün adedi negatif olamaz", "AddActionLog", MessageType.Warning);
                    return false;
                }
            }
            else
            {
                this.ShowMessage("Ürün seçilmemiş", "AddActionLog", MessageType.Warning);
                return false;
            }

            return true;
        }

        private void OnQuantityChanged()
        {
            string differenceText = string.Empty;

            if (this.SelectedItem != null)
            {
                int newQuantity = this.SelectedItem.Quantity + this.Difference;

                if (this.Difference > 0)
                {
                    differenceText = string.Format("{0} stoğu {1} artarak {2} adet olacak", this.SelectedItem.Name, this.Difference, newQuantity);
                }
                else if (this.Difference < 0)
                {
                    differenceText = string.Format("{0} stoğu {1} azalarak {2} adet olacak", this.SelectedItem.Name, -this.Difference, newQuantity);
                }
                else
                {
                    differenceText = string.Format("{0} stoğunda değişiklik yok", this.SelectedItem.Name);
                }
            }

            this.CurrentItemDifferenceLabel.Text = differenceText;
        }

        private void ChangeQuantitySignButton_Click(object sender, EventArgs e)
        {
            if (this.QuantitySign == -1)
            {
                this.ChangeQuantitySignButton.Text = "+";
            }
            else
            {
                this.ChangeQuantitySignButton.Text = "-";
            }

            OnQuantityChanged();
        }

        private void QuantityNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            OnQuantityChanged();
        }

        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            OnQuantityChanged();
        }

        private void ItemsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnQuantityChanged();
        }

        private void AddActionButton_Click(object sender, EventArgs e)
        {
            this.presenter.AddActionLog();
        }

        private void AddNewItemLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddItemForm form = new AddItemForm();
            form.ShowDialog(this);

            this.presenter.Refresh();
        }
    }
}
