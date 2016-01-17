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
using CommonLibrary.Extensions;

namespace StokTakip.UI.Forms
{
    public partial class MainForm : Form, IMainView
    {
        protected static readonly Size DefaultIconSize = new Size(24, 24);

        protected MainPresenter presenter;

        public MainForm()
        {
            InitializeComponent();

            this.presenter = new MainPresenter(this);
            this.presenter.Initialize();
        }

        #region IMainView Members

        public void ShowMessage(string message, string group, MessageType type)
        {
            this.StatusTextLabel.Text = message;
            this.StatusPictureBox.Image = ImageHelper.GetSolidImage(type.GetColor(), DefaultIconSize);
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void AddNewItemLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddItemForm form = new AddItemForm();
            form.ShowDialog(this);

            this.ItemListControl.Refresh();
            this.ActionLogListControl.Refresh();
        }

        private void AddNewActionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddActionLogForm form = new AddActionLogForm(null);
            form.ShowDialog(this);

            this.ItemListControl.Refresh();
            this.ActionLogListControl.Refresh();
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

        private void AddNewExpenseLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddExpenseForm form = new AddExpenseForm();
            form.ShowDialog(this);
        }

        private void ListExpensesLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListExpensesForm form = new ListExpensesForm();
            form.ShowDialog(this);
        }

        private void ItemListControl_ActionLogListNeedsUpdated(object sender, EventArgs e)
        {
            this.ActionLogListControl.SelectedItem = this.ItemListControl.SelectedItem;
        }
    }
}
