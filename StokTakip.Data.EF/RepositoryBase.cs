using CommonLib;
using CommonLib.Exceptions;
using StokTakip.Data.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.EF
{
    public abstract class RepositoryBase
    {
        protected StokContext context;

        public RepositoryBase(StokContext context)
        {
            this.context = context;
        }

        protected void RaiseException(Exception ex)
        {
            throw new RepositoryException(ex);
        }

        protected void RaiseException(Exception ex, object data)
        {
            ex.Data.Add("RepositoryData", data);

            throw new RepositoryException(ex);
        }
    }
}
