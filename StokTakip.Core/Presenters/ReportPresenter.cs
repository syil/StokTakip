using StokTakip.Core.Views;
using StokTakip.Data.Entities;
using StokTakip.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Core.Presenters
{
    public class ReportPresenter : DataPresenterBase<IReportView>
    {
        public ReportPresenter(IReportView view)
            : base(view)
        {

        }

        public void RefreshReportData()
        {
            try
            {
                ReportData reportData = null;

                switch (this.view.SelectedReportType)
                {
                    case ReportType.DifferenceOverTime:
                        {
                            var actions = this.repositoryContainer.Action.GetList();
                            var seriesData = (from a in actions
                                              group a by a.Item.Name into ia
                                              select new ReportSerie
                                              {
                                                  Name = ia.Key,
                                                  Data = ia.GroupBy(ad => ad.ActionDate.Date).Select(ad => new ReportSerieData(ad.Key, ad.Last().NewQuantity)).ToList()
                                              }).ToList();

                            // Öğelerin birinin miktarı değişip diğerlerinin değişmediği durumlarda, grafiğin devamlılığını sağlamak için boşluklar dolduruluyor
                            var labels = seriesData.SelectMany(s => s.Data.Select(d => d.Label)).OrderBy(l => l);
                            Dictionary<string, int> previousValues = new Dictionary<string, int>();

                            foreach (var serie in seriesData)
                            {
                                if (!previousValues.ContainsKey(serie.Name))
                                    previousValues.Add(serie.Name, 0);

                                foreach (DateTime label in labels)
                                {
                                    var point = serie.Data.Where(d => d.Label.Equals(label)).SingleOrDefault();
                                    if (point == null)
                                        serie.Data.Add(new ReportSerieData(label, previousValues[serie.Name]));
                                    else
                                        previousValues[serie.Name] = (int)point.Value;
                                }
                                
                                serie.Data = serie.Data.OrderBy(d => d.Label).ToList();
                            }

                            reportData = new ReportData
                            {
                                ChartType = ChartType.Area,
                                XAxisValueType = TypeCode.DateTime,
                                Series = seriesData
                            };
                        }
                        break;
                    case ReportType.PercentageOfItems:
                        {
                            var items = this.repositoryContainer.Item.GetList();
                            var seriesData = new List<ReportSerie>() {
                                                new ReportSerie
                                                {
                                                    Name = "Quantities",
                                                    Data = items.Select(i => new ReportSerieData(i.Name, i.Quantity)).ToList()
                                                }
                            };

                            reportData = new ReportData
                            {
                                ChartType = ChartType.Pie,
                                XAxisValueType = TypeCode.Int32,
                                Series = seriesData
                            };
                        }
                        break;
                    default:
                        {
                            this.view.ShowMessage("Rapor tipi seçilmemiş veya tanımlanmamış", "RefreshReportData", MessageType.Warning);
                        }
                        break;
                }

                this.view.SetReportData(reportData);
                this.view.ShowMessage("Rapor verisi alındı", "RefreshReportData", MessageType.Success);
            }
            catch (Exception ex)
            {
                this.logger.Error(ex);

                this.view.ShowMessage("Rapor verisi alınamadı", "RefreshReportData", MessageType.Error);
            }
        }
    }
}
