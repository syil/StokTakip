namespace StokTakip.UI.Controls
{
    partial class ActionLogListControl
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
            System.Windows.Forms.ColumnHeader ActionItemNameColumn;
            System.Windows.Forms.ColumnHeader ActionDateColumn;
            System.Windows.Forms.ColumnHeader OldQuantityColumn;
            System.Windows.Forms.ColumnHeader NewQuantityColumn;
            System.Windows.Forms.ColumnHeader DifferenceColumn;
            System.Windows.Forms.ColumnHeader DescriptionColumn;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionLogListControl));
            this.ActionLogFilterLabel = new System.Windows.Forms.Label();
            this.ActionLogListView = new System.Windows.Forms.ListView();
            this.ActionLogSmallImageList = new System.Windows.Forms.ImageList(this.components);
            ActionItemNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ActionDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            OldQuantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            NewQuantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            DifferenceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            DescriptionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ActionLogFilterLabel
            // 
            this.ActionLogFilterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionLogFilterLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ActionLogFilterLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ActionLogFilterLabel.ForeColor = System.Drawing.Color.White;
            this.ActionLogFilterLabel.Location = new System.Drawing.Point(284, 10);
            this.ActionLogFilterLabel.Name = "ActionLogFilterLabel";
            this.ActionLogFilterLabel.Size = new System.Drawing.Size(532, 13);
            this.ActionLogFilterLabel.TabIndex = 8;
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
            this.ActionLogListView.Size = new System.Drawing.Size(819, 380);
            this.ActionLogListView.SmallImageList = this.ActionLogSmallImageList;
            this.ActionLogListView.TabIndex = 6;
            this.ActionLogListView.UseCompatibleStateImageBehavior = false;
            this.ActionLogListView.View = System.Windows.Forms.View.Details;
            // 
            // ActionItemNameColumn
            // 
            ActionItemNameColumn.Text = "Öğe Adı";
            ActionItemNameColumn.Width = 158;
            // 
            // ActionDateColumn
            // 
            ActionDateColumn.Text = "Zaman";
            ActionDateColumn.Width = 97;
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
            // label2
            // 
            label2.BackColor = System.Drawing.Color.DimGray;
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(819, 33);
            label2.TabIndex = 7;
            label2.Text = "Olay Listesi";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ActionLogSmallImageList
            // 
            this.ActionLogSmallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ActionLogSmallImageList.ImageStream")));
            this.ActionLogSmallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ActionLogSmallImageList.Images.SetKeyName(0, "Blank");
            this.ActionLogSmallImageList.Images.SetKeyName(1, "Ascending");
            this.ActionLogSmallImageList.Images.SetKeyName(2, "Descending");
            // 
            // ActionLogListControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.ActionLogFilterLabel);
            this.Controls.Add(this.ActionLogListView);
            this.Controls.Add(label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "ActionLogListControl";
            this.Size = new System.Drawing.Size(819, 413);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ActionLogFilterLabel;
        private System.Windows.Forms.ListView ActionLogListView;
        private System.Windows.Forms.ImageList ActionLogSmallImageList;
    }
}
