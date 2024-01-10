using System;

namespace lepexiUI.Model
{
    /// <summary>
    /// Модель учетной записи пользователя.
    /// </summary>
    public class UserAccountModel
    {
        /// <summary>
        /// Логин пользователя.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Отображаемое имя пользователя.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Фотография профиля пользователя в виде байтового массива.
        /// </summary>
        public byte[] ProfilePicture { get; set; }
    }
}
