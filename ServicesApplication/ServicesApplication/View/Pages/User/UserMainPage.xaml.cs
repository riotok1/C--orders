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

namespace ServicesApplication.View.Pages.User
{
    /// <summary>
    /// Логика взаимодействия для UserMainPage.xaml
    /// </summary>
    public partial class UserMainPage : Page
    {
        private Clients selectedItem;
        public UserMainPage(Clients selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataViewGrid.ItemsSource = ConnectClass.db.Services.ToList();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void delBtn_Click(object sender, RoutedEventArgs e) //Запись на услугу
        {
            try
            {
                ClientServices newClientServices = new ClientServices();

                if (dataViewGrid.SelectedItem != null)
                {
                    var selectServies = (dataViewGrid.SelectedItem as Services);

                    newClientServices.ServiceName = selectServies.ServiceName;
                    newClientServices.ServiceTiiming = selectServies.ServiceTiming;
                    newClientServices.ServiceDate = Convert.ToDateTime(selectServies.ServiceDate);
                    newClientServices.Price = selectServies.Price;
                    newClientServices.Description = selectServies.Description;

                    newClientServices.ClientID = selectedItem.ID;

                    ConnectClass.db.ClientServices.Add(newClientServices);
                    ConnectClass.db.Services.Remove(selectServies);
                    ConnectClass.db.SaveChanges();
                    Page_Loaded(null, null);

                    MessageBox.Show("Запись прошла успешно!");
                }
                else
                {
                    throw new Exception("Выберите услугу для записи!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void dopInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dataViewGrid.SelectedItem != null)
                {
                    NavigationService.Navigate(new DopInfoPage(dataViewGrid.SelectedItem as Services));
                }
                else
                {
                    throw new Exception("Выберите услугу для просмотра дополнительной информации!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void myServiceTxb_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MyServicesPage(selectedItem));
        }

        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            dataViewGrid.ItemsSource = ConnectClass.db.Services.Where(x => x.ServiceName.Contains(searchTxb.Text)).ToList(); //Поиск
        }

        private void personalCBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserPersonalCabinetPage(selectedItem));
        }
    }
}
