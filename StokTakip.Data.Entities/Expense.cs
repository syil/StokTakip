using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Data.Entities.Enums;

namespace StokTakip.Data.Entities
{
    public class Expense
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public DateTime CreateDate { get; set; }
        public ExpenseStatus Status { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Expense)
            {
                return this.Id == ((Expense)obj).Id;
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
