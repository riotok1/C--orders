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

namespace School_Application.View.Pages.Circles.DopInfo.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для CircAddDataPage.xaml
    /// </summary>
    public partial class CircAddDataPage : Page
    {
        public CircAddDataPage()
        {
            InitializeComponent();

            circleCmb.ItemsSource = ConnectClass.db.TypeOfCircle.Select(item => item.Title).ToList();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            GC.Collect();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            DB.Schedule newSchedule = new DB.Schedule();
            DB.Class newClass = new DB.Class();
        }
    }
}
