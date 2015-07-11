using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public static class ReflectionExtensions
{
    public static T GetCustomAttribute<T>(this MemberInfo memberInfo)
        where T : Attribute
    {
        var attributes = memberInfo.GetCustomAttributes(typeof(T), true);
        if (attributes.Length > 0)
        {
            return (T)attributes[0];
        }
        else
        {
            return null;
        }
    }

    public static T GetCustomAttribute<T>(this Assembly assembly)
        where T : Attribute
    {
        var attributes = assembly.GetCustomAttributes(typeof(T), true);
        if (attributes.Length > 0)
        {
            return (T)attributes[0];
        }
        else
        {
            return null;
        }
    }
}
