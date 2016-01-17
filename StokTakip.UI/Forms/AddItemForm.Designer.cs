namespace StokTakip.UI.Forms
{
    partial class AddItemForm
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
            System.Windows.Forms.Panel ItemPanel;
            System.Windows.Forms.Label ItemNameLabel;
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ActionsPanel = new System.Windows.Forms.Panel();
            this.NewItemFormLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            HeaderPanel = new System.Windows.Forms.Panel();
            HeaderTextLabel = new System.Windows.Forms.Label();
            ItemPanel = new System.Windows.Forms.Panel();
            ItemNameLabel = new System.Windows.Forms.Label();
            HeaderPanel.SuspendLayout();
            ItemPanel.SuspendLayout();
            this.ActionsPanel.SuspendLayout();
            this.NewItemFormLayoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = System.Drawing.Color.Silver;
            HeaderPanel.Controls.Add(HeaderTextLabel);
            HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderPanel.Location = new System.Drawing.Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new System.Drawing.Size(403, 60);
            HeaderPanel.TabIndex = 3;
            // 
            // HeaderTextLabel
            // 
            HeaderTextLabel.Dock = System.Windows.Forms.DockStyle.Left;
            HeaderTextLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            HeaderTextLabel.ForeColor = System.Drawing.Color.Black;
            HeaderTextLabel.Location = new System.Drawing.Point(0, 0);
            HeaderTextLabel.Name = "HeaderTextLabel";
            HeaderTextLabel.Size = new System.Drawing.Size(258, 60);
            HeaderTextLabel.TabIndex = 0;
            HeaderTextLabel.Text = "Yeni Öğe Ekle";
            HeaderTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemPanel
            // 
            ItemPanel.Controls.Add(ItemNameLabel);
            ItemPanel.Controls.Add(this.ItemNameTextBox);
            ItemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ItemPanel.Location = new System.Drawing.Point(3, 3);
            ItemPanel.Name = "ItemPanel";
            ItemPanel.Size = new System.Drawing.Size(397, 62);
            ItemPanel.TabIndex = 3;
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Location = new System.Drawing.Point(9, 10);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new System.Drawing.Size(50, 15);
            ItemNameLabel.TabIndex = 1;
            ItemNameLabel.Text = "Öğe Adı";
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemNameTextBox.Location = new System.Drawing.Point(9, 28);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(376, 23);
            this.ItemNameTextBox.TabIndex = 0;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(304, 9);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(87, 27);
            this.AddItemButton.TabIndex = 2;
            this.AddItemButton.Text = "Ekle";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.ForeColor = System.Drawing.Color.White;
            this.MessageLabel.Location = new System.Drawing.Point(12, 13);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Padding = new System.Windows.Forms.Padding(3);
            this.MessageLabel.Size = new System.Drawing.Size(6, 21);
            this.MessageLabel.TabIndex = 4;
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.AddItemButton);
            this.ActionsPanel.Controls.Add(this.MessageLabel);
            this.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionsPanel.Location = new System.Drawing.Point(0, 128);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(403, 45);
            this.ActionsPanel.TabIndex = 5;
            // 
            // NewItemFormLayoutTable
            // 
            this.NewItemFormLayoutTable.ColumnCount = 1;
            this.NewItemFormLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NewItemFormLayoutTable.Controls.Add(ItemPanel, 0, 0);
            this.NewItemFormLayoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewItemFormLayoutTable.Location = new System.Drawing.Point(0, 60);
            this.NewItemFormLayoutTable.Name = "NewItemFormLayoutTable";
            this.NewItemFormLayoutTable.RowCount = 1;
            this.NewItemFormLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NewItemFormLayoutTable.Size = new System.Drawing.Size(403, 68);
            this.NewItemFormLayoutTable.TabIndex = 6;
            // 
            // AddItemForm
            // 
            this.AcceptButton = this.AddItemButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 173);
            this.Controls.Add(this.NewItemFormLayoutTable);
            this.Controls.Add(this.ActionsPanel);
            this.Controls.Add(HeaderPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Öğe Ekle";
            HeaderPanel.ResumeLayout(false);
            ItemPanel.ResumeLayout(false);
            ItemPanel.PerformLayout();
            this.ActionsPanel.ResumeLayout(false);
            this.ActionsPanel.PerformLayout();
            this.NewItemFormLayoutTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TableLayoutPanel NewItemFormLayoutTable;
        private System.Windows.Forms.Panel ActionsPanel;
    }
}