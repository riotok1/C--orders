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

namespace School_Application.View.Pages.Teachers.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для TeachAddOrEditPage.xaml
    /// </summary>
    public partial class TeachAddOrEditPage : Page
    {
        public DB.Teachers cTeacher { get; set; }
        public TeachAddOrEditPage(DB.Teachers sTeacher)
        {
            InitializeComponent();
            cTeacher = sTeacher;
            this.DataContext = this;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            GC.Collect();
        }

        private void addOrEditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (cTeacher == null)
            {
                ConnectClass.db.Teachers.Add(cTeacher);
                ConnectClass.db.SaveChanges();
                MessageBox.Show("Данные были успешно добавлены!");
                NavigationService.GoBack();
            }
            else if (cTeacher != null)
            {
                ConnectClass.db.SaveChanges();
                MessageBox.Show("Данные были успешно изменены!");
                NavigationService.GoBack();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (cTeacher.ID != 0)
            {
                addOrEditBtn.Content = "Изменить";
            }
            else if (cTeacher.ID == 0)
            {
                addOrEditBtn.Content = "Добавить";
            }
        }
    }
}
