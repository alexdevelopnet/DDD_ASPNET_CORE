using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DbContextBase _dbContextBase;
        public BaseRepository(DbContextBase dbContextBase)
        {
            this._dbContextBase = dbContextBase;
        }
        public void Insert(TEntity entity)
        {
            _dbContextBase.Add(entity);
            _dbContextBase.SaveChanges();
        }

        public IList<TEntity> Select() => _dbContextBase.Set<TEntity>().ToList();

        public TEntity Select(int id)
        {
            return _dbContextBase.Set<TEntity>().Find(id);
        }

        public void Delete(int id)
        {
            _dbContextBase.Set<TEntity>().Remove(Select(id));
        }

        public void Update(TEntity entity)
        {
            _dbContextBase.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbContextBase.SaveChanges();
        }

    }
}
