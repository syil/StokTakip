using StokTakip.Core.Presenters;
using StokTakip.Core.Views;
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
    public partial class RestoreForm : Form, IRestoreView
    {
        protected RestorePresenter presenter;

        public RestoreForm()
        {
            InitializeComponent();

            this.presenter = new RestorePresenter(this);
            presenter.Initialize();

            WindowsApiHelper.SetListBoxStyle(this.BackupDatesListBox);
            WindowsApiHelper.DrawTopBorder(this.ActionsPanel, Color.LightGray);
        }

        public void SetBackupDateList(IEnumerable<DateTime> backupDates)
        {
            this.BackupDatesListBox.DataSource = backupDates;
        }

        public DateTime SelectedRestoreDate
        {
            get
            {
                return (DateTime)this.BackupDatesListBox.SelectedItem;
            }
        }

        public bool CreateBackup
        {
            get
            {
                return this.CreateBackupCheckBox.Checked;
            }
        }

        public void ShowMessage(string message, string group, Core.MessageType type)
        {
            MessageBox.Show(message, "Geri yükleme işlemi", MessageBoxButtons.OK, type.ToNameEquivalent<MessageBoxIcon>());
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (this.BackupDatesListBox.SelectedIndex != -1)
            {
                DialogResult dr = MessageBox.Show(string.Format("Veriler [{0:F}] tarihindeki haline geri döndürülecek, onaylıyor musunuz?", this.BackupDatesListBox.SelectedItem), "Geri yükleme işlemi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.OK)
                {
                    if (this.presenter.Restore())
                    {
                        Process.Start(Application.ExecutablePath);
                        Application.Exit();
                    }
                }
            }
            else
            {
                ShowMessage("Geri yükleme tarihi seçilmemiş", "Restore", Core.MessageType.Warning);
            }
        }
    }
}
