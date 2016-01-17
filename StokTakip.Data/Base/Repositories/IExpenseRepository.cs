using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Data.Entities;

namespace StokTakip.Data.Base.Repositories
{
    public interface IExpenseRepository : ICommonRepository<Expense>
    {
        IEnumerable<string> GetCategories();
        IEnumerable<Expense> GetList(string category, DateTime startDate, DateTime endDate);
    }
}
