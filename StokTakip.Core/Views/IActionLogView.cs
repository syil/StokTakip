using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Data.Entities;

namespace StokTakip.Core.Views
{
    public interface IActionLogView : IView
    {
        Item SelectedItem { get; }
        ActionLog SelectedActionLog { get; }

        IEnumerable<ActionLog> ActionLogList { set; }
    }
}
