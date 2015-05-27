using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;

namespace MyToDo.Data
{
    /// <summary>
    /// Реализация generic репозитария для Entity Framework
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EfRepository<T> : BaseRepository<T>
    {
        private readonly IInternalRepository<T> _internalRepository;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="entityTypeResolver"></param>
        public EfRepository(IEntityTypeResolver entityTypeResolver)
        {
            // Получение типа модели
            Type modelType = typeof(T);

            // Получение типа сущности Entity Framework (DTO)
            Type entityType = entityTypeResolver.Resolve(modelType);
            if (entityType == null)
                throw new InvalidOperationException(string.Format("Для модели типа {0} не найден тип DTO", typeof (T)));
            
            // Получение generic типа для внетреннего репозитария
            Type repositoryType = typeof(EfInternalRepository<,>);
            Type genericRepositoryType = repositoryType.MakeGenericType(modelType, entityType);
            
            // Создание репозитария
            // TODO переделать на Emit или Expressions
            try
            {
                _internalRepository = Activator.CreateInstance(genericRepositoryType, Context) as IInternalRepository<T>;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(String.Format("Ошибка при создании репозитария для типа {0}",
                    genericRepositoryType));
            }

            CreateMappings();
        }

        /// <summary>
        /// Создание привязок
        /// </summary>
        protected virtual void CreateMappings()
        {
            _internalRepository.CreateMappings();
        }

        public override IEnumerable<T> GetAll()
        {
            return _internalRepository.GetAll();
        }

        public override T GetById(Guid id)
        {
            return _internalRepository.GetById(id);
        }

        public override void Create(T model)
        {
            _internalRepository.Create(model);
        }

        public override void Update(T model)
        {
            _internalRepository.Update(model);
        }

        public override void Delete(T model)
        {
            _internalRepository.Delete(model);
        }
    }
}
