using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Configuration
{
    public class FileConfigurationManager : IConfigurationManager
    {
        public string GetString(string configurationName)
        {
            return ConfigurationManager.AppSettings[configurationName];
        }

        public T GetTypedValue<T>(string configurationName)
        {
            string stringValue = GetString(configurationName);
            return (T)Convert.ChangeType(stringValue, typeof(T));
        }
    }
}
