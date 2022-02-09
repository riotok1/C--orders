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
    }
}
