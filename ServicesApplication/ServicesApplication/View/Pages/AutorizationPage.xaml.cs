using ServicesApplication.Classes;
using ServicesApplication.View.Pages.Admin;
using ServicesApplication.View.Pages.User;
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

namespace ServicesApplication.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
        }

        private void comeBtn_Click(object sender, RoutedEventArgs e) //Авторизация
        {
            try
            {
                var currentUser = ConnectClass.db.Clients.FirstOrDefault(x => x.SignIn.Login == loginTxb.Text && x.SignIn.Password == passTxb.Password);
                if (currentUser != null)
                {
                    switch (currentUser.SignIn.RoleID)
                    {
                        case "A":
                            NavigationService.Navigate(new AdminMainPage());
                            break;
                        case "U":
                            NavigationService.Navigate(new UserMainPage(currentUser));
                            break;
                    }
                }
                else
                {
                    throw new Exception("Введите корректные данные либо заполните все поля!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void registrBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
