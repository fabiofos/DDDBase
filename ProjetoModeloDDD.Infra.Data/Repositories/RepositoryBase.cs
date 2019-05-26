using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ProjetoModeloContext db = new ProjetoModeloContext(); 
        public void Add(TEntity Obj)
        {
            db.Set<TEntity>().Add(Obj);
            db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int Id)
        {
            return db.Set<TEntity>().Find(Id);
        }

        public void Remove(TEntity Obj)
        {
            db.Set<TEntity>().Remove(Obj);
            db.SaveChanges();
        }

        public void Update(TEntity Obj)
        {
            db.Entry(Obj).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
