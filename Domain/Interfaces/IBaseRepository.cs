using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Delete(int id);
        void Update(TEntity entity);
    }
}
