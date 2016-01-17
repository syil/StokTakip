using StokTakip.Data.Base.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.Base
{
    public interface IRepositoryContainer
    {
        IItemRepository Item { get; }
        IActionRepository Action { get; }
        IExpenseRepository Expense { get; }
        void RunTransactionalWork(Action work);
    }
}
