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
    /// Логика взаимодействия для ViewZPage.xaml
    /// </summary>
    public partial class ViewZPage : Page
    {
        public ViewZPage()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataViewGrid.ItemsSource = ConnectClass.db.ClientServices.ToList();
        }

        private void backZBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dataViewGrid.SelectedItem != null)
                {
                    var deleteClientServies = dataViewGrid.SelectedItem as ClientServices;
                    Services newServices = new Services();

                    newServices.ServiceName = deleteClientServies.ServiceName;
                    newServices.ServiceTiming = deleteClientServies.ServiceTiiming;
                    newServices.ServiceDate = deleteClientServies.ServiceDate;
                    newServices.Price = deleteClientServies.Price;
                    newServices.Description = deleteClientServies.Description;

                    ConnectClass.db.Services.Add(newServices);
                    ConnectClass.db.ClientServices.Remove(deleteClientServies);
                    ConnectClass.db.SaveChanges();
                    Page_Loaded(null, null);

                    MessageBox.Show("Отмена прошла успешно!");
                }
                else
                {
                    throw new Exception("Выберите запись для отмены!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
