using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using MyToDo.Core;

namespace MyToDo.Data
{
    /// <summary>
    /// Реализация "внутреннего" generic репозитария с указанием типов модели и DTO (в данном случае сущности Entity Framework)
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    /// <typeparam name="TEntity"></typeparam>
    internal sealed class EfInternalRepository<TModel, TEntity> : IInternalRepository<TModel>
        where TModel : BaseModel
        where TEntity : BaseEntity
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="dbContext"></param>
        public EfInternalRepository(DbContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException("dbContext");

            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public IEnumerable<TModel> GetAll()
        {
            TEntity[] entities = _dbSet.ToArray();
            TModel[] models = Mapper.Map<TEntity[], TModel[]>(entities);
            return models;
        }

        public TModel GetById(Guid id)
        {
            TEntity entity = _dbSet.FirstOrDefault(x => x.Id == id);
            return entity != null ? Mapper.Map<TEntity, TModel>(entity) : null;
        }

        public void Create(TModel model)
        {
            TEntity entity = Mapper.Map<TModel, TEntity>(model);
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(TModel model)
        {
            TEntity entity = _dbSet.FirstOrDefault(x => x.Id == model.Id);
            if (entity != null)
            {
                Mapper.Map(model, entity);
                _dbContext.SaveChanges();
            }
        }

        public void Delete(TModel model)
        {
            TEntity entity = _dbSet.FirstOrDefault(x => x.Id == model.Id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _dbContext.SaveChanges();
            }
        }

        public void CreateMappings()
        {
            Mapper.CreateMap<TModel, TEntity>();
            Mapper.CreateMap<TEntity, TModel>();
            //.ConstructUsing(x => (TModel)Activator.CreateInstance(typeof(TModel), x.Id));
        }

        public void Dispose()
        {
        }

    }
}