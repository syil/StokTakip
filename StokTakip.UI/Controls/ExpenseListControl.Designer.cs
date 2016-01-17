namespace StokTakip.UI.Controls
{
    partial class ExpenseListControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader DescriptionColumn;
            System.Windows.Forms.ColumnHeader DateColumn;
            System.Windows.Forms.ColumnHeader AmountColumn;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Panel panel1;
            this.CategoryDropDown = new System.Windows.Forms.ComboBox();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ExpenseListView = new System.Windows.Forms.ListView();
            this.CategoryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExpenseContextMenu = new System.Windows.Forms.ContextMenu();
            this.EditExpenseMenuItem = new System.Windows.Forms.MenuItem();
            this.DeleteExpenseMenuItem = new System.Windows.Forms.MenuItem();
            this.FooterInfoPanel = new System.Windows.Forms.Panel();
            this.SummaryInformationLabel = new System.Windows.Forms.Label();
            DescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            DateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            AmountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            this.FooterInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescriptionColumn
            // 
            DescriptionColumn.Text = "Açıklama";
            DescriptionColumn.Width = 331;
            // 
            // DateColumn
            // 
            DateColumn.Text = "Harcama Tarihi";
            DateColumn.Width = 192;
            // 
            // AmountColumn
            // 
            AmountColumn.Text = "Tutar";
            AmountColumn.Width = 121;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.DimGray;
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(774, 33);
            label2.TabIndex = 10;
            label2.Text = "Gider Listesi";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(248, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(19, 15);
            label1.TabIndex = 13;
            label1.Text = "ile";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(379, 8);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(31, 15);
            label3.TabIndex = 14;
            label3.Text = "arası";
            // 
            // panel1
            // 
            panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            panel1.BackColor = System.Drawing.Color.DimGray;
            panel1.Controls.Add(this.CategoryDropDown);
            panel1.Controls.Add(this.EndDatePicker);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(this.StartDatePicker);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(355, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(416, 29);
            panel1.TabIndex = 15;
            // 
            // CategoryDropDown
            // 
            this.CategoryDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryDropDown.FormattingEnabled = true;
            this.CategoryDropDown.Location = new System.Drawing.Point(3, 3);
            this.CategoryDropDown.Name = "CategoryDropDown";
            this.CategoryDropDown.Size = new System.Drawing.Size(133, 23);
            this.CategoryDropDown.TabIndex = 15;
            this.CategoryDropDown.SelectedIndexChanged += new System.EventHandler(this.ReportFilters_ValueChanged);
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDatePicker.Location = new System.Drawing.Point(273, 3);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(100, 23);
            this.EndDatePicker.TabIndex = 12;
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.ReportFilters_ValueChanged);
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.Location = new System.Drawing.Point(142, 3);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(100, 23);
            this.StartDatePicker.TabIndex = 11;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.ReportFilters_ValueChanged);
            // 
            // ExpenseListView
            // 
            this.ExpenseListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CategoryColumn,
            DescriptionColumn,
            DateColumn,
            AmountColumn});
            this.ExpenseListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpenseListView.FullRowSelect = true;
            this.ExpenseListView.Location = new System.Drawing.Point(0, 33);
            this.ExpenseListView.Name = "ExpenseListView";
            this.ExpenseListView.Size = new System.Drawing.Size(774, 360);
            this.ExpenseListView.TabIndex = 9;
            this.ExpenseListView.UseCompatibleStateImageBehavior = false;
            this.ExpenseListView.View = System.Windows.Forms.View.Details;
            this.ExpenseListView.DoubleClick += new System.EventHandler(this.ExpenseListView_DoubleClick);
            // 
            // CategoryColumn
            // 
            this.CategoryColumn.Text = "Kategori";
            this.CategoryColumn.Width = 90;
            // 
            // ExpenseContextMenu
            // 
            this.ExpenseContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.EditExpenseMenuItem,
            this.DeleteExpenseMenuItem});
            this.ExpenseContextMenu.Popup += new System.EventHandler(this.ExpenseContextMenu_Popup);
            // 
            // EditExpenseMenuItem
            // 
            this.EditExpenseMenuItem.Index = 0;
            this.EditExpenseMenuItem.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.EditExpenseMenuItem.Text = "Düzenle";
            this.EditExpenseMenuItem.Click += new System.EventHandler(this.EditExpenseMenuItem_Click);
            // 
            // DeleteExpenseMenuItem
            // 
            this.DeleteExpenseMenuItem.Index = 1;
            this.DeleteExpenseMenuItem.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.DeleteExpenseMenuItem.Text = "Sil";
            this.DeleteExpenseMenuItem.Click += new System.EventHandler(this.DeleteExpenseMenuItem_Click);
            // 
            // FooterInfoPanel
            // 
            this.FooterInfoPanel.BackColor = System.Drawing.Color.White;
            this.FooterInfoPanel.Controls.Add(this.SummaryInformationLabel);
            this.FooterInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterInfoPanel.Location = new System.Drawing.Point(0, 393);
            this.FooterInfoPanel.Name = "FooterInfoPanel";
            this.FooterInfoPanel.Size = new System.Drawing.Size(774, 33);
            this.FooterInfoPanel.TabIndex = 16;
            // 
            // SummaryInformationLabel
            // 
            this.SummaryInformationLabel.AutoSize = true;
            this.SummaryInformationLabel.Location = new System.Drawing.Point(8, 9);
            this.SummaryInformationLabel.Name = "SummaryInformationLabel";
            this.SummaryInformationLabel.Size = new System.Drawing.Size(82, 15);
            this.SummaryInformationLabel.TabIndex = 0;
            this.SummaryInformationLabel.Text = "Summary Info";
            // 
            // ExpenseListControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(panel1);
            this.Controls.Add(this.ExpenseListView);
            this.Controls.Add(label2);
            this.Controls.Add(this.FooterInfoPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "ExpenseListControl";
            this.Size = new System.Drawing.Size(774, 426);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.FooterInfoPanel.ResumeLayout(false);
            this.FooterInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ExpenseListView;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.ColumnHeader CategoryColumn;
        private System.Windows.Forms.ComboBox CategoryDropDown;
        private System.Windows.Forms.ContextMenu ExpenseContextMenu;
        private System.Windows.Forms.MenuItem EditExpenseMenuItem;
        private System.Windows.Forms.MenuItem DeleteExpenseMenuItem;
        private System.Windows.Forms.Panel FooterInfoPanel;
        private System.Windows.Forms.Label SummaryInformationLabel;
    }
}
