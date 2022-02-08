using School_Application.Classes;
using School_Application.View.Pages.Teachers.FunctionsWithData;
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

namespace School_Application.View.Pages.Teachers
{
    /// <summary>
    /// Логика взаимодействия для TeachersMainPage.xaml
    /// </summary>
    public partial class TeachersMainPage : Page
    {
        public TeachersMainPage()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            GC.Collect();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TeachAddOrEditPage(new DB.Teachers()));
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dataView.SelectedItem != null)
                {
                    NavigationService.Navigate(new TeachAddOrEditPage(dataView.SelectedItem as DB.Teachers));
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
                DB.Teachers removeTeachers = (DB.Teachers)dataView.SelectedItem;
                if (removeTeachers != null)
                {
                    if (MessageBox.Show("Вы точно хотите удалить выбранный элемент? Данные будут удалены навсегда!", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        ConnectClass.db.Teachers.Remove(removeTeachers);
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

        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            dataView.ItemsSource = ConnectClass.db.Teachers.Where(item => item.Surname.Contains(searchTxb.Text) || item.Name.Contains(searchTxb.Text) || item.Patronymic.Contains(searchTxb.Text)).ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataView.ItemsSource = ConnectClass.db.Teachers.ToList();

            if (dataView.SelectedItem != null)
            {
                dataView.SelectedItem = null;
            }
        }
    }
}
