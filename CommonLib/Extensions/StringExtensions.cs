using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class StringExtensions
{
    public static int ToInt32(this string str, int defaultValue = default(int))
    {
        int i = defaultValue;
        int.TryParse(str, out i);

        return i;
    }
}