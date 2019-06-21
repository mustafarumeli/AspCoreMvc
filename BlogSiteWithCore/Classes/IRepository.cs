using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteWithCore.Classes
{
    public interface IRepository<T> where T:DbObject
    {
        IEnumerable<T> GetList();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(string id);
    }

    public interface ITest
    {
        void DoStuff();
    }
    public class Test : ITest
    {
        public void DoStuff()
        {

        }
    }
}
