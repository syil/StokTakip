using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Data.Entities;

namespace StokTakip.Core.Views
{
    public interface IAddExpenseView : IView
    {
        IEnumerable<string> CategoryList { set; }
        
        Expense Expense { get; }
    }
}
