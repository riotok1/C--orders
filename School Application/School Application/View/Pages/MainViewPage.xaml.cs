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
using System.Data.OleDb;
using School_Application.View.Pages.Students;
using School_Application.View.Pages.Teachers;
using School_Application.View.Pages.Circles;
using School_Application.View.Pages.Competition;

namespace School_Application.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainViewPage.xaml
    /// </summary>
    public partial class MainViewPage : Page
    {
        public MainViewPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void studentsTxb_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StudentsMainPage());
        }

        private void teacherTxb_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TeachersMainPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CirclesMainPage());
        }

        private void competitionBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CompetitionMainPage());
        }
    }
}
