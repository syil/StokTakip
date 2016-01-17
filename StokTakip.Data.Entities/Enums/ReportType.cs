using CommonLibrary.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.Entities.Enums
{
    public enum ReportType
    {
        [StringValue("Değişim Grafiği")]
        DifferenceOverTime,
        [StringValue("Öğelerin Dağılımı Grafiği")]
        PercentageOfItems
    }
}
