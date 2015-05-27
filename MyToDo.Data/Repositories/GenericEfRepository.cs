namespace MyToDo.Data
{
    public class GenericEfRepository<T> : EfRepository<T>, IGenericRepository<T>
    {
        /// <summary>
        /// Конструктор экземепляра
        /// </summary>
        /// <param name="entityTypeResolver"></param>
        public GenericEfRepository(IEntityTypeResolver entityTypeResolver)
            : base(entityTypeResolver)
        {
        }
    }
}