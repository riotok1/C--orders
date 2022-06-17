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
    /// Логика взаимодействия для AddOrEditPage.xaml
    /// </summary>
    public partial class AddOrEditPage : Page
    {
        public static Services cServices { get; set; }
        public AddOrEditPage(Services sServices)
        {
            InitializeComponent();
            cServices = sServices;
            this.DataContext = this;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            GC.Collect();
        }

        private void addOrEditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (cServices.ID == 0)
            {
                ConnectClass.db.Services.Add(cServices);
                ConnectClass.db.SaveChanges();
                MessageBox.Show("Данные были успешно добавлены!");
                NavigationService.GoBack();
            }
            else if (cServices.ID != 0)
            {
                ConnectClass.db.SaveChanges();
                MessageBox.Show("Данные были успешно изменены!");
                NavigationService.GoBack();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (cServices.ID == 0)
            {
                addOrEditBtn.Content = "Добавить";
            }
            else if (cServices != null)
            {
                addOrEditBtn.Content = "Изменить";
            }
        }
    }
}
