using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonLibrary.Attributes;

namespace StokTakip.Data.Entities.Enums
{
    public enum ActionType : short
    {
        [StringValue("Artış")]
        Increase = 1,
        [StringValue("Azalış")]
        Decrease = 2
    }
}
