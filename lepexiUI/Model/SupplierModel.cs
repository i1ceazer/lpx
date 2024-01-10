using System;

namespace lepexiUI.Model
{
    /// <summary>
    /// Модель поставщика товаров.
    /// </summary>
    public class SupplierModel
    {
        /// <summary>
        /// Уникальный идентификатор поставщика.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Название компании поставщика.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Имя менеджера поставщика.
        /// </summary>
        public string ManagerName { get; set; }

        /// <summary>
        /// Контактная информация поставщика.
        /// </summary>
        public string ContactInfo { get; set; }

        /// <summary>
        /// Дни заказов у поставщика.
        /// </summary>
        public string OrderDays { get; set; }

        /// <summary>
        /// Примечание к поставщику.
        /// </summary>
        public string Note { get; set; }
    }
}
