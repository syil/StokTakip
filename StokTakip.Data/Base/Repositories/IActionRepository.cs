using StokTakip.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.Base.Repositories
{
    public interface IActionRepository : ICommonRepository<ActionLog>
    {
        IEnumerable<ActionLog> GetItemActions(Item item);
        void DeleteItemActions(Item item);
        void UndoLastItemAction(Item item);
    }
}
