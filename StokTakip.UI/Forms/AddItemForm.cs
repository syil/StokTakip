using StokTakip.Core.Views;
using StokTakip.Data.Entities;
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
using StokTakip.Core;
using StokTakip.UI.Helpers;

namespace StokTakip.UI.Forms
{
    public partial class AddItemForm : Form, IAddItemView
    {
        protected AddItemPresenter presenter;

        public AddItemForm()
        {
            InitializeComponent();
            this.presenter = new AddItemPresenter(this);
            this.presenter.Initialize();

            WindowsApiHelper.DrawTopBorder(this.ActionsPanel, Color.LightGray);
        }

        public Item NewItem
        {
            get
            {
                if (ValidateForm())
                {
                    return new Item
                    {
                        Name = ItemNameTextBox.Text,
                        InsertDate = DateTime.Now
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
            MessageLabel.ForeColor = type.GetColor();

            if (type == MessageType.Success)
            {
                this.Close();
            }
        }

        protected bool ValidateForm()
        {
            if (!string.IsNullOrEmpty(ItemNameTextBox.Text))
            {
                return true;
            }
            else
            {
                this.ShowMessage("Lütfen bir öğe adı belirtin", "AddItem", MessageType.Warning);
                return false;
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            this.presenter.AddItem();
        }
    }
}
