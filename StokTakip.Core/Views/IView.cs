using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Core.Views
{
    public interface IView
    {
        void ShowMessage(string message, string group, MessageType type);
    }
}
