using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Configuration
{
    public interface IConfigurationManager
    {
        string GetString(string configurationName);
        T GetTypedValue<T>(string configurationName);
    }
}
