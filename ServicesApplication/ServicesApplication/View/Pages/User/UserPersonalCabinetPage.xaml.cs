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
    /// Логика взаимодействия для UserPersonalCabinetPage.xaml
    /// </summary>
    public partial class UserPersonalCabinetPage : Page
    {
        private Clients selectedItem;
        public UserPersonalCabinetPage(Clients selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;

            surnameTxb.Text = selectedItem.Surname;
            nameTxb.Text = selectedItem.Name;
            patronymicTxb.Text = selectedItem.Patronymic;
            phoneTxb.Text = selectedItem.Phone;
            loginTxb.Text = selectedItem.SignIn.Login;
            passTxb.Text = selectedItem.SignIn.Password;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            GC.Collect();
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (phoneTxb.Text.Length < 11)
                {
                    throw new Exception("Минимальное количество символов в поле номер - 11");
                }
                else if (phoneTxb.Text.Length >= 11)
                {
                    var editUser = ConnectClass.db.Clients.FirstOrDefault(x => x.ID == selectedItem.ID);

                    editUser.Surname = surnameTxb.Text;
                    editUser.Name = nameTxb.Text;
                    editUser.Patronymic = patronymicTxb.Text;
                    editUser.Phone = phoneTxb.Text;
                    editUser.SignIn.Login = loginTxb.Text;
                    editUser.SignIn.Password = passTxb.Text;

                    ConnectClass.db.SaveChanges();
                    MessageBox.Show("Редактирование аккаунта прошло успешно!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }
    }
}
