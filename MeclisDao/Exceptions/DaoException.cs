using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.Exceptions
{
  public  class DaoException: Exception
    {
        public bool Islem { get; }
        public int Id { get; set; }
        public DaoException(string message, int id = 0, bool islem = false)
            : base(message)
        {
            Islem = islem;
            Id = id;
        }
    }

    public class DaoException<TExceptionData> : DaoException
    {
        public TExceptionData ExceptionData { get; }
        public DaoException(TExceptionData exceptionData, string message, int id = 0, bool islem = false)
            : base(message, id, islem)
        {
            ExceptionData = exceptionData;
        }
    }

}

