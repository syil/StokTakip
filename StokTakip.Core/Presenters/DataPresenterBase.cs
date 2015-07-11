using CommonLib;
using CommonLib.IoC;
using StokTakip.Core.Views;
using StokTakip.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Core.Presenters
{
    public abstract class DataPresenterBase<T> : PresenterBase<T>
        where T : IView
    {
        protected IRepositoryContainer repositoryContainer;

        public DataPresenterBase(T view)
            : base(view)
        {
            this.repositoryContainer = DependencyResolver.Instance.Resolve<IRepositoryContainer>();
        }
    }
}
