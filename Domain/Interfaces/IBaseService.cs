using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        TEntity Add(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Delete(int id);
        void Update(TEntity entity);  

    }
}
