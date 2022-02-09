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

namespace School_Application.View.Pages.Students.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для StudAddOrEditPage.xaml
    /// </summary>
    public partial class StudAddOrEditPage : Page
    {
        public DB.Students cStudents { get; set; }
        public DB.Class cClass { get; set; }
        public StudAddOrEditPage(DB.Students sStudents, DB.Class sClass)
        {
            InitializeComponent();
            cStudents = sStudents;  
            cClass = sClass;
            this.DataContext = this;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e) //Возврат назад
        {
            NavigationService.GoBack();
            GC.Collect();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (cStudents.ID != 0)
            {
                addOrEditBtn.Content = "Изменить";
            }
            else if (cStudents.ID == 0)
            {
                addOrEditBtn.Content = "Добавить";
            }
        }

        private void addOrEditBtn_Click(object sender, RoutedEventArgs e)
        {
            if (cStudents.ID == 0)
            {
                ConnectClass.db.Class.Add(cClass);
                cStudents.ClassID = ConnectClass.db.Class.Max(item => item.ID)+1;
                ConnectClass.db.Students.Add(cStudents);
                ConnectClass.db.SaveChanges();
                MessageBox.Show("Данные были успешно добавлены!");
                NavigationService.GoBack(); 
            }
            else if (cStudents.ID != 0)
            {
                ConnectClass.db.SaveChanges();
                MessageBox.Show("Данные были успешно изменены!");
                NavigationService.GoBack();
            }
        }
    }
}
