using StokTakip.Core;
using StokTakip.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class MessageTypeExtensions
{
    public static Color GetColor(this MessageType type)
    {
        var fieldInfo = type.GetType().GetField(type.ToString());

        if (fieldInfo != null)
        {
            var stringValueAttribute = fieldInfo.GetCustomAttribute<ForeColorAttribute>();
            if (stringValueAttribute != null)
            {
                return stringValueAttribute.Color;
            }
        }

        return default(Color);
    }
}