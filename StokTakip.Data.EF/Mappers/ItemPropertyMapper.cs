using StokTakip.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.EF.Mappers
{
    internal class ItemPropertyMapper : IDataMapper<Model.ItemProperty, Entities.ItemProperty>
    {
        private static ItemPropertyMapper instance;

        protected ItemPropertyMapper()
        {

        }

        public static ItemPropertyMapper Instance
        {
            get
            {
                if (instance == null)
                    instance = new ItemPropertyMapper();

                return instance;
            }
        }

        public void ToEntity(Model.ItemProperty source, Entities.ItemProperty target)
        {
            target.Key = source.Key;
            target.Value = source.Value;
        }

        public Entities.ItemProperty ToEntity(Model.ItemProperty source)
        {
            var entity = new Entities.ItemProperty();
            ToEntity(source, entity);

            return entity;
        }

        public void FromEntity(Entities.ItemProperty source, Model.ItemProperty target)
        {
            target.Key = source.Key;
            target.Value = source.Value;
        }
    }
}
