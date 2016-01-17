using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using StokTakip.Data.Base.Repositories;
using StokTakip.Data.EF.Model;
using StokTakip.Data.Entities;

namespace StokTakip.Data.EF.Repositories
{
    public class ExpenseRepository : RepositoryBase, IExpenseRepository
    {
        public ExpenseRepository(StokContext context)
            : base(context)
        {

        }

        public void AddNew(Entities.Expense entity)
        {
            try
            {
                var model = Mapper.Map<Model.Expense>(entity);

                context.Expenses.Add(model);

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
            }
        }

        public void Delete(Entities.Expense entity)
        {
            try
            {
                var model = context.Expenses.Where(i => i.Id == entity.Id).FirstOrDefault();

                if (model != null)
                {
                    model.Status = ExpenseStatus.Deleted;

                    context.SaveChanges();
                }
                else
                {
                    throw new ApplicationException(string.Format("The expense [ID: {0}] cannot be found", entity.Id));
                }
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
            }
        }

        public Entities.Expense Get(object key)
        {
            try
            {
                var expenseId = (int)key;
                var model = context.Expenses.Where(i => i.Id == expenseId).FirstOrDefault();

                return Mapper.Map<Entities.Expense>(model);
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
                return null;
            }
        }

        public IEnumerable<string> GetCategories()
        {
            try
            {
                var entities = context.Expenses.Select(e => e.Category).Distinct().ToList();

                if (!entities.Contains("Diğer"))
                {
                    entities.Add("Diğer");
                }

                return entities;
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
                return null;
            }
        }

        public IEnumerable<Entities.Expense> GetList()
        {
            try
            {
                var entities = context.Expenses.Where(e => e.Status == ExpenseStatus.Active).ToList();

                return Mapper.Map<List<Entities.Expense>>(entities);
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
                return null;
            }
        }

        public IEnumerable<Entities.Expense> GetList(string category, DateTime startDate, DateTime endDate)
        {
            try
            {
                var entities = context.Expenses.Where(e => e.Status == ExpenseStatus.Active && e.ExpenseDate > startDate && e.ExpenseDate < endDate);

                if (!string.IsNullOrWhiteSpace(category))
                {
                    entities = entities.Where(e => e.Category == category);
                }

                return Mapper.Map<List<Entities.Expense>>(entities.ToList());
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
                return null;
            }
        }

        public void Update(Entities.Expense entity)
        {
            try
            {
                var model = context.Expenses.Where(i => i.Id == entity.Id).FirstOrDefault();

                if (model != null)
                {
                    model = Mapper.Map(entity, model);

                    context.SaveChanges();
                }
                else
                {
                    throw new ApplicationException(string.Format("The item [ID: {0}] cannot be found", entity.Id));
                }
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
            }
        }
    }
}
