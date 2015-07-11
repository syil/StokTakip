using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Data.Base
{
    public interface ICommonRepository<T>
    {
        void AddNew(T entity);
        T Get(object key);
        IEnumerable<T> GetList();
        void Delete(T entity);
        void Update(T entity);
    }
}
