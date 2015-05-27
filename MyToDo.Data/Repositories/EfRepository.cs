using System;
using System.Collections.Generic;
using System.Linq;

namespace MyToDo.Data
{
    /// <summary>
    /// Реализация generic репозитария для Entity Framework
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class EfRepository<T> : IRepository<T>, IDisposable
    {
        /// <summary>
        /// Контекст Entity Framework
        /// </summary>
        private readonly MyToDoContext _context;

        private readonly IInternalRepository<T> _internalRepository;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="entityTypeResolver"></param>
        protected EfRepository(IEntityTypeResolver entityTypeResolver)
        {
            // Получение типа модели
            Type modelType = typeof(T);

            // Получение типа сущности Entity Framework (DTO)
            Type entityType = entityTypeResolver.Resolve(modelType);
            if (entityType == null)
                throw new InvalidOperationException(string.Format("Для модели типа {0} не найден тип DTO", typeof(T)));

            // Получение generic типа для внетреннего репозитария
            Type repositoryType = typeof(EfInternalRepository<,>);
            Type genericRepositoryType = repositoryType.MakeGenericType(modelType, entityType);

            _context = new MyToDoContext();

            // Создание репозитария
            // TODO переделать на Emit или Expressions
            try
            {
                _internalRepository = Activator.CreateInstance(genericRepositoryType, _context) as IInternalRepository<T>;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(String.Format("Ошибка при создании репозитария для типа {0}",
                    genericRepositoryType));
            }

            //CreateMappings();
        }

        /// <summary>
        /// Создание привязок
        /// </summary>
        protected virtual void CreateMappings()
        {
            _internalRepository.CreateMappings();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _internalRepository.GetAll();
        }

        public virtual IQueryable<T> Query()
        {
            return _internalRepository.Query();
        }

        public virtual T GetById(Guid id)
        {
            return _internalRepository.GetById(id);
        }

        public virtual void Create(T model)
        {
            _internalRepository.Create(model);
        }

        public virtual void Update(T model)
        {
            _internalRepository.Update(model);
        }

        public virtual void Delete(T model)
        {
            _internalRepository.Delete(model);
        }

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
            GC.SuppressFinalize(this);
        }
        
    }
}