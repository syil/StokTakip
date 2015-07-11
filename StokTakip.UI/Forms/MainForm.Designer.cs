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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label HeaderTextLabel;
            System.Windows.Forms.Panel HeaderPanel;
            System.Windows.Forms.ColumnHeader ActionItemNameColumn;
            System.Windows.Forms.ColumnHeader OldQuantityColumn;
            System.Windows.Forms.ColumnHeader NewQuantityColumn;
            System.Windows.Forms.ColumnHeader DifferenceColumn;
            System.Windows.Forms.ColumnHeader DescriptionColumn;
            System.Windows.Forms.ColumnHeader ActionDateColumn;
            System.Windows.Forms.ColumnHeader NameColumn;
            System.Windows.Forms.ColumnHeader QuantityColumn;
            System.Windows.Forms.ColumnHeader InsertDateColumn;
            System.Windows.Forms.Panel FooterPanel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label TaskHeaderLabel;
            System.Windows.Forms.MenuItem Seperator1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StatusTextLabel = new System.Windows.Forms.Label();
            this.DeleteItemMenuItem = new System.Windows.Forms.MenuItem();
            this.InnerTaskTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HelpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.OpenReportsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AddNewActionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AddNewItemLinkLabel = new System.Windows.Forms.LinkLabel();
            this.StatisticsPanel = new System.Windows.Forms.Panel();
            this.HorizontalSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ItemFilterTextBox = new System.Windows.Forms.TextBox();
            this.ItemListView = new System.Windows.Forms.ListView();
            this.ItemListLargeImageList = new System.Windows.Forms.ImageList(this.components);
            this.ActionLogFilterLabel = new System.Windows.Forms.Label();
            this.ActionLogListView = new System.Windows.Forms.ListView();
            this.ActionLogSmallImageList = new System.Windows.Forms.ImageList(this.components);
            this.VerticalSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ItemListContextMenu = new System.Windows.Forms.ContextMenu();
            this.NewActionMenuItem = new System.Windows.Forms.MenuItem();
            this.ListActionLogsOfItemMenuItem = new System.Windows.Forms.MenuItem();
            this.UndoLastActionMenuItem = new System.Windows.Forms.MenuItem();
            this.OpenSettingsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ReturnToRestorePointLinkLabel = new System.Windows.Forms.LinkLabel();
            this.StatusPictureBox = new System.Windows.Forms.PictureBox();
            HeaderTextLabel = new System.Windows.Forms.Label();
            HeaderPanel = new System.Windows.Forms.Panel();
            ActionItemNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            OldQuantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            NewQuantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            DifferenceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            DescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ActionDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            QuantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            InsertDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            FooterPanel = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            TaskHeaderLabel = new System.Windows.Forms.Label();
            Seperator1 = new System.Windows.Forms.MenuItem();
            HeaderPanel.SuspendLayout();
            FooterPanel.SuspendLayout();
            this.InnerTaskTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSplitContainer)).BeginInit();
            this.HorizontalSplitContainer.Panel1.SuspendLayout();
            this.HorizontalSplitContainer.Panel2.SuspendLayout();
            this.HorizontalSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSplitContainer)).BeginInit();
            this.VerticalSplitContainer.Panel1.SuspendLayout();
            this.VerticalSplitContainer.Panel2.SuspendLayout();
            this.VerticalSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).BeginInit();
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
            // ActionItemNameColumn
            // 
            ActionItemNameColumn.Text = "Öğe Adı";
            ActionItemNameColumn.Width = 158;
            // 
            // OldQuantityColumn
            // 
            OldQuantityColumn.Text = "Eski Adet";
            OldQuantityColumn.Width = 80;
            // 
            // NewQuantityColumn
            // 
            NewQuantityColumn.Text = "Yeni Adet";
            NewQuantityColumn.Width = 85;
            // 
            // DifferenceColumn
            // 
            DifferenceColumn.Text = "Değişim";
            DifferenceColumn.Width = 68;
            // 
            // DescriptionColumn
            // 
            DescriptionColumn.Text = "Açıklama";
            DescriptionColumn.Width = 186;
            // 
            // ActionDateColumn
            // 
            ActionDateColumn.Text = "Zaman";
            ActionDateColumn.Width = 97;
            // 
            // NameColumn
            // 
            NameColumn.Text = "Öğe Adı";
            // 
            // QuantityColumn
            // 
            QuantityColumn.Text = "Adet";
            // 
            // InsertDateColumn
            // 
            InsertDateColumn.Text = "Eklenme Tarihi";
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
            // label1
            // 
            label1.BackColor = System.Drawing.Color.DimGray;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(849, 33);
            label1.TabIndex = 2;
            label1.Text = "Öğe Listesi";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.DimGray;
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(849, 33);
            label2.TabIndex = 3;
            label2.Text = "Olay Listesi";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // Seperator1
            // 
            Seperator1.Index = 3;
            Seperator1.Text = "-";
            // 
            // DeleteItemMenuItem
            // 
            this.DeleteItemMenuItem.Index = 4;
            this.DeleteItemMenuItem.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.DeleteItemMenuItem.Text = "Öğeyi Sil";
            this.DeleteItemMenuItem.Click += new System.EventHandler(this.DeleteItemMenuItem_Click);
            // 
            // InnerTaskTableLayoutPanel
            // 
            this.InnerTaskTableLayoutPanel.ColumnCount = 1;
            this.InnerTaskTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InnerTaskTableLayoutPanel.Controls.Add(this.HelpLinkLabel, 0, 5);
            this.InnerTaskTableLayoutPanel.Controls.Add(this.OpenReportsLinkLabel, 0, 2);
            this.InnerTaskTableLayoutPanel.Controls.Add(this.AddNewActionLinkLabel, 0, 1);
            this.InnerTaskTableLayoutPanel.Controls.Add(this.AddNewItemLinkLabel, 0, 0);
            this.InnerTaskTableLayoutPanel.Controls.Add(this.StatisticsPanel, 0, 6);
            this.InnerTaskTableLayoutPanel.Controls.Add(this.OpenSettingsLinkLabel, 0, 3);
            this.InnerTaskTableLayoutPanel.Controls.Add(this.ReturnToRestorePointLinkLabel, 0, 4);
            this.InnerTaskTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InnerTaskTableLayoutPanel.Location = new System.Drawing.Point(0, 33);
            this.InnerTaskTableLayoutPanel.Name = "InnerTaskTableLayoutPanel";
            this.InnerTaskTableLayoutPanel.RowCount = 7;
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
            this.HelpLinkLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HelpLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.HelpLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.HelpLinkLabel.Location = new System.Drawing.Point(3, 125);
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
            this.OpenReportsLinkLabel.Location = new System.Drawing.Point(3, 50);
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
            this.StatisticsPanel.Location = new System.Drawing.Point(3, 153);
            this.StatisticsPanel.Name = "StatisticsPanel";
            this.StatisticsPanel.Size = new System.Drawing.Size(247, 348);
            this.StatisticsPanel.TabIndex = 4;
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
            this.HorizontalSplitContainer.Panel1.Controls.Add(this.ItemFilterTextBox);
            this.HorizontalSplitContainer.Panel1.Controls.Add(this.ItemListView);
            this.HorizontalSplitContainer.Panel1.Controls.Add(label1);
            // 
            // HorizontalSplitContainer.Panel2
            // 
            this.HorizontalSplitContainer.Panel2.Controls.Add(this.ActionLogFilterLabel);
            this.HorizontalSplitContainer.Panel2.Controls.Add(this.ActionLogListView);
            this.HorizontalSplitContainer.Panel2.Controls.Add(label2);
            this.HorizontalSplitContainer.Size = new System.Drawing.Size(849, 494);
            this.HorizontalSplitContainer.SplitterDistance = 313;
            this.HorizontalSplitContainer.SplitterWidth = 5;
            this.HorizontalSplitContainer.TabIndex = 1;
            // 
            // ItemFilterTextBox
            // 
            this.ItemFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemFilterTextBox.Location = new System.Drawing.Point(643, 5);
            this.ItemFilterTextBox.Name = "ItemFilterTextBox";
            this.ItemFilterTextBox.Size = new System.Drawing.Size(200, 23);
            this.ItemFilterTextBox.TabIndex = 3;
            this.ItemFilterTextBox.TextChanged += new System.EventHandler(this.ItemFilterTextBox_TextChanged);
            this.ItemFilterTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ItemFilterTextBox_KeyUp);
            // 
            // ItemListView
            // 
            this.ItemListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ItemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            NameColumn,
            QuantityColumn,
            InsertDateColumn});
            this.ItemListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemListView.FullRowSelect = true;
            this.ItemListView.GridLines = true;
            this.ItemListView.HotTracking = true;
            this.ItemListView.HoverSelection = true;
            this.ItemListView.LargeImageList = this.ItemListLargeImageList;
            this.ItemListView.Location = new System.Drawing.Point(0, 33);
            this.ItemListView.MultiSelect = false;
            this.ItemListView.Name = "ItemListView";
            this.ItemListView.Size = new System.Drawing.Size(849, 280);
            this.ItemListView.TabIndex = 0;
            this.ItemListView.TileSize = new System.Drawing.Size(250, 60);
            this.ItemListView.UseCompatibleStateImageBehavior = false;
            this.ItemListView.View = System.Windows.Forms.View.Tile;
            this.ItemListView.DoubleClick += new System.EventHandler(this.ItemListView_DoubleClick);
            // 
            // ItemListLargeImageList
            // 
            this.ItemListLargeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ItemListLargeImageList.ImageStream")));
            this.ItemListLargeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ItemListLargeImageList.Images.SetKeyName(0, "Blank");
            // 
            // ActionLogFilterLabel
            // 
            this.ActionLogFilterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionLogFilterLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ActionLogFilterLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ActionLogFilterLabel.ForeColor = System.Drawing.Color.White;
            this.ActionLogFilterLabel.Location = new System.Drawing.Point(311, 10);
            this.ActionLogFilterLabel.Name = "ActionLogFilterLabel";
            this.ActionLogFilterLabel.Size = new System.Drawing.Size(532, 13);
            this.ActionLogFilterLabel.TabIndex = 5;
            this.ActionLogFilterLabel.Text = "Tüm öğeler için listeleniyor";
            this.ActionLogFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ActionLogListView
            // 
            this.ActionLogListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            ActionItemNameColumn,
            ActionDateColumn,
            OldQuantityColumn,
            NewQuantityColumn,
            DifferenceColumn,
            DescriptionColumn});
            this.ActionLogListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionLogListView.FullRowSelect = true;
            this.ActionLogListView.Location = new System.Drawing.Point(0, 33);
            this.ActionLogListView.Name = "ActionLogListView";
            this.ActionLogListView.Size = new System.Drawing.Size(849, 143);
            this.ActionLogListView.SmallImageList = this.ActionLogSmallImageList;
            this.ActionLogListView.TabIndex = 0;
            this.ActionLogListView.UseCompatibleStateImageBehavior = false;
            this.ActionLogListView.View = System.Windows.Forms.View.Details;
            // 
            // ActionLogSmallImageList
            // 
            this.ActionLogSmallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ActionLogSmallImageList.ImageStream")));
            this.ActionLogSmallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ActionLogSmallImageList.Images.SetKeyName(0, "Blank");
            this.ActionLogSmallImageList.Images.SetKeyName(1, "Ascending");
            this.ActionLogSmallImageList.Images.SetKeyName(2, "Descending");
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
            // ItemListContextMenu
            // 
            this.ItemListContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.NewActionMenuItem,
            this.ListActionLogsOfItemMenuItem,
            this.UndoLastActionMenuItem,
            Seperator1,
            this.DeleteItemMenuItem});
            this.ItemListContextMenu.Popup += new System.EventHandler(this.ItemListContextMenu_Popup);
            // 
            // NewActionMenuItem
            // 
            this.NewActionMenuItem.DefaultItem = true;
            this.NewActionMenuItem.Index = 0;
            this.NewActionMenuItem.Text = "Olay ekle";
            this.NewActionMenuItem.Click += new System.EventHandler(this.NewActionMenuItem_Click);
            // 
            // ListActionLogsOfItemMenuItem
            // 
            this.ListActionLogsOfItemMenuItem.Index = 1;
            this.ListActionLogsOfItemMenuItem.Text = "Olayları Listele";
            this.ListActionLogsOfItemMenuItem.Click += new System.EventHandler(this.ListActionLogsOfItemMenuItem_Click);
            // 
            // UndoLastActionMenuItem
            // 
            this.UndoLastActionMenuItem.Index = 2;
            this.UndoLastActionMenuItem.Text = "Son eklenen olayı geri al";
            this.UndoLastActionMenuItem.Click += new System.EventHandler(this.UndoLastActionMenuItem_Click);
            // 
            // OpenSettingsLinkLabel
            // 
            this.OpenSettingsLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.OpenSettingsLinkLabel.AutoSize = true;
            this.OpenSettingsLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenSettingsLinkLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OpenSettingsLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.OpenSettingsLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.OpenSettingsLinkLabel.Location = new System.Drawing.Point(3, 75);
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
            this.ReturnToRestorePointLinkLabel.Location = new System.Drawing.Point(3, 100);
            this.ReturnToRestorePointLinkLabel.Name = "ReturnToRestorePointLinkLabel";
            this.ReturnToRestorePointLinkLabel.Size = new System.Drawing.Size(247, 25);
            this.ReturnToRestorePointLinkLabel.TabIndex = 2;
            this.ReturnToRestorePointLinkLabel.TabStop = true;
            this.ReturnToRestorePointLinkLabel.Text = "Yedeğe Geri Dön";
            this.ReturnToRestorePointLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReturnToRestorePointLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ReturnToRestorePointLinkLabel_LinkClicked);
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
            this.InnerTaskTableLayoutPanel.ResumeLayout(false);
            this.InnerTaskTableLayoutPanel.PerformLayout();
            this.HorizontalSplitContainer.Panel1.ResumeLayout(false);
            this.HorizontalSplitContainer.Panel1.PerformLayout();
            this.HorizontalSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalSplitContainer)).EndInit();
            this.HorizontalSplitContainer.ResumeLayout(false);
            this.VerticalSplitContainer.Panel1.ResumeLayout(false);
            this.VerticalSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VerticalSplitContainer)).EndInit();
            this.VerticalSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer HorizontalSplitContainer;
        private System.Windows.Forms.SplitContainer VerticalSplitContainer;
        private System.Windows.Forms.ListView ActionLogListView;
        private System.Windows.Forms.TableLayoutPanel InnerTaskTableLayoutPanel;
        private System.Windows.Forms.LinkLabel HelpLinkLabel;
        private System.Windows.Forms.LinkLabel OpenReportsLinkLabel;
        private System.Windows.Forms.LinkLabel AddNewActionLinkLabel;
        private System.Windows.Forms.LinkLabel AddNewItemLinkLabel;
        private System.Windows.Forms.Panel StatisticsPanel;
        private System.Windows.Forms.ListView ItemListView;
        private System.Windows.Forms.ImageList ItemListLargeImageList;
        private System.Windows.Forms.ImageList ActionLogSmallImageList;
        private System.Windows.Forms.ContextMenu ItemListContextMenu;
        private System.Windows.Forms.TextBox ItemFilterTextBox;
        private System.Windows.Forms.MenuItem NewActionMenuItem;
        private System.Windows.Forms.Label StatusTextLabel;
        private System.Windows.Forms.PictureBox StatusPictureBox;
        private System.Windows.Forms.Label ActionLogFilterLabel;
        private System.Windows.Forms.MenuItem UndoLastActionMenuItem;
        private System.Windows.Forms.MenuItem DeleteItemMenuItem;
        private System.Windows.Forms.MenuItem ListActionLogsOfItemMenuItem;
        private System.Windows.Forms.LinkLabel OpenSettingsLinkLabel;
        private System.Windows.Forms.LinkLabel ReturnToRestorePointLinkLabel;
    }
}

