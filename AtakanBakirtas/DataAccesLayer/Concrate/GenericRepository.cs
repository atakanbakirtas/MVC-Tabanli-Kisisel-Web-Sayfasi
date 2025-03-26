using DataAccesLayer.Concrate.Repositorys;
using DataAccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrate
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context con=new Context();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object=con.Set<T>();
        }
        public void Add(T p)
        {
            var AddEntity=con.Entry(p);
            AddEntity.State = EntityState.Added;
            con.SaveChanges();
        }

        public void Delete(T p)
        {
            var DeleteEntity=con.Entry(p);  
            DeleteEntity.State = EntityState.Deleted;
            con.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var UpdateEntity = con.Entry(p);
            UpdateEntity.State = EntityState.Modified;
            con.SaveChanges();
        }
    }
}
