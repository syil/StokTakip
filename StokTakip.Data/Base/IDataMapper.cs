using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.Base
{
    public interface IDataMapper<TModel, TEntity>
    {
        void ToEntity(TModel source, TEntity target);
        TEntity ToEntity(TModel source);
        void FromEntity(TEntity source, TModel target);
    }
}
