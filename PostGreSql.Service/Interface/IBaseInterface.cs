using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGreSql.Service.Interface
{
    public interface IBaseInterface<T> where T : class
    {
        T Create(T t);
        T GetById(int Id);
        IEnumerable<T> GetAll();
        void Update(T t);
        void Delete(string Id);
        void Save();
    }
}
