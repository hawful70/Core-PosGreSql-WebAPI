using PostGreSql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGreSql.Service.Interface
{
    public interface IErrorService
    {
        Error Create(Error error);

        void Save();
    }
}
