using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public DateTime InsertDate { get; set; }
        public ItemProperty[] Properties { get; set; }
        public ActionLog[] Actions { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1} Adet)", this.Name, this.Quantity);
        }

        public override bool Equals(object obj)
        {
            if (obj is Item)
            {
                return this.Id == ((Item)obj).Id;
            }
            else
            {
                return false;
            }
        }
    }
}
