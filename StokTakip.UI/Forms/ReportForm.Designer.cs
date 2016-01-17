namespace StokTakip.UI.Forms
{
    partial class ReportForm
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
            System.Windows.Forms.Panel FooterPanel;
            System.Windows.Forms.Panel HeaderPanel;
            System.Windows.Forms.Label HeaderTextLabel;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.StatusTextLabel = new System.Windows.Forms.Label();
            this.StatusPictureBox = new System.Windows.Forms.PictureBox();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.TypesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveAsPictureLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ReportingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartImageSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            FooterPanel = new System.Windows.Forms.Panel();
            HeaderPanel = new System.Windows.Forms.Panel();
            HeaderTextLabel = new System.Windows.Forms.Label();
            FooterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).BeginInit();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportingChart)).BeginInit();
            this.SuspendLayout();
            // 
            // FooterPanel
            // 
            FooterPanel.Controls.Add(this.StatusTextLabel);
            FooterPanel.Controls.Add(this.StatusPictureBox);
            FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            FooterPanel.Location = new System.Drawing.Point(0, 470);
            FooterPanel.Name = "FooterPanel";
            FooterPanel.Size = new System.Drawing.Size(745, 24);
            FooterPanel.TabIndex = 4;
            // 
            // StatusTextLabel
            // 
            this.StatusTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusTextLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusTextLabel.Location = new System.Drawing.Point(24, 0);
            this.StatusTextLabel.Name = "StatusTextLabel";
            this.StatusTextLabel.Size = new System.Drawing.Size(721, 24);
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
            // HeaderPanel
            // 
            HeaderPanel.BackColor = System.Drawing.Color.Silver;
            HeaderPanel.Controls.Add(HeaderTextLabel);
            HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            HeaderPanel.Location = new System.Drawing.Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new System.Drawing.Size(745, 60);
            HeaderPanel.TabIndex = 5;
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
            HeaderTextLabel.Text = "Raporlar && Grafikler";
            HeaderTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainSplitContainer.IsSplitterFixed = true;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 60);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.TypesFlowLayoutPanel);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.SaveAsPictureLinkLabel);
            this.MainSplitContainer.Panel2.Controls.Add(this.ReportingChart);
            this.MainSplitContainer.Size = new System.Drawing.Size(745, 410);
            this.MainSplitContainer.SplitterDistance = 175;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // TypesFlowLayoutPanel
            // 
            this.TypesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypesFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TypesFlowLayoutPanel.Name = "TypesFlowLayoutPanel";
            this.TypesFlowLayoutPanel.Size = new System.Drawing.Size(175, 410);
            this.TypesFlowLayoutPanel.TabIndex = 0;
            // 
            // SaveAsPictureLinkLabel
            // 
            this.SaveAsPictureLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.SaveAsPictureLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveAsPictureLinkLabel.AutoSize = true;
            this.SaveAsPictureLinkLabel.BackColor = System.Drawing.Color.White;
            this.SaveAsPictureLinkLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SaveAsPictureLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.SaveAsPictureLinkLabel.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.SaveAsPictureLinkLabel.Location = new System.Drawing.Point(422, 390);
            this.SaveAsPictureLinkLabel.Name = "SaveAsPictureLinkLabel";
            this.SaveAsPictureLinkLabel.Size = new System.Drawing.Size(141, 17);
            this.SaveAsPictureLinkLabel.TabIndex = 1;
            this.SaveAsPictureLinkLabel.TabStop = true;
            this.SaveAsPictureLinkLabel.Text = "Resim Olarak Kaydet";
            this.SaveAsPictureLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveAsPictureLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SaveAsPictureLinkLabel_LinkClicked);
            // 
            // ReportingChart
            // 
            chartArea1.Name = "MainChartArea";
            this.ReportingChart.ChartAreas.Add(chartArea1);
            this.ReportingChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Öğeler";
            this.ReportingChart.Legends.Add(legend1);
            this.ReportingChart.Location = new System.Drawing.Point(0, 0);
            this.ReportingChart.Name = "ReportingChart";
            this.ReportingChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.ReportingChart.Size = new System.Drawing.Size(566, 410);
            this.ReportingChart.TabIndex = 0;
            this.ReportingChart.Text = "ReportingChart";
            // 
            // ChartImageSaveFileDialog
            // 
            this.ChartImageSaveFileDialog.DefaultExt = "png";
            this.ChartImageSaveFileDialog.FileName = "Grafik1";
            this.ChartImageSaveFileDialog.Filter = "Taşınabilir Ağ Grafiği(*.png)|*.png";
            this.ChartImageSaveFileDialog.Title = "Resmin kaydedileceği yeri belirtin";
            // 
            // ReportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(745, 494);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(FooterPanel);
            this.Controls.Add(HeaderPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "ReportForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Raporlar & Grafikler";
            FooterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StatusPictureBox)).EndInit();
            HeaderPanel.ResumeLayout(false);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            this.MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReportingChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.FlowLayoutPanel TypesFlowLayoutPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart ReportingChart;
        private System.Windows.Forms.Label StatusTextLabel;
        private System.Windows.Forms.PictureBox StatusPictureBox;
        private System.Windows.Forms.LinkLabel SaveAsPictureLinkLabel;
        private System.Windows.Forms.SaveFileDialog ChartImageSaveFileDialog;


    }
}