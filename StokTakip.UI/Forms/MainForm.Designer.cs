namespace StokTakip.UI.Forms
{
    partial class MainForm
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
            System.Windows.Forms.Label HeaderTextLabel;
            System.Windows.Forms.Panel HeaderPanel;
            System.Windows.Forms.Panel FooterPanel;
            System.Windows.Forms.Label TaskHeaderLabel;
            this.StatusTextLabel = new System.Windows.Forms.Label();
            this.StatusPictureBox = new System.Windows.Forms.PictureBox();
            this.InnerTaskTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HelpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.OpenReportsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AddNewActionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AddNewItemLinkLabel = new System.Windows.Forms.LinkLabel();
            this.StatisticsPanel = new System.Windows.Forms.Panel();
            this.OpenSettingsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ReturnToRestorePointLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AddNewExpenseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ListExpensesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.HorizontalSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ItemListControl = new StokTakip.UI.Controls.ItemListControl();
            this.ActionLogListControl = new StokTakip.UI.Controls.ActionLogListControl();
            this.VerticalSplitContainer = new System.Windows.Forms.SplitContainer();
            HeaderTextLabel = new System.Windows.Forms.Label();
            HeaderPanel = new System.Windows.Forms.Panel();
            FooterPanel = new System.Windows.Forms.Panel();
            TaskHeaderLabel = new System.Windows.Forms.Label();
            HeaderPanel.SuspendLayout();
            FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).BeginInit();
            this.InnerTaskTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSplitContainer)).BeginInit();
            this.HorizontalSplitContainer.Panel1.SuspendLayout();
            this.HorizontalSplitContainer.Panel2.SuspendLayout();
            this.HorizontalSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSplitContainer)).BeginInit();
            this.VerticalSplitContainer.Panel1.SuspendLayout();
            this.VerticalSplitContainer.Panel2.SuspendLayout();
            this.VerticalSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderTextLabel
            // 
            HeaderTextLabel.Dock = System.Windows.Forms.DockStyle.Left;
            HeaderTextLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            HeaderTextLabel.ForeColor = System.Drawing.Color.Black;
            HeaderTextLabel.Location = new System.Drawing.Point(0, 0);
            HeaderTextLabel.Name = "HeaderTextLabel";
            HeaderTextLabel.Size = new System.Drawing.Size(427, 60);
            HeaderTextLabel.TabIndex = 0;
            HeaderTextLabel.Text = "Stok Takip";
            HeaderTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = System.Drawing.Color.Silver;
            HeaderPanel.Controls.Add(HeaderTextLabel);
            HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderPanel.Location = new System.Drawing.Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new System.Drawing.Size(1107, 60);
            HeaderPanel.TabIndex = 2;
            // 
            // FooterPanel
            // 
            FooterPanel.Controls.Add(this.StatusTextLabel);
            FooterPanel.Controls.Add(this.StatusPictureBox);
            FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            FooterPanel.Location = new System.Drawing.Point(0, 554);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Size = new System.Drawing.Size(1107, 24);
            FooterPanel.TabIndex = 3;
            // 
            // StatusTextLabel
            // 
            this.StatusTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusTextLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusTextLabel.Location = new System.Drawing.Point(24, 0);
            this.StatusTextLabel.Name = "StatusTextLabel";
            this.StatusTextLabel.Size = new System.Drawing.Size(1083, 24);
            this.StatusTextLabel.TabIndex = 0;
            this.StatusTextLabel.Text = "Hazır";
            this.StatusTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusPictureBox
            // 
            this.StatusPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.StatusPictureBox.Location = new System.Drawing.Point(0, 0);
            this.StatusPictureBox.Name = "StatusPictureBox";
            this.StatusPictureBox.Size = new System.Drawing.Size(24, 24);
            this.StatusPictureBox.TabIndex = 0;
            this.StatusPictureBox.TabStop = false;
            // 
            // TaskHeaderLabel
            // 
            TaskHeaderLabel.BackColor = System.Drawing.Color.DimGray;
            TaskHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            TaskHeaderLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            TaskHeaderLabel.ForeColor = System.Drawing.Color.White;
            TaskHeaderLabel.Location = new System.Drawing.Point(0, 0);
            TaskHeaderLabel.Name = "TaskHeaderLabel";
            TaskHeaderLabel.Size = new System.Drawing.Size(253, 33);
            TaskHeaderLabel.TabIndex = 1;
            TaskHeaderLabel.Text = "Görevler";
            TaskHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InnerTaskTableLayoutPanel
            // 
            this.InnerTaskTableLayoutPanel.ColumnCount = 1;
            this.InnerTaskTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InnerTaskTableLayoutPanel.Controls.Add(this.HelpLinkLabel, 0, 7);
            this.InnerTaskTableLayoutPanel.Controls.Add(this.OpenReportsLinkLabel, 0, 4);
            this.InnerTaskTableLayoutPanel.Controls.Add(this.AddNewActionLinkLabel, 0, 1);
            this.InnerTaskTableLayoutPanel.Controls.Add(this.AddNewItemLinkLabel, 0, 0);
            this.InnerTaskTableLayoutPanel.Controls.Add(this.StatisticsPanel, 0, 8);
            this.InnerTaskTableLayoutPanel.Controls.Add(this.OpenSettingsLinkLabel, 0, 5);
            this.InnerTaskTableLayoutPanel.Controls.Add(this.ReturnToRestorePointLinkLabel, 0, 6);
            this.InnerTaskTableLayoutPanel.Controls.Add(this.AddNewExpenseLinkLabel, 0, 2);
            this.InnerTaskTableLayoutPanel.Controls.Add(this.ListExpensesLinkLabel, 0, 3);
            this.InnerTaskTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerTaskTableLayoutPanel.Location = new System.Drawing.Point(0, 33);
            this.InnerTaskTableLayoutPanel.Name = "InnerTaskTableLayoutPanel";
            this.InnerTaskTableLayoutPanel.RowCount = 9;
            this.InnerTaskTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.InnerTaskTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.InnerTaskTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.InnerTaskTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.InnerTaskTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.InnerTaskTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.InnerTaskTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.InnerTaskTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.InnerTaskTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InnerTaskTableLayoutPanel.Size = new System.Drawing.Size(253, 461);
            this.InnerTaskTableLayoutPanel.TabIndex = 0;
            // 
            // HelpLinkLabel
            // 
            this.HelpLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.HelpLinkLabel.AutoSize = true;
            this.HelpLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpLinkLabel.Enabled = false;
            this.HelpLinkLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HelpLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.HelpLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.HelpLinkLabel.Location = new System.Drawing.Point(3, 175);
            this.HelpLinkLabel.Name = "HelpLinkLabel";
            this.HelpLinkLabel.Size = new System.Drawing.Size(247, 25);
            this.HelpLinkLabel.TabIndex = 3;
            this.HelpLinkLabel.TabStop = true;
            this.HelpLinkLabel.Text = "Yardım";
            this.HelpLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OpenReportsLinkLabel
            // 
            this.OpenReportsLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.OpenReportsLinkLabel.AutoSize = true;
            this.OpenReportsLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenReportsLinkLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OpenReportsLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.OpenReportsLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.OpenReportsLinkLabel.Location = new System.Drawing.Point(3, 100);
            this.OpenReportsLinkLabel.Name = "OpenReportsLinkLabel";
            this.OpenReportsLinkLabel.Size = new System.Drawing.Size(247, 25);
            this.OpenReportsLinkLabel.TabIndex = 2;
            this.OpenReportsLinkLabel.TabStop = true;
            this.OpenReportsLinkLabel.Text = "Raporlar && Grafikler";
            this.OpenReportsLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenReportsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenReportsLinkLabel_LinkClicked);
            // 
            // AddNewActionLinkLabel
            // 
            this.AddNewActionLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.AddNewActionLinkLabel.AutoSize = true;
            this.AddNewActionLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddNewActionLinkLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddNewActionLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.AddNewActionLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddNewActionLinkLabel.Location = new System.Drawing.Point(3, 25);
            this.AddNewActionLinkLabel.Name = "AddNewActionLinkLabel";
            this.AddNewActionLinkLabel.Size = new System.Drawing.Size(247, 25);
            this.AddNewActionLinkLabel.TabIndex = 1;
            this.AddNewActionLinkLabel.TabStop = true;
            this.AddNewActionLinkLabel.Text = "Yeni Olay Ekle";
            this.AddNewActionLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewActionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddNewActionLinkLabel_LinkClicked);
            // 
            // AddNewItemLinkLabel
            // 
            this.AddNewItemLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.AddNewItemLinkLabel.AutoSize = true;
            this.AddNewItemLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddNewItemLinkLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddNewItemLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.AddNewItemLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddNewItemLinkLabel.Location = new System.Drawing.Point(3, 0);
            this.AddNewItemLinkLabel.Name = "AddNewItemLinkLabel";
            this.AddNewItemLinkLabel.Size = new System.Drawing.Size(247, 25);
            this.AddNewItemLinkLabel.TabIndex = 0;
            this.AddNewItemLinkLabel.TabStop = true;
            this.AddNewItemLinkLabel.Text = "Yeni Öğe Ekle";
            this.AddNewItemLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewItemLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddNewItemLinkLabel_LinkClicked);
            // 
            // StatisticsPanel
            // 
            this.StatisticsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatisticsPanel.Location = new System.Drawing.Point(3, 203);
            this.StatisticsPanel.Name = "StatisticsPanel";
            this.StatisticsPanel.Size = new System.Drawing.Size(247, 348);
            this.StatisticsPanel.TabIndex = 4;
            // 
            // OpenSettingsLinkLabel
            // 
            this.OpenSettingsLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.OpenSettingsLinkLabel.AutoSize = true;
            this.OpenSettingsLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenSettingsLinkLabel.Enabled = false;
            this.OpenSettingsLinkLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OpenSettingsLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.OpenSettingsLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.OpenSettingsLinkLabel.Location = new System.Drawing.Point(3, 125);
            this.OpenSettingsLinkLabel.Name = "OpenSettingsLinkLabel";
            this.OpenSettingsLinkLabel.Size = new System.Drawing.Size(247, 25);
            this.OpenSettingsLinkLabel.TabIndex = 2;
            this.OpenSettingsLinkLabel.TabStop = true;
            this.OpenSettingsLinkLabel.Text = "Ayarlar";
            this.OpenSettingsLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReturnToRestorePointLinkLabel
            // 
            this.ReturnToRestorePointLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.ReturnToRestorePointLinkLabel.AutoSize = true;
            this.ReturnToRestorePointLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReturnToRestorePointLinkLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ReturnToRestorePointLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ReturnToRestorePointLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.ReturnToRestorePointLinkLabel.Location = new System.Drawing.Point(3, 150);
            this.ReturnToRestorePointLinkLabel.Name = "ReturnToRestorePointLinkLabel";
            this.ReturnToRestorePointLinkLabel.Size = new System.Drawing.Size(247, 25);
            this.ReturnToRestorePointLinkLabel.TabIndex = 2;
            this.ReturnToRestorePointLinkLabel.TabStop = true;
            this.ReturnToRestorePointLinkLabel.Text = "Yedeğe Geri Dön";
            this.ReturnToRestorePointLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReturnToRestorePointLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReturnToRestorePointLinkLabel_LinkClicked);
            // 
            // AddNewExpenseLinkLabel
            // 
            this.AddNewExpenseLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.AddNewExpenseLinkLabel.AutoSize = true;
            this.AddNewExpenseLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddNewExpenseLinkLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddNewExpenseLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.AddNewExpenseLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddNewExpenseLinkLabel.Location = new System.Drawing.Point(3, 50);
            this.AddNewExpenseLinkLabel.Name = "AddNewExpenseLinkLabel";
            this.AddNewExpenseLinkLabel.Size = new System.Drawing.Size(247, 25);
            this.AddNewExpenseLinkLabel.TabIndex = 1;
            this.AddNewExpenseLinkLabel.TabStop = true;
            this.AddNewExpenseLinkLabel.Text = "Yeni Gider Ekle";
            this.AddNewExpenseLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewExpenseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddNewExpenseLinkLabel_LinkClicked);
            // 
            // ListExpensesLinkLabel
            // 
            this.ListExpensesLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.ListExpensesLinkLabel.AutoSize = true;
            this.ListExpensesLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListExpensesLinkLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListExpensesLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ListExpensesLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.ListExpensesLinkLabel.Location = new System.Drawing.Point(3, 75);
            this.ListExpensesLinkLabel.Name = "ListExpensesLinkLabel";
            this.ListExpensesLinkLabel.Size = new System.Drawing.Size(247, 25);
            this.ListExpensesLinkLabel.TabIndex = 1;
            this.ListExpensesLinkLabel.TabStop = true;
            this.ListExpensesLinkLabel.Text = "Giderleri Listele";
            this.ListExpensesLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListExpensesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ListExpensesLinkLabel_LinkClicked);
            // 
            // HorizontalSplitContainer
            // 
            this.HorizontalSplitContainer.BackColor = System.Drawing.Color.Silver;
            this.HorizontalSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HorizontalSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.HorizontalSplitContainer.Name = "HorizontalSplitContainer";
            this.HorizontalSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // HorizontalSplitContainer.Panel1
            // 
            this.HorizontalSplitContainer.Panel1.Controls.Add(this.ItemListControl);
            // 
            // HorizontalSplitContainer.Panel2
            // 
            this.HorizontalSplitContainer.Panel2.Controls.Add(this.ActionLogListControl);
            this.HorizontalSplitContainer.Size = new System.Drawing.Size(849, 494);
            this.HorizontalSplitContainer.SplitterDistance = 313;
            this.HorizontalSplitContainer.SplitterWidth = 5;
            this.HorizontalSplitContainer.TabIndex = 1;
            // 
            // ItemListControl
            // 
            this.ItemListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemListControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ItemListControl.Location = new System.Drawing.Point(0, 0);
            this.ItemListControl.Name = "ItemListControl";
            this.ItemListControl.Size = new System.Drawing.Size(849, 313);
            this.ItemListControl.TabIndex = 0;
            this.ItemListControl.ActionLogListNeedsUpdated += new System.EventHandler(this.ItemListControl_ActionLogListNeedsUpdated);
            // 
            // ActionLogListControl
            // 
            this.ActionLogListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionLogListControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ActionLogListControl.Location = new System.Drawing.Point(0, 0);
            this.ActionLogListControl.Name = "ActionLogListControl";
            this.ActionLogListControl.SelectedItem = null;
            this.ActionLogListControl.Size = new System.Drawing.Size(849, 176);
            this.ActionLogListControl.TabIndex = 0;
            // 
            // VerticalSplitContainer
            // 
            this.VerticalSplitContainer.BackColor = System.Drawing.Color.Silver;
            this.VerticalSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VerticalSplitContainer.Location = new System.Drawing.Point(0, 60);
            this.VerticalSplitContainer.Name = "VerticalSplitContainer";
            // 
            // VerticalSplitContainer.Panel1
            // 
            this.VerticalSplitContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.VerticalSplitContainer.Panel1.Controls.Add(this.InnerTaskTableLayoutPanel);
            this.VerticalSplitContainer.Panel1.Controls.Add(TaskHeaderLabel);
            // 
            // VerticalSplitContainer.Panel2
            // 
            this.VerticalSplitContainer.Panel2.Controls.Add(this.HorizontalSplitContainer);
            this.VerticalSplitContainer.Size = new System.Drawing.Size(1107, 494);
            this.VerticalSplitContainer.SplitterDistance = 253;
            this.VerticalSplitContainer.SplitterWidth = 5;
            this.VerticalSplitContainer.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 578);
            this.Controls.Add(this.VerticalSplitContainer);
            this.Controls.Add(HeaderPanel);
            this.Controls.Add(FooterPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Stok Takip";
            this.Load += new System.EventHandler(this.MainForm_Load);
            HeaderPanel.ResumeLayout(false);
            FooterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).EndInit();
            this.InnerTaskTableLayoutPanel.ResumeLayout(false);
            this.InnerTaskTableLayoutPanel.PerformLayout();
            this.HorizontalSplitContainer.Panel1.ResumeLayout(false);
            this.HorizontalSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSplitContainer)).EndInit();
            this.HorizontalSplitContainer.ResumeLayout(false);
            this.VerticalSplitContainer.Panel1.ResumeLayout(false);
            this.VerticalSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSplitContainer)).EndInit();
            this.VerticalSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer HorizontalSplitContainer;
        private System.Windows.Forms.SplitContainer VerticalSplitContainer;
        private System.Windows.Forms.TableLayoutPanel InnerTaskTableLayoutPanel;
        private System.Windows.Forms.LinkLabel HelpLinkLabel;
        private System.Windows.Forms.LinkLabel OpenReportsLinkLabel;
        private System.Windows.Forms.LinkLabel AddNewActionLinkLabel;
        private System.Windows.Forms.LinkLabel AddNewItemLinkLabel;
        private System.Windows.Forms.Panel StatisticsPanel;
        private System.Windows.Forms.Label StatusTextLabel;
        private System.Windows.Forms.PictureBox StatusPictureBox;
        private System.Windows.Forms.LinkLabel OpenSettingsLinkLabel;
        private System.Windows.Forms.LinkLabel ReturnToRestorePointLinkLabel;
        private System.Windows.Forms.LinkLabel AddNewExpenseLinkLabel;
        private System.Windows.Forms.LinkLabel ListExpensesLinkLabel;
        private Controls.ItemListControl ItemListControl;
        private Controls.ActionLogListControl ActionLogListControl;
    }
}

