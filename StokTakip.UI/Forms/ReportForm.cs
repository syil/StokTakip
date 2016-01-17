using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StokTakip.Core.Views;
using StokTakip.Data.Entities.Enums;
using StokTakip.Data.Entities;
using Charting = System.Windows.Forms.DataVisualization.Charting;
using StokTakip.Core.Presenters;
using StokTakip.UI.Helpers;
using CommonLibrary.Extensions;

namespace StokTakip.UI.Forms
{
    public partial class ReportForm : Form, IReportView
    {
        protected static readonly Size DefaultIconSize = new Size(24, 24);

        protected ReportPresenter presenter;

        public ReportForm()
        {
            this.presenter = new ReportPresenter(this);

            InitializeComponent();
            InitializeReportTypesMenu();
        }

        protected void InitializeReportTypesMenu()
        {
            this.TypesFlowLayoutPanel.SuspendLayout();

            var reportTypes = Enum.GetValues(typeof(ReportType)).Cast<ReportType>();
            RadioButton reportTypeRadioButton;

            foreach (var reportType in reportTypes)
            {
                reportTypeRadioButton = new RadioButton
                {
                    Anchor = AnchorStyles.None,
                    Appearance = Appearance.Button,
                    Size = new Size(170, 30),
                    TabIndex = 0,
                    TabStop = true,
                    Text = reportType.GetStringValue(),
                    UseVisualStyleBackColor = true,
                    Checked = false,
                    Tag = reportType
                };
                reportTypeRadioButton.Click += ReportTypeRadioButton_Click;

                this.TypesFlowLayoutPanel.Controls.Add(reportTypeRadioButton);
            }

            this.TypesFlowLayoutPanel.ResumeLayout();
        }

        #region IReportView Members
        public ReportType? SelectedReportType
        {
            get
            {
                var selectedRadioButton = this.TypesFlowLayoutPanel.Controls.Cast<RadioButton>().Where(c => c.Checked).SingleOrDefault();
                if (selectedRadioButton != null)
                    return selectedRadioButton.Tag as ReportType?;
                else
                    return null;
            }
        }

        public void SetReportData(ReportData data)
        {
            this.ReportingChart.Series.Clear();

            if (data != null)
            {
                foreach (var serie in data.Series)
                {
                    Charting.Series chartSerie = new Charting.Series
                    {
                        Name = serie.Name,
                        ChartType = data.ChartType.ToNameEquivalent<Charting.SeriesChartType>(),
                        XValueType = data.XAxisValueType.ToNameEquivalent<Charting.ChartValueType>(),
                        IsXValueIndexed = true
                    };

                    chartSerie.Points.DataBind(serie.Data, "Label", "Value", "Tooltip=Value");

                    this.ReportingChart.Series.Add(chartSerie);
                }
            }
        }

        public void ShowMessage(string message, string group, Core.MessageType type)
        {
            this.StatusTextLabel.Text = message;
            this.StatusPictureBox.Image = ImageHelper.GetSolidImage(type.GetColor(), DefaultIconSize);
        } 

        #endregion

        private void ReportTypeRadioButton_Click(object sender, EventArgs e)
        {
            this.presenter.RefreshReportData();
        }

        private void SaveAsPictureLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.ChartImageSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.ReportingChart.SaveImage(this.ChartImageSaveFileDialog.FileName, Charting.ChartImageFormat.Png);
            }
        }
    }
}
