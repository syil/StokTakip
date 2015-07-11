namespace StokTakip.UI.Forms
{
    partial class AddActionLogForm
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
            System.Windows.Forms.Panel HeaderPanel;
            System.Windows.Forms.Label HeaderTextLabel;
            System.Windows.Forms.TableLayoutPanel ActionLogFormLayoutTable;
            System.Windows.Forms.Panel ItemDropDownListPanel;
            System.Windows.Forms.Label ItemDropDownListLabel;
            System.Windows.Forms.Panel SetQuantityPanel;
            System.Windows.Forms.Label SetQuantityLabel;
            System.Windows.Forms.Panel ActionLogNotePanel;
            System.Windows.Forms.Label ActionLogNoteLabel;
            this.AddActionButton = new System.Windows.Forms.Button();
            this.ItemsComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ChangeQuantitySignButton = new System.Windows.Forms.Button();
            this.CurrentItemDifferenceLabel = new System.Windows.Forms.Label();
            this.ActionsPanel = new System.Windows.Forms.Panel();
            this.AddNewItemLinkLabel = new System.Windows.Forms.LinkLabel();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            HeaderPanel = new System.Windows.Forms.Panel();
            HeaderTextLabel = new System.Windows.Forms.Label();
            ActionLogFormLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            ItemDropDownListPanel = new System.Windows.Forms.Panel();
            ItemDropDownListLabel = new System.Windows.Forms.Label();
            SetQuantityPanel = new System.Windows.Forms.Panel();
            SetQuantityLabel = new System.Windows.Forms.Label();
            ActionLogNotePanel = new System.Windows.Forms.Panel();
            ActionLogNoteLabel = new System.Windows.Forms.Label();
            HeaderPanel.SuspendLayout();
            ActionLogFormLayoutTable.SuspendLayout();
            ItemDropDownListPanel.SuspendLayout();
            SetQuantityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            this.ActionsPanel.SuspendLayout();
            ActionLogNotePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = System.Drawing.Color.Silver;
            HeaderPanel.Controls.Add(HeaderTextLabel);
            HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderPanel.Location = new System.Drawing.Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new System.Drawing.Size(460, 60);
            HeaderPanel.TabIndex = 11;
            // 
            // HeaderTextLabel
            // 
            HeaderTextLabel.Dock = System.Windows.Forms.DockStyle.Left;
            HeaderTextLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            HeaderTextLabel.ForeColor = System.Drawing.Color.Black;
            HeaderTextLabel.Location = new System.Drawing.Point(0, 0);
            HeaderTextLabel.Name = "HeaderTextLabel";
            HeaderTextLabel.Size = new System.Drawing.Size(239, 60);
            HeaderTextLabel.TabIndex = 0;
            HeaderTextLabel.Text = "Yeni Olay Ekle";
            HeaderTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddActionButton
            // 
            this.AddActionButton.Location = new System.Drawing.Point(361, 9);
            this.AddActionButton.Name = "AddActionButton";
            this.AddActionButton.Size = new System.Drawing.Size(87, 27);
            this.AddActionButton.TabIndex = 10;
            this.AddActionButton.Text = "Ekle";
            this.AddActionButton.UseVisualStyleBackColor = true;
            this.AddActionButton.Click += new System.EventHandler(this.AddActionButton_Click);
            // 
            // ActionLogFormLayoutTable
            // 
            ActionLogFormLayoutTable.ColumnCount = 2;
            ActionLogFormLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            ActionLogFormLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            ActionLogFormLayoutTable.Controls.Add(this.CurrentItemDifferenceLabel, 0, 2);
            ActionLogFormLayoutTable.Controls.Add(ItemDropDownListPanel, 0, 0);
            ActionLogFormLayoutTable.Controls.Add(SetQuantityPanel, 1, 0);
            ActionLogFormLayoutTable.Controls.Add(ActionLogNotePanel, 0, 1);
            ActionLogFormLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            ActionLogFormLayoutTable.Location = new System.Drawing.Point(0, 60);
            ActionLogFormLayoutTable.Name = "ActionLogFormLayoutTable";
            ActionLogFormLayoutTable.RowCount = 3;
            ActionLogFormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            ActionLogFormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            ActionLogFormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            ActionLogFormLayoutTable.Size = new System.Drawing.Size(460, 161);
            ActionLogFormLayoutTable.TabIndex = 13;
            // 
            // ItemDropDownListPanel
            // 
            ItemDropDownListPanel.Controls.Add(this.AddNewItemLinkLabel);
            ItemDropDownListPanel.Controls.Add(ItemDropDownListLabel);
            ItemDropDownListPanel.Controls.Add(this.ItemsComboBox);
            ItemDropDownListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ItemDropDownListPanel.Location = new System.Drawing.Point(3, 3);
            ItemDropDownListPanel.Name = "ItemDropDownListPanel";
            ItemDropDownListPanel.Size = new System.Drawing.Size(270, 70);
            ItemDropDownListPanel.TabIndex = 0;
            // 
            // ItemsComboBox
            // 
            this.ItemsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemsComboBox.FormattingEnabled = true;
            this.ItemsComboBox.Location = new System.Drawing.Point(12, 33);
            this.ItemsComboBox.Name = "ItemsComboBox";
            this.ItemsComboBox.Size = new System.Drawing.Size(245, 23);
            this.ItemsComboBox.TabIndex = 0;
            this.ItemsComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemsComboBox_SelectedIndexChanged);
            // 
            // ItemDropDownListLabel
            // 
            ItemDropDownListLabel.AutoSize = true;
            ItemDropDownListLabel.Location = new System.Drawing.Point(9, 10);
            ItemDropDownListLabel.Name = "ItemDropDownListLabel";
            ItemDropDownListLabel.Size = new System.Drawing.Size(54, 15);
            ItemDropDownListLabel.TabIndex = 1;
            ItemDropDownListLabel.Text = "İlgili Öğe";
            // 
            // SetQuantityPanel
            // 
            SetQuantityPanel.Controls.Add(this.ChangeQuantitySignButton);
            SetQuantityPanel.Controls.Add(this.QuantityNumericUpDown);
            SetQuantityPanel.Controls.Add(SetQuantityLabel);
            SetQuantityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            SetQuantityPanel.Location = new System.Drawing.Point(279, 3);
            SetQuantityPanel.Name = "SetQuantityPanel";
            SetQuantityPanel.Size = new System.Drawing.Size(178, 70);
            SetQuantityPanel.TabIndex = 1;
            // 
            // SetQuantityLabel
            // 
            SetQuantityLabel.AutoSize = true;
            SetQuantityLabel.Location = new System.Drawing.Point(3, 10);
            SetQuantityLabel.Name = "SetQuantityLabel";
            SetQuantityLabel.Size = new System.Drawing.Size(50, 15);
            SetQuantityLabel.TabIndex = 2;
            SetQuantityLabel.Text = "Değişim";
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(37, 33);
            this.QuantityNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.QuantityNumericUpDown.TabIndex = 3;
            this.QuantityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityNumericUpDown.ThousandsSeparator = true;
            this.QuantityNumericUpDown.ValueChanged += new System.EventHandler(this.QuantityNumericUpDown_ValueChanged);
            this.QuantityNumericUpDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.QuantityNumericUpDown_KeyUp);
            // 
            // ChangeQuantitySignButton
            // 
            this.ChangeQuantitySignButton.Location = new System.Drawing.Point(8, 32);
            this.ChangeQuantitySignButton.Name = "ChangeQuantitySignButton";
            this.ChangeQuantitySignButton.Size = new System.Drawing.Size(25, 25);
            this.ChangeQuantitySignButton.TabIndex = 5;
            this.ChangeQuantitySignButton.Text = "+";
            this.ChangeQuantitySignButton.UseVisualStyleBackColor = true;
            this.ChangeQuantitySignButton.Click += new System.EventHandler(this.ChangeQuantitySignButton_Click);
            // 
            // CurrentItemDifferenceLabel
            // 
            this.CurrentItemDifferenceLabel.AutoSize = true;
            ActionLogFormLayoutTable.SetColumnSpan(this.CurrentItemDifferenceLabel, 2);
            this.CurrentItemDifferenceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentItemDifferenceLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CurrentItemDifferenceLabel.Location = new System.Drawing.Point(3, 136);
            this.CurrentItemDifferenceLabel.Name = "CurrentItemDifferenceLabel";
            this.CurrentItemDifferenceLabel.Size = new System.Drawing.Size(454, 25);
            this.CurrentItemDifferenceLabel.TabIndex = 2;
            this.CurrentItemDifferenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.MessageLabel);
            this.ActionsPanel.Controls.Add(this.AddActionButton);
            this.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionsPanel.Location = new System.Drawing.Point(0, 221);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(460, 45);
            this.ActionsPanel.TabIndex = 14;
            // 
            // AddNewItemLinkLabel
            // 
            this.AddNewItemLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.AddNewItemLinkLabel.AutoSize = true;
            this.AddNewItemLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(1, 13);
            this.AddNewItemLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddNewItemLinkLabel.Location = new System.Drawing.Point(60, 9);
            this.AddNewItemLinkLabel.Name = "AddNewItemLinkLabel";
            this.AddNewItemLinkLabel.Size = new System.Drawing.Size(87, 21);
            this.AddNewItemLinkLabel.TabIndex = 2;
            this.AddNewItemLinkLabel.TabStop = true;
            this.AddNewItemLinkLabel.Text = "(Yeni Öğe Ekle)";
            this.AddNewItemLinkLabel.UseCompatibleTextRendering = true;
            this.AddNewItemLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddNewItemLinkLabel_LinkClicked);
            // 
            // ActionLogNotePanel
            // 
            ActionLogFormLayoutTable.SetColumnSpan(ActionLogNotePanel, 2);
            ActionLogNotePanel.Controls.Add(this.NoteTextBox);
            ActionLogNotePanel.Controls.Add(ActionLogNoteLabel);
            ActionLogNotePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ActionLogNotePanel.Location = new System.Drawing.Point(3, 79);
            ActionLogNotePanel.Name = "ActionLogNotePanel";
            ActionLogNotePanel.Size = new System.Drawing.Size(454, 54);
            ActionLogNotePanel.TabIndex = 3;
            // 
            // ActionLogNoteLabel
            // 
            ActionLogNoteLabel.AutoSize = true;
            ActionLogNoteLabel.Location = new System.Drawing.Point(9, 9);
            ActionLogNoteLabel.Name = "ActionLogNoteLabel";
            ActionLogNoteLabel.Size = new System.Drawing.Size(61, 15);
            ActionLogNoteLabel.TabIndex = 0;
            ActionLogNoteLabel.Text = "Olay Notu";
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NoteTextBox.Location = new System.Drawing.Point(76, 0);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(357, 54);
            this.NoteTextBox.TabIndex = 1;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(12, 15);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 15);
            this.MessageLabel.TabIndex = 11;
            // 
            // AddActionLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 266);
            this.Controls.Add(ActionLogFormLayoutTable);
            this.Controls.Add(HeaderPanel);
            this.Controls.Add(this.ActionsPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddActionLogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Olay Ekle";
            HeaderPanel.ResumeLayout(false);
            ActionLogFormLayoutTable.ResumeLayout(false);
            ActionLogFormLayoutTable.PerformLayout();
            ItemDropDownListPanel.ResumeLayout(false);
            ItemDropDownListPanel.PerformLayout();
            SetQuantityPanel.ResumeLayout(false);
            SetQuantityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            this.ActionsPanel.ResumeLayout(false);
            this.ActionsPanel.PerformLayout();
            ActionLogNotePanel.ResumeLayout(false);
            ActionLogNotePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddActionButton;
        private System.Windows.Forms.ComboBox ItemsComboBox;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.Button ChangeQuantitySignButton;
        private System.Windows.Forms.Label CurrentItemDifferenceLabel;
        private System.Windows.Forms.LinkLabel AddNewItemLinkLabel;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.Panel ActionsPanel;
        private System.Windows.Forms.Label MessageLabel;
    }
}