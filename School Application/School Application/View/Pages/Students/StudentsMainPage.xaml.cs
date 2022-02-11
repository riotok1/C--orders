using School_Application.Classes;
using School_Application.View.Pages.Students.FunctionsWithData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace School_Application.View.Pages.Students
{
    /// <summary>
    /// Логика взаимодействия для StudentsMainPage.xaml
    /// </summary>
    public partial class StudentsMainPage : Page
    {
        public StudentsMainPage()
        {
            InitializeComponent();

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataView.ItemsSource = ConnectClass.db.Students.ToList(); //Вывод данных

            if (dataView.SelectedItem != null)
            {
                dataView.SelectedItem = null;
            }
        }

        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e) //Поиск данных
        {
            dataView.ItemsSource = ConnectClass.db.Students.Where(item => item.Surname.Contains(searchTxb.Text)
            || item.Name.Contains(searchTxb.Text) || item.Patronymic.Contains(searchTxb.Text) || item.Class.ClassNumber.ToString().Contains(searchTxb.Text) 
            || item.Class.Letter.Contains(searchTxb.Text)).ToList();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e) //Возврат назад
        {
            NavigationService.GoBack();
            GC.Collect();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StudAddOrEditPage(new DB.Students(), new DB.Class()));
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dataView.SelectedItem != null)
                {
                    NavigationService.Navigate(new StudAddOrEditPage(dataView.SelectedItem as DB.Students, (dataView.SelectedItem as DB.Students).Class));
                }
                else
                {
                    throw new Exception("Выберите элемент для редактирования!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.Students removeStudents = (DB.Students)dataView.SelectedItem;
                if (removeStudents != null)
                {
                    if (MessageBox.Show("Вы точно хотите удалить выбранный элемент? Данные будут удалены навсегда!", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        ConnectClass.db.Students.Remove(removeStudents);
                        ConnectClass.db.SaveChanges();
                        Page_Loaded(null, null);
                        MessageBox.Show("Удаление прошло успешно!");
                    }
                }
                else
                {
                    throw new Exception("Выберите элемент для удаления!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
