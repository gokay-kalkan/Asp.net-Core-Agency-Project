using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        DbContext db = new DbContext();
        DbSet<T> _object;
        public Repository()
        {
            _object = db.Set<T>();
        }
        public void Delete(T p)
        {
            _object.Remove(p);
            db.SaveChanges();
        }

        public T Find(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).FirstOrDefault();
        }

        public T GetByID(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetList(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            db.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public void Update(T p)
        {
            db.SaveChanges();
        }
    }
}
