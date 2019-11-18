namespace Cardano.Abstractions.Client
{
    /// <summary>
    /// Информация о страницах
    /// </summary>
    public class Pagination
    {
        /// <summary>
        /// Текущая страница
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Че то еще за страница
        /// </summary>
        public int PerPage { get; set; }

        /// <summary>
        /// Общее
        /// </summary>
        public int TotalEntries { get; set; }

        /// <summary>
        /// Общее количество страниц
        /// </summary>
        public int TotalPages { get; set; }
    }
}