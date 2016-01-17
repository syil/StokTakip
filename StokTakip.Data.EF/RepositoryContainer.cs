using CommonLibrary.Utilities;
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
using Entities = StokTakip.Data.Entities;
using AutoMapper;

namespace StokTakip.Data.EF
{
    public class RepositoryContainer : IRepositoryContainer
    {
        private static readonly Logger logger = new Logger();

        private ItemRepository itemRepository;
        private ActionRepository actionRepository;
        private ExpenseRepository expenseRepository;
        private StokContext entityContext;

        public RepositoryContainer()
        {
            entityContext = new StokContext(InternalConfiguration.Instance.GetEntityFrameworkConnectionString());
            entityContext.Database.Log = msg => logger.Debug("EF Debug: {0}", msg);

            this.itemRepository = new ItemRepository(entityContext);
            this.actionRepository = new ActionRepository(entityContext);
            this.expenseRepository = new ExpenseRepository(entityContext);

            Mapper.CreateMap<Item, Entities.Item>().ReverseMap().IgnoreAllPropertiesWithAnInaccessibleSetter();
            Mapper.CreateMap<ActionLog, Entities.ActionLog>().ReverseMap().IgnoreAllPropertiesWithAnInaccessibleSetter();
            Mapper.CreateMap<ItemProperty, Entities.ItemProperty>().ReverseMap().IgnoreAllPropertiesWithAnInaccessibleSetter();
            Mapper.CreateMap<Expense, Entities.Expense>().ReverseMap().IgnoreAllPropertiesWithAnInaccessibleSetter();
        }

        public IItemRepository Item
        {
            get { return itemRepository; }
        }

        public IActionRepository Action
        {
            get { return actionRepository; }
        }

        public IExpenseRepository Expense
        {
            get { return expenseRepository; }
        }

        public void RunTransactionalWork(Action work)
        {
            if (entityContext.Database.Connection.State == ConnectionState.Closed)
            {
                entityContext.Database.Connection.Open();
            }

            using (var transaction = entityContext.Database.BeginTransaction())
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
    }
}
