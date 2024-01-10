using lepexiUI.Model;
using lepexiUI.Repositories;
using System;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace lepexiUI.ViewModel
{
    public class SuppliersViewModel : ViewModelBase
    {

        // Поля

        private readonly SupplierRepository _supplierRepository;

        // Свойства

        private ObservableCollection<SupplierModel> _selectedSuppliers;

        public ObservableCollection<SupplierModel> SelectedSuppliers
        {
            get { return _selectedSuppliers; }
            set
            {
                _selectedSuppliers = value;
                OnPropertyChanged(nameof(SelectedSuppliers));
            }
        }

        private ObservableCollection<SupplierModel> _suppliers;

        public ObservableCollection<SupplierModel> Suppliers
        {
            get { return _suppliers; }
            set
            {
                _suppliers = value;
                OnPropertyChanged(nameof(Suppliers));
            }
        }

        // Команды

        // Команда для выполнения поиска
        public ICommand SearchCommand
        {
            get { return new ViewModelCommand(SearchSuppliers); }
        }

        // Команда для добавления новой строки
        public ICommand AddCommand
        {
            get { return new ViewModelCommand(AddSupplier); }
        }

        // Команда для удаления выбранных поставщиков
        public ICommand DeleteSelectedSuppliersCommand
        {
            get { return new ViewModelCommand(DeleteSelectedSuppliers); }
        }


        // Конструктор


        public SuppliersViewModel()
        {
            
            _supplierRepository = new SupplierRepository();

            LoadSuppliers(); // Загрузка данных при инициализации
        }



        // Методы


        // Метод для добавления новой строки
        private void AddSupplier(object parameter)
        {
            // Логика для добавления новой записи в коллекцию и базу данных
            var newSupplier = new SupplierModel();
            Suppliers.Add(newSupplier);
            _supplierRepository.AddSupplier(newSupplier); // Предполагается, что у вас есть метод AddSupplier в репозитории
        }

        // Метод для удаления выбранных поставщиков
        private void DeleteSelectedSuppliers(object parameter)
        {
            // Получаем выбранных поставщиков из коллекции
            var selectedSuppliers = SelectedSuppliers.ToList();

            // Удаление выбранных поставщиков из репозитория
            foreach (var supplier in selectedSuppliers)
            {
                _supplierRepository.DeleteSupplier(supplier.ID);
            }

            // После удаления, обновляем данные в DataGrid
            LoadSuppliers();
        }

        // Метод для проверки возможности удаления
        private bool CanDeleteSupplier(object parameter)
        {
            // Логика проверки возможности удаления (например, наличие выбранной записи)
            return parameter is SupplierModel;
        }

        // Метод для выполнения поиска поставщиков
        private void SearchSuppliers(object parameter)
        {
            // Здесь добавьте логику для поиска поставщиков
        }

        // Метод для загрузки списка поставщиков
        private void LoadSuppliers()
        {
            // Загрузка данных из репозитория поставщиков и привязка к коллекции Suppliers
            Suppliers = new ObservableCollection<SupplierModel>(_supplierRepository.GetSuppliers());

            // Инициализация SelectedSuppliers пустой коллекцией
            SelectedSuppliers = new ObservableCollection<SupplierModel>();
        }
    }
}
