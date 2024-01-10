using lepexiUI.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lepexiUI.Repositories
{
    /// <summary>
    /// Репозиторий пользователей для работы с базой данных.
    /// </summary>
    public class UserRepository : RepositoryBase, IUserRepository
    {
        /// <summary>
        /// Добавляет нового пользователя в базу данных.
        /// </summary>
        /// <param name="userModel">Модель пользователя, которую необходимо добавить.</param>
        public void Add(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Проверяет аутентификацию пользователя на основе учетных данных.
        /// </summary>
        /// <param name="credential">Учетные данные пользователя.</param>
        /// <returns>True, если пользователь аутентифицирован, в противном случае - false.</returns>
        public bool AuthenticateUser(NetworkCredential credential)
        {
            bool validUser;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [User] WHERE username=@username AND [password]=@password";
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = credential.UserName;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = credential.Password;
                validUser = command.ExecuteScalar() == null ? false : true;
            }
            return validUser;
        }

        /// <summary>
        /// Редактирует данные пользователя в базе данных.
        /// </summary>
        /// <param name="userModel">Модель пользователя с обновленными данными.</param>
        public void Edit(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получает всех пользователей из базы данных.
        /// </summary>
        /// <returns>Список всех пользователей.</returns>
        public IEnumerable<UserModel> GetByAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получает пользователя по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор пользователя.</param>
        /// <returns>Модель пользователя.</returns>
        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Получает пользователя по его имени пользователя.
        /// </summary>
        /// <param name="username">Имя пользователя.</param>
        /// <returns>Модель пользователя.</returns>
        public UserModel GetByUsername(string username)
        {
            UserModel user = null;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM [User] WHERE username=@username";
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new UserModel()
                        {
                            Id = reader[0].ToString(),
                            Username = reader[1].ToString(),
                            Password = string.Empty,
                            Name = reader[3].ToString(),
                            LastName = reader[4].ToString(),
                            Email = reader[5].ToString(),
                        };
                    }
                }
            }
            return user;
        }

        /// <summary>
        /// Удаляет пользователя по его идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор пользователя для удаления.</param>
        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
