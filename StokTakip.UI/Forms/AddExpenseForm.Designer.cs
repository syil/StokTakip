namespace StokTakip.UI.Forms
{
    partial class AddExpenseForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label ExpenseDescriptionLabel;
            System.Windows.Forms.Panel ExpenseDatePanel;
            System.Windows.Forms.Label ExpenseDateLabel;
            System.Windows.Forms.Label SetAmountLabel;
            System.Windows.Forms.Panel SetAmountPanel;
            System.Windows.Forms.Panel ExpenseNotePanel;
            System.Windows.Forms.TableLayoutPanel ExpenseFormLayoutTable;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Panel HeaderPanel;
            this.ExpenseTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ExpenseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.CategoryDropDown = new System.Windows.Forms.ComboBox();
            this.HeaderTextLabel = new System.Windows.Forms.Label();
            this.AddExpenseButton = new System.Windows.Forms.Button();
            this.ActionsPanel = new System.Windows.Forms.Panel();
            this.MessageLabel = new System.Windows.Forms.Label();
            ExpenseDescriptionLabel = new System.Windows.Forms.Label();
            ExpenseDatePanel = new System.Windows.Forms.Panel();
            ExpenseDateLabel = new System.Windows.Forms.Label();
            SetAmountLabel = new System.Windows.Forms.Label();
            SetAmountPanel = new System.Windows.Forms.Panel();
            ExpenseNotePanel = new System.Windows.Forms.Panel();
            ExpenseFormLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            HeaderPanel = new System.Windows.Forms.Panel();
            ExpenseDatePanel.SuspendLayout();
            SetAmountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown)).BeginInit();
            ExpenseNotePanel.SuspendLayout();
            ExpenseFormLayoutTable.SuspendLayout();
            panel1.SuspendLayout();
            HeaderPanel.SuspendLayout();
            this.ActionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExpenseDescriptionLabel
            // 
            ExpenseDescriptionLabel.AutoSize = true;
            ExpenseDescriptionLabel.Location = new System.Drawing.Point(9, 9);
            ExpenseDescriptionLabel.Name = "ExpenseDescriptionLabel";
            ExpenseDescriptionLabel.Size = new System.Drawing.Size(56, 15);
            ExpenseDescriptionLabel.TabIndex = 0;
            ExpenseDescriptionLabel.Text = "Açıklama";
            // 
            // ExpenseDatePanel
            // 
            ExpenseDatePanel.Controls.Add(this.ExpenseTimePicker);
            ExpenseDatePanel.Controls.Add(this.ExpenseDatePicker);
            ExpenseDatePanel.Controls.Add(ExpenseDateLabel);
            ExpenseDatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ExpenseDatePanel.Location = new System.Drawing.Point(160, 3);
            ExpenseDatePanel.Name = "ExpenseDatePanel";
            ExpenseDatePanel.Size = new System.Drawing.Size(173, 68);
            ExpenseDatePanel.TabIndex = 1;
            // 
            // ExpenseTimePicker
            // 
            this.ExpenseTimePicker.CustomFormat = "HH:mm";
            this.ExpenseTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpenseTimePicker.Location = new System.Drawing.Point(106, 34);
            this.ExpenseTimePicker.Name = "ExpenseTimePicker";
            this.ExpenseTimePicker.ShowUpDown = true;
            this.ExpenseTimePicker.Size = new System.Drawing.Size(67, 23);
            this.ExpenseTimePicker.TabIndex = 1;
            // 
            // ExpenseDatePicker
            // 
            this.ExpenseDatePicker.CustomFormat = "dd.MM.yyyy";
            this.ExpenseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpenseDatePicker.Location = new System.Drawing.Point(3, 34);
            this.ExpenseDatePicker.Name = "ExpenseDatePicker";
            this.ExpenseDatePicker.Size = new System.Drawing.Size(97, 23);
            this.ExpenseDatePicker.TabIndex = 0;
            // 
            // ExpenseDateLabel
            // 
            ExpenseDateLabel.AutoSize = true;
            ExpenseDateLabel.Location = new System.Drawing.Point(0, 10);
            ExpenseDateLabel.Name = "ExpenseDateLabel";
            ExpenseDateLabel.Size = new System.Drawing.Size(67, 15);
            ExpenseDateLabel.TabIndex = 1;
            ExpenseDateLabel.Text = "Gider Tarihi";
            // 
            // SetAmountLabel
            // 
            SetAmountLabel.AutoSize = true;
            SetAmountLabel.Location = new System.Drawing.Point(3, 10);
            SetAmountLabel.Name = "SetAmountLabel";
            SetAmountLabel.Size = new System.Drawing.Size(35, 15);
            SetAmountLabel.TabIndex = 2;
            SetAmountLabel.Text = "Tutar";
            // 
            // SetAmountPanel
            // 
            SetAmountPanel.Controls.Add(this.AmountNumericUpDown);
            SetAmountPanel.Controls.Add(SetAmountLabel);
            SetAmountPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            SetAmountPanel.Location = new System.Drawing.Point(339, 3);
            SetAmountPanel.Name = "SetAmountPanel";
            SetAmountPanel.Size = new System.Drawing.Size(107, 68);
            SetAmountPanel.TabIndex = 2;
            // 
            // AmountNumericUpDown
            // 
            this.AmountNumericUpDown.DecimalPlaces = 2;
            this.AmountNumericUpDown.Location = new System.Drawing.Point(6, 35);
            this.AmountNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.AmountNumericUpDown.Name = "AmountNumericUpDown";
            this.AmountNumericUpDown.Size = new System.Drawing.Size(92, 23);
            this.AmountNumericUpDown.TabIndex = 0;
            this.AmountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AmountNumericUpDown.ThousandsSeparator = true;
            // 
            // ExpenseNotePanel
            // 
            ExpenseFormLayoutTable.SetColumnSpan(ExpenseNotePanel, 3);
            ExpenseNotePanel.Controls.Add(this.NoteTextBox);
            ExpenseNotePanel.Controls.Add(ExpenseDescriptionLabel);
            ExpenseNotePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ExpenseNotePanel.Location = new System.Drawing.Point(3, 77);
            ExpenseNotePanel.Name = "ExpenseNotePanel";
            ExpenseNotePanel.Size = new System.Drawing.Size(443, 54);
            ExpenseNotePanel.TabIndex = 3;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NoteTextBox.Location = new System.Drawing.Point(71, 0);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(362, 54);
            this.NoteTextBox.TabIndex = 0;
            // 
            // ExpenseFormLayoutTable
            // 
            ExpenseFormLayoutTable.ColumnCount = 3;
            ExpenseFormLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            ExpenseFormLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            ExpenseFormLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            ExpenseFormLayoutTable.Controls.Add(ExpenseDatePanel, 1, 0);
            ExpenseFormLayoutTable.Controls.Add(SetAmountPanel, 2, 0);
            ExpenseFormLayoutTable.Controls.Add(ExpenseNotePanel, 0, 1);
            ExpenseFormLayoutTable.Controls.Add(panel1, 0, 0);
            ExpenseFormLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            ExpenseFormLayoutTable.Location = new System.Drawing.Point(0, 60);
            ExpenseFormLayoutTable.Name = "ExpenseFormLayoutTable";
            ExpenseFormLayoutTable.RowCount = 2;
            ExpenseFormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            ExpenseFormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            ExpenseFormLayoutTable.Size = new System.Drawing.Size(449, 134);
            ExpenseFormLayoutTable.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(this.CategoryDropDown);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(151, 68);
            panel1.TabIndex = 0;
            // 
            // CategoryDropDown
            // 
            this.CategoryDropDown.FormattingEnabled = true;
            this.CategoryDropDown.Location = new System.Drawing.Point(6, 34);
            this.CategoryDropDown.Name = "CategoryDropDown";
            this.CategoryDropDown.Size = new System.Drawing.Size(141, 23);
            this.CategoryDropDown.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Kategori";
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = System.Drawing.Color.Silver;
            HeaderPanel.Controls.Add(this.HeaderTextLabel);
            HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderPanel.Location = new System.Drawing.Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new System.Drawing.Size(449, 60);
            HeaderPanel.TabIndex = 15;
            // 
            // HeaderTextLabel
            // 
            this.HeaderTextLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HeaderTextLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HeaderTextLabel.ForeColor = System.Drawing.Color.Black;
            this.HeaderTextLabel.Location = new System.Drawing.Point(0, 0);
            this.HeaderTextLabel.Name = "HeaderTextLabel";
            this.HeaderTextLabel.Size = new System.Drawing.Size(239, 60);
            this.HeaderTextLabel.TabIndex = 0;
            this.HeaderTextLabel.Text = "Yeni Gider Ekle";
            this.HeaderTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddExpenseButton
            // 
            this.AddExpenseButton.Location = new System.Drawing.Point(350, 9);
            this.AddExpenseButton.Name = "AddExpenseButton";
            this.AddExpenseButton.Size = new System.Drawing.Size(87, 27);
            this.AddExpenseButton.TabIndex = 0;
            this.AddExpenseButton.Text = "Ekle";
            this.AddExpenseButton.UseVisualStyleBackColor = true;
            this.AddExpenseButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.MessageLabel);
            this.ActionsPanel.Controls.Add(this.AddExpenseButton);
            this.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionsPanel.Location = new System.Drawing.Point(0, 194);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(449, 45);
            this.ActionsPanel.TabIndex = 17;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.ForeColor = System.Drawing.Color.White;
            this.MessageLabel.Location = new System.Drawing.Point(12, 13);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Padding = new System.Windows.Forms.Padding(3);
            this.MessageLabel.Size = new System.Drawing.Size(6, 21);
            this.MessageLabel.TabIndex = 11;
            // 
            // AddExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 239);
            this.Controls.Add(ExpenseFormLayoutTable);
            this.Controls.Add(HeaderPanel);
            this.Controls.Add(this.ActionsPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddExpenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Gider Ekle";
            ExpenseDatePanel.ResumeLayout(false);
            ExpenseDatePanel.PerformLayout();
            SetAmountPanel.ResumeLayout(false);
            SetAmountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumericUpDown)).EndInit();
            ExpenseNotePanel.ResumeLayout(false);
            ExpenseNotePanel.PerformLayout();
            ExpenseFormLayoutTable.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            HeaderPanel.ResumeLayout(false);
            this.ActionsPanel.ResumeLayout(false);
            this.ActionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddExpenseButton;
        private System.Windows.Forms.NumericUpDown AmountNumericUpDown;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Panel ActionsPanel;
        private System.Windows.Forms.DateTimePicker ExpenseDatePicker;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.DateTimePicker ExpenseTimePicker;
        private System.Windows.Forms.ComboBox CategoryDropDown;
        private System.Windows.Forms.Label HeaderTextLabel;
    }
}