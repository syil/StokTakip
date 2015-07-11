using StokTakip.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.EF.Mappers
{
    internal class ItemMapper : IDataMapper<Model.Item, Entities.Item>
    {
        private static ItemMapper instance;

        protected ItemMapper()
        {

        }

        public static ItemMapper Instance
        {
            get
            {
                if (instance == null)
                    instance = new ItemMapper();

                return instance;
            }
        }

        public void ToEntity(Model.Item source, Entities.Item target)
        {
            target.Id = source.Id;
            target.InsertDate = source.InsertDate;
            target.Name = source.Name;
            target.Quantity = source.Quantity;
            //target.Actions = source.ActionLogs.Select(a => ActionLogMapper.ToEntity(a)).ToArray();
            //target.Properties = source.Properties.Select(p => ItemPropertyMapper.ToEntity(p)).ToArray();
        }

        public Entities.Item ToEntity(Model.Item source)
        {
            var target = new Entities.Item();

            ToEntity(source, target);

            return target;
        }

        public void FromEntity(Entities.Item source, Model.Item target)
        {
            target.Id = source.Id;
            target.InsertDate = source.InsertDate;
            target.Name = source.Name;
            target.Quantity = source.Quantity;
        }
    }
}
