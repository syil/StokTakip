using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary.Configuration;

namespace StokTakip.Data.EF
{
    internal class InternalConfiguration : ConfigurationManagerBase
    {
        private static readonly string ConnectionStringTemplate = "metadata=res://*/Model.StokModel.csdl|res://*/Model.StokModel.ssdl|res://*/Model.StokModel.msl;provider={0};provider connection string=\"{1}\"";

        private static InternalConfiguration instance;

        public static InternalConfiguration Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InternalConfiguration();
                }

                return instance;
            }
        }

        protected InternalConfiguration()
        {

        }

        public string DataSource
        {
            get
            {
                return GetString("StokTakip.Data.EF.DataSource");
            }
        }

        public string Provider
        {
            get
            {
                return GetString("StokTakip.Data.EF.Provider");
            }
        }

        public string ConnectionString
        {
            get
            {
                return GetString("StokTakip.Data.EF.ConnectionString");
            }
        }

        public string GetProviderConnectionString()
        {
            string dataSource = Environment.ExpandEnvironmentVariables(DataSource);
            return ConnectionString.Replace("{DataSource}", dataSource);
        }

        public string GetEntityFrameworkConnectionString()
        {
            string providerConnectionString = GetProviderConnectionString();
            string actualConnectionString = string.Format(ConnectionStringTemplate, Provider, providerConnectionString);

            return actualConnectionString;
        }
    }
}
