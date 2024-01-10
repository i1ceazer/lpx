using System.Collections.Generic;
using System.Net;

namespace lepexiUI.Model
{
    /// <summary>
    /// Интерфейс для работы с репозиторием пользователей.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Аутентификация пользователя на основе учетных данных.
        /// </summary>
        /// <param name="credential">Учетные данные пользователя.</param>
        /// <returns>True, если аутентификация успешна, иначе False.</returns>
        bool AuthenticateUser(NetworkCredential credential);

        /// <summary>
        /// Добавление нового пользователя.
        /// </summary>
        /// <param name="userModel">Модель пользователя для добавления.</param>
        void Add(UserModel userModel);

        /// <summary>
        /// Редактирование данных пользователя.
        /// </summary>
        /// <param name="userModel">Модель пользователя для редактирования.</param>
        void Edit(UserModel userModel);

        /// <summary>
        /// Удаление пользователя по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор пользователя.</param>
        void Remove(int id);

        /// <summary>
        /// Получение пользователя по идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор пользователя.</param>
        /// <returns>Модель пользователя.</returns>
        UserModel GetById(int id);

        /// <summary>
        /// Получение пользователя по имени пользователя (логину).
        /// </summary>
        /// <param name="username">Имя пользователя (логин).</param>
        /// <returns>Модель пользователя.</returns>
        UserModel GetByUsername(string username);

        /// <summary>
        /// Получение всех пользователей.
        /// </summary>
        /// <returns>Коллекция моделей пользователей.</returns>
        IEnumerable<UserModel> GetByAll();

        // Другие методы и интерфейсные члены...
    }
}
