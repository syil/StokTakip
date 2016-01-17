using CommonLibrary.Utilities;
using StokTakip.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Core.Presenters
{
    public abstract class PresenterBase<T>
        where T : IView
    {
        protected T view;
        protected Logger logger;

        public bool IsInitialized { get; protected set; }

        public PresenterBase(T view)
        {
            this.view = view;
            this.logger = new Logger(this.GetType().FullName);
        }

        public virtual void Initialize()
        {
            this.IsInitialized = true;
        }
    }
}
