using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _baseRepository;
        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            this._baseRepository = baseRepository;
        }
        public TEntity Add(TEntity entity)
        {
            _baseRepository.Insert(entity);
            return entity;
        }
        public TEntity GetById(int id) => _baseRepository.GetById(id);

        public IEnumerable<TEntity> GetAll() => _baseRepository.GetAll();

        public void Delete(int id) => _baseRepository.Delete(id);

        public TEntity Update(TEntity entity) => _baseRepository.Update(entity);

    }
}
