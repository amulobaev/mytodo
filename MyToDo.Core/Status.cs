namespace MyToDo.Core
{
    /// <summary>
    /// Статус задачи
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// Новая
        /// </summary>
        ToDo = 0,
        
        /// <summary>
        /// Выполняется
        /// </summary>
        InProgress,
        
        /// <summary>
        /// Выполнена
        /// </summary>
        Done,
        
        /// <summary>
        /// Отменена
        /// </summary>
        Cancelled
    }
}