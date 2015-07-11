using StokTakip.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.Entities
{
    public class ReportData
    {
        public ChartType ChartType { get; set; }
        public TypeCode XAxisValueType { get; set; }
        public List<ReportSerie> Series { get; set; }
    }
}
