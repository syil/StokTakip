using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Core.Attributes;
using System.Drawing;

namespace StokTakip.Core
{
    public enum MessageType : short
    {
        [ForeColor(KnownColor.Gray)]
        Wait = 1,
        [ForeColor(KnownColor.SeaGreen)]
        Success = 2,
        [ForeColor(KnownColor.RoyalBlue)]
        Information = 3,
        [ForeColor(KnownColor.Orange)]
        Warning = 4,
        [ForeColor(KnownColor.Crimson)]
        Error = 5
    }
}
