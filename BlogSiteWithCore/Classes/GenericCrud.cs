using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSiteWithCore.Classes
{
    public class GenericCrud<T> : IRepository<T> where T : DbObject
    {
        private BlogContext _db;
        private DbSet<T> _table;

        public GenericCrud(BlogContext db)
        {
            _db = db;
            _table = _db.Set<T>();
        }

        public void Add(T entity)
        {
            _table.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(T entity)
        {
            _table.Remove(entity);
            _db.SaveChanges();
        }

        public T FindById(string id)
        {
            return _table.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetList()
        {
            return  _table.ToList();
        }

        public void Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
