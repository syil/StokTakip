using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Data.Entities;

namespace StokTakip.Core.Views
{
    public interface IExpenseView : IView
    {
        string SelectedCategory { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }

        Expense SelectedExpense { get; }

        IEnumerable<string> CategoryList { set; }

        List<Expense> ExpenseList { set; }
    }
}
