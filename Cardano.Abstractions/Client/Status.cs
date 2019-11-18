namespace Cardano.Abstractions.Client
{
    /// <summary>
    /// Статус запроса
    /// </summary>
    public enum Status
    {
        /// <summary>
        /// Успешно завершен
        /// </summary>
        Success,
        
        /// <summary>
        /// Неуспешно завершен
        /// </summary>
        Fail,
        
        /// <summary>
        /// Ошибка при выполнении
        /// </summary>
        Error
    }
}