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

namespace ServicesApplication.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            GC.Collect();
        }

        private void registrationBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (phoneTxb.Text.Length < 11)
                {
                    throw new Exception("Минимальное количество символов в поле номер - 11");
                }
                else if (phoneTxb.Text.Length >= 11)
                {
                    Clients newClients = new Clients();
                    SignIn newSignIn = new SignIn();

                    newClients.Surname = surnameTxb.Text;
                    newClients.Name = nameTxb.Text;
                    newClients.Patronymic = patronymicTxb.Text;
                    newClients.Phone = phoneTxb.Text;
                    newClients.SignInID = newSignIn.ID;

                    newSignIn.Login = loginTxb.Text;
                    newSignIn.Password = passTxb.Text;
                    newSignIn.RoleID = "U";

                    ConnectClass.db.SignIn.Add(newSignIn);  
                    ConnectClass.db.Clients.Add(newClients);
                    ConnectClass.db.SaveChanges();

                    MessageBox.Show("Регистрация прошла успешно!");
                    NavigationService.GoBack();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void phoneTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
