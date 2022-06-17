using ServicesApplication.Classes;
using ServicesApplication.DB;
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

namespace ServicesApplication.View.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminMainPage.xaml
    /// </summary>
    public partial class AdminMainPage : Page
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            dataViewGrid.ItemsSource = ConnectClass.db.Services.Where(x => x.ServiceName.Contains(searchTxb.Text)).ToList();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы точно хотите удалить выбранный элемент?, Данные будут удалены навсегда!", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (dataViewGrid.SelectedItem != null)
                    {
                        ConnectClass.db.Services.Remove(dataViewGrid.SelectedItem as Services);
                        ConnectClass.db.SaveChanges();
                        Page_Loaded(null, null);

                        MessageBox.Show("Удаление прошло успешно!");
                    }
                    else
                    {
                        throw new Exception("Выберите элемент для удаления!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataViewGrid.ItemsSource = ConnectClass.db.Services.ToList();

            if (dataViewGrid.SelectedItem != null)
            {
                dataViewGrid.SelectedItem = null;
            }
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddOrEditPage(new Services()));
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dataViewGrid.SelectedItem != null)
                {
                    NavigationService.Navigate(new AddOrEditPage(dataViewGrid.SelectedItem as Services));
                }
                else
                {
                    throw new Exception("Выберите элемент для редактирования!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void viewZBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ViewZPage());
        }
    }
}
