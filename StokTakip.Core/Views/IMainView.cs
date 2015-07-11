using StokTakip.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Core.Views
{
    public interface IMainView : IView
    {
        void SetActionLogList(IEnumerable<ActionLog> actionLogs);
        void SetItemList(IEnumerable<Item> items);
        Item SelectedItem { get; }
        ActionLog SelectedActionLog { get; }
        string ItemFilterText { get; }
    }
}
