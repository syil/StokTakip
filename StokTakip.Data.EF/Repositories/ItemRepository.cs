using StokTakip.Data.Base.Repositories;
using StokTakip.Data.EF.Mappers;
using StokTakip.Data.EF.Model;
using StokTakip.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.EF.Repositories
{
    public class ItemRepository : RepositoryBase, IItemRepository
    {
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
                    return context.Items.Where(i => i.Name.Contains(filterText)).ToList().Select(i => ItemMapper.Instance.ToEntity(i));
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
                    ItemPropertyMapper.Instance.FromEntity(property, model);
                }
                else
                {
                    model = new Model.ItemProperty();
                    ItemPropertyMapper.Instance.FromEntity(property, model);
                    model.ItemId = item.Id;

                    context.ItemProperties.AddObject(model);
                    context.SaveChanges();
                }
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
                return context.ItemProperties.Where(p => p.ItemId == item.Id).Select(p => ItemPropertyMapper.Instance.ToEntity(p)).ToArray();
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
                    context.DeleteObject(model);
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
                var model = new Model.Item();
                ItemMapper.Instance.FromEntity(entity, model);

                context.AddToItems(model);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                base.RaiseException(ex, entity);
            }
        }

        public Entities.Item Get(object key)
        {
            try
            {
                var itemId = (int)key;
                var model = context.Items.Where(i => i.Id == itemId).FirstOrDefault();

                if (model != null)
                {
                    var entity = new Entities.Item();
                    ItemMapper.Instance.ToEntity(model, entity);

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

        public IEnumerable<Entities.Item> GetList()
        {
            try
            {
                var models = context.Items;
                var entities = models.Select(i => i);

                return entities.ToList().Select(i => ItemMapper.Instance.ToEntity(i));
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
                    context.DeleteObject(model);
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
                var model = context.Items.Where(i => i.Id == entity.Id).FirstOrDefault();

                if (model != null)
                {
                    ItemMapper.Instance.FromEntity(entity, model);

                    context.SaveChanges();
                    //context.Refresh(RefreshMode.StoreWins, context.Items);
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
