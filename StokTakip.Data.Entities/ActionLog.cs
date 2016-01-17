using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Data.Entities.Enums;

namespace StokTakip.Data.Entities
{
    public class ActionLog
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime ActionDate { get; set; }
        public int OldQuantity { get; set; }
        public int NewQuantity { get; set; }
        public int Change { get; set; }
        public ActionType ActionType { get; set; }
        public Item Item { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is ActionLog)
            {
                return this.Id == ((ActionLog)obj).Id;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
