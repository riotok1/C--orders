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

            circleCmb.ItemsSource = ConnectClass.db.TypeOfCircle.ToList();

            teacherCmb.ItemsSource = ConnectClass.db.Teachers.ToList();

            classCmb.ItemsSource = ConnectClass.db.Class.ToList();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            GC.Collect();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            DB.Schedule newSchedule = new DB.Schedule();
            DB.Circles newCircles = new DB.Circles();

            newSchedule.Cabinet = cabinetTxb.Text;
            newSchedule.WeekDay = weekDayTxb.Text;  
            newSchedule.StartTime = startTimeTxb.Text;  
            newSchedule.FinishTime = finishTimeTxb.Text;  
            newSchedule.HalfYear = Convert.ToInt32(halfYearTxb.Text);  
            newSchedule.AcademicYear = yearTxb.Text;
            newSchedule.CircleID = newCircles.ID;

            var currentClub = circleCmb.SelectedItem as DB.TypeOfCircle;
            newSchedule.CircleID = currentClub.ID;

            var currentTeacher = teacherCmb.SelectedItem as DB.Teachers;
            newSchedule.TeacherID = currentTeacher.ID;

            var currentClass = classCmb.SelectedItem as DB.Class;
            newSchedule.ClassID = currentClass.ID;

            newCircles.ClassID = currentClass.ID;
            newCircles.CircTypeID = currentClub.ID;
            
            ConnectClass.db.Circles.Add(newCircles);    
            ConnectClass.db.Schedule.Add(newSchedule);
            ConnectClass.db.SaveChanges();

            MessageBox.Show("Данные были успешно добавлены!");
            NavigationService.GoBack();
        }
    }
}
