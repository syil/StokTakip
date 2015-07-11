using StokTakip.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Core.Views
{
    public interface IAddActionLogView : IView
    {
        void SetItemList(IEnumerable<Item> items);
        ActionLog NewActionLog { get; }
    }
}
