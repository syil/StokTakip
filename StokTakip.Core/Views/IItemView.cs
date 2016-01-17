using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokTakip.Data.Entities;

namespace StokTakip.Core.Views
{
    public interface IItemView : IView
    {
        string ItemFilterText { get; }

        Item SelectedItem { get; }
        IEnumerable<Item> ItemList { set; }
    }
}
