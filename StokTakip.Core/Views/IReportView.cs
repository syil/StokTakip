using StokTakip.Data.Entities;
using StokTakip.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StokTakip.Core.Views
{
    public interface IReportView : IView
    {
        ReportType? SelectedReportType { get; }
        void SetReportData(ReportData data);
    }
}
