using CommonLibrary.Utilities;
using CommonLib.Exceptions;
using StokTakip.Data.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;

namespace StokTakip.Data.EF
{
    public abstract class RepositoryBase
    {
        private static readonly Logger logger = new Logger();

        protected StokContext context;

        public RepositoryBase(StokContext context)
        {
            this.context = context;
        }

        protected void RaiseException(Exception ex)
        {
            logger.Exception(ex);

            if (ex is DbEntityValidationException)
            {
                var validationException = ex as DbEntityValidationException;

                StringBuilder sb = new StringBuilder();

                sb.AppendLine(validationException.Message);
                sb.AppendLine("EntityValidationErrors: ");

                int i = 0;
                foreach (var errorList in validationException.EntityValidationErrors)
                {
                    sb.AppendFormat("   [{0}]: ", i).AppendLine();

                    foreach (var error in errorList.ValidationErrors)
                    {
                        sb.AppendFormat("     [\"{0}\"]: [{1}]", error.PropertyName, error.ErrorMessage).AppendLine();
                    }

                    sb.AppendLine();
                    i++;
                }

                sb.AppendLine(validationException.StackTrace);

                throw new RepositoryException(sb.ToString(), validationException);
            }

            throw new RepositoryException(ex);
        }
    }
}
