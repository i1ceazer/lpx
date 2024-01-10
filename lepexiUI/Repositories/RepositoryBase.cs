using System;
using System.Data.SqlClient;

namespace lepexiUI.Repositories
{
    /// <summary>
    /// Абстрактный базовый класс для репозиториев.
    /// </summary>
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;

        /// <summary>
        /// Инициализирует новый экземпляр класса RepositoryBase с указанными настройками подключения к базе данных.
        /// </summary>
        public RepositoryBase()
        {
            // Строка подключения к базе данных.
            _connectionString = "Server=192.168.0.10,1433;Database=OrdersAss;User Id=sa;Password=253004;";
        }

        /// <summary>
        /// Получает новое соединение с базой данных.
        /// </summary>
        /// <returns>Объект SqlConnection для взаимодействия с базой данных.</returns>
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
