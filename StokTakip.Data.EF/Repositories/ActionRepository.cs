using StokTakip.Data.Base.Repositories;
using StokTakip.Data.EF.Mappers;
using StokTakip.Data.EF.Model;
using StokTakip.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.EF.Repositories
{
    public class ActionRepository : RepositoryBase, IActionRepository
    {
        public ActionRepository(StokContext context)
            : base(context)
        {

        }

        public IEnumerable<Entities.ActionLog> GetItemActions(Entities.Item item)
        {
            try
            {
                var models = context.ActionLogs.Where(a => a.ItemId == item.Id);
                var entities = models.ToList().Select(a => ActionLogMapper.Instance.ToEntity(a));

                return entities;
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
                return null;
            } 
        }

        public void AddNew(Entities.ActionLog entity)
        {
            try
            {
                var model = new Model.ActionLog();
                ActionLogMapper.Instance.FromEntity(entity, model);

                context.AddToActionLogs(model);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                base.RaiseException(ex, entity);
            }
        }

        public Entities.ActionLog Get(object key)
        {
            try
            {
                var logId = (int)key;
                var model = context.ActionLogs.Where(a => a.Id == logId).FirstOrDefault();

                if (model != null)
                {
                    var entity = new Entities.ActionLog();
                    ActionLogMapper.Instance.ToEntity(model, entity);

                    return entity;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
                return null;
            }
        }

        public IEnumerable<Entities.ActionLog> GetList()
        {
            try
            {
                var models = context.ActionLogs;

                var entities = models.Select(a => a);

                return entities.ToList().Select(a => ActionLogMapper.Instance.ToEntity(a));
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
                return null;
            }
        }

        //public Entities.ActionLog[] GetList(Predicate<Entities.ActionLog> filter)
        //{
        //    try
        //    {
        //        var models = context.ActionLogs.Where(a => filter(ActionLogMapper.ToEntity(a)));

        //        var entities = models.Select(a => ActionLogMapper.ToEntity(a));

        //        return entities.ToArray();
        //    }
        //    catch (Exception ex)
        //    {
        //        base.RaiseException(ex);
        //        return null;
        //    }
        //}

        public void Delete(Entities.ActionLog entity)
        {
            try
            {
                var model = context.ActionLogs.Where(a => a.Id == entity.Id).FirstOrDefault();

                if (model != null)
                {
                    context.DeleteObject(model);
                    context.SaveChanges();
                }
                else
                {
                    throw new ApplicationException(string.Format("The action log [ID: {0}] cannot be found", entity.Id));
                }
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
            }
        }

        public void DeleteItemActions(Entities.Item item)
        {
            try
            {
                var logs = context.ActionLogs.Where(a => a.ItemId == item.Id);

                foreach(var log in logs)
                {
                    context.DeleteObject(log);
                }
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
            }
        }

        public void Update(Entities.ActionLog entity)
        {
            try
            {
                var model = context.ActionLogs.Where(a => a.Id == entity.Id).FirstOrDefault();

                if (model != null)
                {
                    ActionLogMapper.Instance.FromEntity(entity, model);

                    context.SaveChanges();
                }
                else
                {
                    throw new ApplicationException(string.Format("The action log [ID: {0}] cannot be found", entity.Id));
                }
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
            }
        }

        public void UndoLastItemAction(Entities.Item item)
        {
            try
            {
                var lastActionLog = context.ActionLogs.Where(a => a.ItemId == item.Id).OrderByDescending(a => a.ActionDate).FirstOrDefault();

                if (lastActionLog != null)
                {
                    lastActionLog.Item.Quantity = lastActionLog.OldQuantity;
                    context.DeleteObject(lastActionLog);

                    context.SaveChanges();
                }
                else
                {
                    throw new ApplicationException(string.Format("The last action log for the item [ID: {0}] cannot be found", item.Id));
                }
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
            }
        }
    }
}
