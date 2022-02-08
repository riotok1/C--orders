using School_Application.Classes;
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

namespace School_Application.View.Pages.Circles
{
    /// <summary>
    /// Логика взаимодействия для CirclesMainPage.xaml
    /// </summary>
    public partial class CirclesMainPage : Page
    {
        public CirclesMainPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.Schedule.ToList();
        }

        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.Schedule.Where(item => item.Circles.TypeOfCircle.Title.Contains(searchTxb.Text)
            || item.Circles.Teachers.Surname.Contains(searchTxb.Text) || item.Circles.Teachers.Name.Contains(searchTxb.Text)
            || item.Circles.Teachers.Patronymic.Contains(searchTxb.Text)).ToList();
        }
    }
}
