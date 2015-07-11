using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.Entities
{
    public class ReportSerieData
    {
        public ReportSerieData(object label, object value)
        {
            this.Label = label;
            this.Value = value;
        }

        public object Label { get; set; }
        public object Value { get; set; }
    }
}
