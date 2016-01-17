namespace StokTakip.UI.Controls
{
    partial class ItemListControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader NameColumn;
            System.Windows.Forms.ColumnHeader QuantityColumn;
            System.Windows.Forms.ColumnHeader InsertDateColumn;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.MenuItem Seperator1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemListControl));
            this.ItemListView = new System.Windows.Forms.ListView();
            this.ItemFilterTextBox = new System.Windows.Forms.TextBox();
            this.ItemListContextMenu = new System.Windows.Forms.ContextMenu();
            this.NewActionMenuItem = new System.Windows.Forms.MenuItem();
            this.ListActionLogsOfItemMenuItem = new System.Windows.Forms.MenuItem();
            this.UndoLastActionMenuItem = new System.Windows.Forms.MenuItem();
            this.DeleteItemMenuItem = new System.Windows.Forms.MenuItem();
            this.ItemListLargeImageList = new System.Windows.Forms.ImageList(this.components);
            NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            QuantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            InsertDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            label1 = new System.Windows.Forms.Label();
            Seperator1 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
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
            this.ItemListView.Size = new System.Drawing.Size(807, 330);
            this.ItemListView.TabIndex = 3;
            this.ItemListView.TileSize = new System.Drawing.Size(250, 60);
            this.ItemListView.UseCompatibleStateImageBehavior = false;
            this.ItemListView.View = System.Windows.Forms.View.Tile;
            this.ItemListView.DoubleClick += new System.EventHandler(this.ItemListView_DoubleClick);
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
            // label1
            // 
            label1.BackColor = System.Drawing.Color.DimGray;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(807, 33);
            label1.TabIndex = 4;
            label1.Text = "Öğe Listesi";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemFilterTextBox
            // 
            this.ItemFilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemFilterTextBox.Location = new System.Drawing.Point(603, 6);
            this.ItemFilterTextBox.Name = "ItemFilterTextBox";
            this.ItemFilterTextBox.Size = new System.Drawing.Size(200, 23);
            this.ItemFilterTextBox.TabIndex = 5;
            this.ItemFilterTextBox.TextChanged += new System.EventHandler(this.ItemFilterTextBox_TextChanged);
            this.ItemFilterTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ItemFilterTextBox_KeyUp);
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
            // ItemListLargeImageList
            // 
            this.ItemListLargeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ItemListLargeImageList.ImageStream")));
            this.ItemListLargeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ItemListLargeImageList.Images.SetKeyName(0, "Blank");
            // 
            // ItemListControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.ItemFilterTextBox);
            this.Controls.Add(this.ItemListView);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "ItemListControl";
            this.Size = new System.Drawing.Size(807, 363);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ItemListView;
        private System.Windows.Forms.TextBox ItemFilterTextBox;
        private System.Windows.Forms.ContextMenu ItemListContextMenu;
        private System.Windows.Forms.MenuItem NewActionMenuItem;
        private System.Windows.Forms.MenuItem ListActionLogsOfItemMenuItem;
        private System.Windows.Forms.MenuItem UndoLastActionMenuItem;
        private System.Windows.Forms.MenuItem DeleteItemMenuItem;
        private System.Windows.Forms.ImageList ItemListLargeImageList;
    }
}
