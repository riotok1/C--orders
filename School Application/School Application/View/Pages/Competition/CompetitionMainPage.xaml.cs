using School_Application.Classes;
using School_Application.View.Pages.Competition.FunctionsWithData;
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

namespace School_Application.View.Pages.Competition
{
    /// <summary>
    /// Логика взаимодействия для CompetitionMainPage.xaml
    /// </summary>
    public partial class CompetitionMainPage : Page
    {
        public CompetitionMainPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.PaintingCompetition.ToList();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddCompData());
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dopInfoBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
