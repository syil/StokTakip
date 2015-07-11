using CommonLib;
using StokTakip.Data.Base;
using StokTakip.Data.Base.Repositories;
using StokTakip.Data.EF.Model;
using StokTakip.Data.EF.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace StokTakip.Data.EF
{
    public class RepositoryContainer : IRepositoryContainer
    {
        private static readonly string ConnectionStringTemplate = "metadata=res://*/Model.StokModel.csdl|res://*/Model.StokModel.ssdl|res://*/Model.StokModel.msl;provider={0};provider connection string=\"{1}\"";
        private static readonly Logger logger = new Logger(typeof(RepositoryContainer));

        private ItemRepository itemRepository;
        private ActionRepository actionRepository;
        private StokContext entityContext;

        public string DataSource
        {
            get
            {
                return ConfigurationManager.AppSettings.Get("StokTakip.Data.EF.DataSource");
            }
        }

        public string Provider
        {
            get
            {
                return ConfigurationManager.AppSettings.Get("StokTakip.Data.EF.Provider");
            }
        }

        public string ConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings.Get("StokTakip.Data.EF.ConnectionString");
            }
        }


        public RepositoryContainer()
        {
            PrepareDatabase();
            entityContext = new StokContext(GenerateConnectionString());

            this.itemRepository = new ItemRepository(entityContext);
            this.actionRepository = new ActionRepository(entityContext);
        }

        public IItemRepository Item
        {
            get { return itemRepository; }
        }

        public IActionRepository Action
        {
            get { return actionRepository; }
        }

        public void RunTransactionalWork(Action work)
        {
            if (entityContext.Connection.State == ConnectionState.Closed)
            {
                entityContext.Connection.Open();
            }

            using (var transaction = entityContext.Connection.BeginTransaction())
            {
                try
                {
                    work();

                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        private string GenerateConnectionString()
        {
            string dataSource = Environment.ExpandEnvironmentVariables(DataSource);
            string providerConnectionString = ConnectionString.Replace("{DataSource}", dataSource);
            string actualConnectionString = string.Format(ConnectionStringTemplate, Provider, providerConnectionString);

            return actualConnectionString;
        }

        private void PrepareDatabase()
        {
            
        }
    }
}
