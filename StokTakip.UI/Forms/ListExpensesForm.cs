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
using StokTakip.Core.Views;
using StokTakip.UI.Helpers;

namespace StokTakip.UI.Forms
{
    public partial class ListExpensesForm : Form, IView
    {
        protected static readonly Size DefaultIconSize = new Size(24, 24);

        public ListExpensesForm()
        {
            InitializeComponent();
        }

        public void ShowMessage(string message, string group, MessageType type)
        {
            this.StatusTextLabel.Text = message;
            this.StatusPictureBox.Image = ImageHelper.GetSolidImage(type.GetColor(), DefaultIconSize);
        }
    }
}
