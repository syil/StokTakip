using StokTakip.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.EF.Mappers
{
    internal class ActionLogMapper : IDataMapper<Model.ActionLog, Entities.ActionLog>
    {
        private static ActionLogMapper instance;

        protected ActionLogMapper()
        {

        }

        public static ActionLogMapper Instance
        {
            get
            {
                if (instance == null)
                    instance = new ActionLogMapper();

                return instance;
            }
        }

        public void ToEntity(Model.ActionLog source, Entities.ActionLog target)
        {
            target.Id = source.Id;
            target.ActionDate = source.ActionDate;
            target.Description = source.Description;
            target.OldQuantity = source.OldQuantity;
            target.NewQuantity = source.NewQuantity;
            target.Change = source.Change;
            target.Item = ItemMapper.Instance.ToEntity(source.Item);
            target.Type = source.ActionType.ToNameEquivalent<Entities.Enums.ActionType>();
        }

        public Entities.ActionLog ToEntity(Model.ActionLog source)
        {
            var entity = new Entities.ActionLog();

            ToEntity(source, entity);
            return entity;
        }

        public void FromEntity(Entities.ActionLog source, Model.ActionLog target)
        {
            target.Id = source.Id;
            target.Description = source.Description;
            target.OldQuantity = source.OldQuantity;
            target.NewQuantity = source.NewQuantity;
            target.Change = source.Change;
            target.ActionDate = source.ActionDate;
            target.ItemId = source.Item.Id;
            target.ActionType = source.Type.ToNameEquivalent<Model.ActionType>();
        }
    }
}
