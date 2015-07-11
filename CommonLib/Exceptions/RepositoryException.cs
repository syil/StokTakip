using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Exceptions
{
    public class RepositoryException : Exception
    {
        public RepositoryException(Exception innerException)
            : base("Repository process could not be completed", innerException)
        {

        }

        public RepositoryException(Exception innerException, object data)
            : base("Repository process could not be completed", innerException)
        {
            this.Data.Add("RepositoryData", data);
        }

        public RepositoryException(string message, Exception innerException)
            : base(message, innerException)
        {

        }

        public RepositoryException(string message, Exception innerException, object data)
            : base(message, innerException)
        {
            this.Data.Add("RepositoryData", data);
        }
    }
}
