using StokTakip.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Core.Views
{
    public interface IAddItemView : IView
    {
        Item NewItem { get; }
    }
}
