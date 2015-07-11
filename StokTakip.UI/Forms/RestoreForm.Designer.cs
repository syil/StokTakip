namespace StokTakip.UI.Forms
{
    partial class RestoreForm
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
            this.ActionsPanel = new System.Windows.Forms.Panel();
            this.CreateBackupCheckBox = new System.Windows.Forms.CheckBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.BackupDatesListBox = new System.Windows.Forms.ListBox();
            HeaderPanel = new System.Windows.Forms.Panel();
            HeaderTextLabel = new System.Windows.Forms.Label();
            HeaderPanel.SuspendLayout();
            this.ActionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = System.Drawing.Color.Silver;
            HeaderPanel.Controls.Add(HeaderTextLabel);
            HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderPanel.Location = new System.Drawing.Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new System.Drawing.Size(349, 60);
            HeaderPanel.TabIndex = 6;
            // 
            // HeaderTextLabel
            // 
            HeaderTextLabel.Dock = System.Windows.Forms.DockStyle.Left;
            HeaderTextLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            HeaderTextLabel.ForeColor = System.Drawing.Color.Black;
            HeaderTextLabel.Location = new System.Drawing.Point(0, 0);
            HeaderTextLabel.Name = "HeaderTextLabel";
            HeaderTextLabel.Size = new System.Drawing.Size(288, 60);
            HeaderTextLabel.TabIndex = 0;
            HeaderTextLabel.Text = "Geri Yükleme";
            HeaderTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.CreateBackupCheckBox);
            this.ActionsPanel.Controls.Add(this.AddItemButton);
            this.ActionsPanel.Controls.Add(this.MessageLabel);
            this.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionsPanel.Location = new System.Drawing.Point(0, 467);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new System.Drawing.Size(349, 45);
            this.ActionsPanel.TabIndex = 7;
            // 
            // CreateBackupCheckBox
            // 
            this.CreateBackupCheckBox.AutoSize = true;
            this.CreateBackupCheckBox.Checked = true;
            this.CreateBackupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CreateBackupCheckBox.Location = new System.Drawing.Point(18, 14);
            this.CreateBackupCheckBox.Name = "CreateBackupCheckBox";
            this.CreateBackupCheckBox.Size = new System.Drawing.Size(191, 19);
            this.CreateBackupCheckBox.TabIndex = 5;
            this.CreateBackupCheckBox.Text = "Şu anki verinin yedeğini oluştur";
            this.CreateBackupCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddItemButton.Location = new System.Drawing.Point(250, 9);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(87, 27);
            this.AddItemButton.TabIndex = 2;
            this.AddItemButton.Text = "Seç";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(12, 15);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 15);
            this.MessageLabel.TabIndex = 4;
            // 
            // BackupDatesListBox
            // 
            this.BackupDatesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackupDatesListBox.FormatString = "F";
            this.BackupDatesListBox.FormattingEnabled = true;
            this.BackupDatesListBox.ItemHeight = 15;
            this.BackupDatesListBox.Location = new System.Drawing.Point(0, 60);
            this.BackupDatesListBox.Name = "BackupDatesListBox";
            this.BackupDatesListBox.Size = new System.Drawing.Size(349, 407);
            this.BackupDatesListBox.TabIndex = 8;
            // 
            // RestoreForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(349, 512);
            this.Controls.Add(this.BackupDatesListBox);
            this.Controls.Add(this.ActionsPanel);
            this.Controls.Add(HeaderPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RestoreForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Geri Yükleme";
            HeaderPanel.ResumeLayout(false);
            this.ActionsPanel.ResumeLayout(false);
            this.ActionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ActionsPanel;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.CheckBox CreateBackupCheckBox;
        private System.Windows.Forms.ListBox BackupDatesListBox;
    }
}