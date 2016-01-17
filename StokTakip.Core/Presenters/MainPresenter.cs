using log4net;
using Microsoft.Practices.Unity;
using StokTakip.Core.Views;
using StokTakip.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Core.Presenters
{
    public class MainPresenter : DataPresenterBase<IMainView>
    {
        public MainPresenter(IMainView view)
            : base(view)
        {
            
        }

        public override void Initialize()
        {
            //RefreshView();
            base.Initialize();
        }
    }
}
