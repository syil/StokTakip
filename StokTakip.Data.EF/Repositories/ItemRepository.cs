using StokTakip.Data.Base.Repositories;
using StokTakip.Data.EF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLibrary.Utilities;
using AutoMapper;

namespace StokTakip.Data.EF.Repositories
{
    public class ItemRepository : RepositoryBase, IItemRepository
    {
        private static readonly Logger logger = new Logger();

        public ItemRepository(StokContext context)
            : base(context)
        {

        }

        public IEnumerable<Entities.Item> SearchByName(string filterText)
        {
            if (!string.IsNullOrWhiteSpace(filterText))
            {
                try
                {
                    var entities = context.Items.Include(i => i.ActionLogs).Where(i => i.Name.Contains(filterText)).ToList();
                    return Mapper.Map<List<Entities.Item>>(entities);
                }
                catch (Exception ex)
                {
                    base.RaiseException(ex);
                    return null;
                } 
            }
            else
            {
                return GetList();
            }
        }

        public void AddOrUpdateProperty(Entities.Item item, Entities.ItemProperty property)
        {
            try
            {
                var model = context.ItemProperties.Where(p => p.Key == property.Key && p.ItemId == item.Id).FirstOrDefault();
                
                if (model != null)
                {
                    model.Value = property.Value;
                }
                else
                {
                    model = Mapper.Map<ItemProperty>(property);
                    model.ItemId = item.Id;

                    context.ItemProperties.Add(model);
                }

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
            }
        }

        public IEnumerable<Entities.ItemProperty> GetProperties(Entities.Item item)
        {
            try
            {
                var entities = context.ItemProperties.Where(p => p.ItemId == item.Id).ToList();
                return Mapper.Map<List<Entities.ItemProperty>>(entities);
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
                return null;
            }
        }

        public void DeleteProperty(Entities.Item item, string key)
        {
            try
            {
                var model = context.ItemProperties.Where(p => p.Key == key && p.ItemId == item.Id).FirstOrDefault();

                if (model != null)
                {
                    context.ItemProperties.Remove(model);
                    context.SaveChanges();
                }
                else
                {
                    throw new ApplicationException(string.Format("The item property [Key: {0}] cannot be found for this item [ID: {1}]", key, item.Id));
                }
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
            }
        }

        public void AddNew(Entities.Item entity)
        {
            try
            {
                var model = Mapper.Map<Item>(entity);

                context.Items.Add(model);

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
            }
        }

        public Entities.Item Get(object key)
        {
            try
            {
                var itemId = (int)key;
                var model = context.Items.Where(i => i.Id == itemId).FirstOrDefault();

                return Mapper.Map<Entities.Item>(model);
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
                return null;
            }
        }

        public IEnumerable<Entities.Item> GetList()
        {
            try
            {
                var entities = context.Items.Include(i => i.ActionLogs).ToList();

                return Mapper.Map<List<Entities.Item>>(entities);
            }
            catch (Exception ex)
            {
                base.RaiseException(ex);
                return null;
            }
        }

        //public Entities.Item[] GetList(Predicate<Entities.Item> filter)
        //{
        //    try
        //    {
        //        var models = context.Items.Where(i => filter(ItemMapper.ToEntity(i)));

        //        var entities = models.Select(i => ItemMapper.ToEntity(i));

        //        return entities.ToArray();
        //    }
        //    catch (Exception ex)
        //    {
        //        base.RaiseException(ex);
        //        return null;
        //    }
        //}

        public void Delete(Entities.Item entity)
        {
            try
            {
                var model = context.Items.Where(i => i.Id == entity.Id).FirstOrDefault();

                if (model != null)
                {
                    context.Items.Remove(model);
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

        public void Update(Entities.Item entity)
        {
            try
            {
                var model = context.Items.SingleOrDefault(i => i.Id == entity.Id);

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
