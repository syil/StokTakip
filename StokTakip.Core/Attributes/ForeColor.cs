using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace StokTakip.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public sealed class ForeColorAttribute : Attribute
    {
        private KnownColor foreColor;

        public Color Color
        {
            get
            {
                return Color.FromKnownColor(foreColor);
            }
        }

        public ForeColorAttribute(KnownColor foreColor)
        {
            this.foreColor = foreColor;
        }
    }
}
