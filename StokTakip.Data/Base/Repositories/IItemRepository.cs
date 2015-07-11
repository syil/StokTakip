using StokTakip.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.Base.Repositories
{
    public interface IItemRepository : ICommonRepository<Item>
    {
        IEnumerable<Item> SearchByName(string filterText);
        void AddOrUpdateProperty(Item item, ItemProperty property);
        IEnumerable<ItemProperty> GetProperties(Item item);
        void DeleteProperty(Item item, string key);
    }
}
