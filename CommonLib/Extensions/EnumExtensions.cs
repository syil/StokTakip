using CommonLib.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

public static class EnumExtensions
{
    public static T ToNameEquivalent<T>(this Enum source)
    {
        string sourceString = source.ToString();

        return (T)Enum.Parse(typeof(T), sourceString);
    }

    public static string GetStringValue(this Enum enumValue)
    {
        FieldInfo fi = enumValue.GetType().GetField(enumValue.ToString());

        if (fi != null)
        {
            var stringValueAttribute = fi.GetCustomAttribute<StringValueAttribute>();
            if (stringValueAttribute != null)
            {
                return stringValueAttribute.StringValue;
            }
            else
            {
                return enumValue.ToString();
            }
        }
        else
        {
            return string.Empty;
        }
    }
}
