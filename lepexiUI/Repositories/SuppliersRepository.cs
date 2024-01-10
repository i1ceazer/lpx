using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using lepexiUI.Model;

namespace lepexiUI.Repositories
{
    /// <summary>
    /// Репозиторий для работы с данными о поставщиках.
    /// </summary>
    public class SupplierRepository : RepositoryBase
    {
        /// <summary>
        /// Получает список всех поставщиков из базы данных.
        /// </summary>
        /// <returns>Список моделей поставщиков.</returns>
        public IEnumerable<SupplierModel> GetSuppliers()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Suppliers";
                    command.CommandType = CommandType.Text;

                    var suppliers = new List<SupplierModel>();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            suppliers.Add(new SupplierModel
                            {
                                ID = (int)reader["ID"],
                                CompanyName = reader["CompanyName"].ToString(),
                                ManagerName = reader["ManagerName"].ToString(),
                                ContactInfo = reader["ContactInfo"].ToString(),
                                OrderDays = reader["OrderDays"].ToString(),
                                Note = reader["Note"].ToString()
                            });
                        }
                    }
                    return suppliers;
                }
            }
        }

        /// <summary>
        /// Добавляет поставщика в базу данных.
        /// </summary>
        /// <param name="supplier">Модель поставщика.</param>
        public void AddSupplier(SupplierModel supplier)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Suppliers (CompanyName, ManagerName, ContactInfo, OrderDays, Note) " +
                                          "VALUES (@CompanyName, @ManagerName, @ContactInfo, @OrderDays, @Note)";
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@CompanyName", supplier.CompanyName);
                    command.Parameters.AddWithValue("@ManagerName", supplier.ManagerName);
                    command.Parameters.AddWithValue("@ContactInfo", supplier.ContactInfo);
                    command.Parameters.AddWithValue("@OrderDays", supplier.OrderDays);
                    command.Parameters.AddWithValue("@Note", supplier.Note);

                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Удаляет поставщика из базы данных.
        /// </summary>
        /// <param name="supplierId">Идентификатор поставщика.</param>
        public void DeleteSupplier(int supplierId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Suppliers WHERE ID = @ID";
                    command.CommandType = CommandType.Text;

                    command.Parameters.AddWithValue("@ID", supplierId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}