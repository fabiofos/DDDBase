using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity Obj);

        TEntity GetById(int Id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity Obj);

        void Remove(TEntity Obj);

        void Dispose();
    }
}
