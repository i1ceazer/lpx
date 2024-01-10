using System;

namespace lepexiUI.Model
{
    /// <summary>
    /// Модель пользователя.
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// Уникальный идентификатор пользователя.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Логин пользователя.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Пароль пользователя.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия пользователя.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Адрес электронной почты пользователя.
        /// </summary>
        public string Email { get; set; }
    }
}
