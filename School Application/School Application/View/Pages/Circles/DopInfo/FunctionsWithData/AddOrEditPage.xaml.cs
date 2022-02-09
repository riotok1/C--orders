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
    /// Логика взаимодействия для AddOrEditPage.xaml
    /// </summary>
    public partial class AddOrEditPage : Page
    {
        private DB.Schedule selectedItem;
        public AddOrEditPage(DB.Schedule selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;

            cabinetTxb.Text = selectedItem.Cabinet;
            weekDayTxb.Text = selectedItem.WeekDay;
            startTimeTxb.Text = selectedItem.StartTime;
            finishTimeTxb.Text = selectedItem.FinishTime;
            halfYearTxb.Text = Convert.ToString(selectedItem.HalfYear);
            yearTxb.Text = selectedItem.AcademicYear;
            classNumberTxb.Text = Convert.ToString(selectedItem.Class.ClassNumber);
            classLetterTxb.Text = selectedItem.Class.Letter;

            circleCmb.ItemsSource = ConnectClass.db.TypeOfCircle.Select(item => item.Title).ToList();
            circleCmb.SelectedItem = selectedItem.Circles.TypeOfCircle.Title;

            teacherCmb.ItemsSource = ConnectClass.db.Teachers.ToList();
            teacherCmb.SelectedItem = selectedItem.Circles.Teachers;
        }

        private void addOrEditBtn_Click(object sender, RoutedEventArgs e)
        {
            var editSchedule = ConnectClass.db.Schedule.FirstOrDefault(item => item.ID == selectedItem.ID);

            editSchedule.Cabinet = cabinetTxb.Text;
            editSchedule.WeekDay = weekDayTxb.Text;
            editSchedule.StartTime = startTimeTxb.Text;
            editSchedule.FinishTime = finishTimeTxb.Text;
            editSchedule.HalfYear = Convert.ToInt32(halfYearTxb.Text);
            editSchedule.AcademicYear = yearTxb.Text;
            editSchedule.Circles.Class.ClassNumber = Convert.ToInt32(classNumberTxb.Text);
            editSchedule.Circles.Class.Letter = classLetterTxb.Text;
           
            var editCircle = ConnectClass.db.Circles.FirstOrDefault(item => item.TypeOfCircle.Title == circleCmb.Text);
            editSchedule.Circles.CircTypeID = editCircle.ID;

            var currentTeacher = teacherCmb.SelectedItem as DB.Teachers;
            editSchedule.Circles.TeacheID = currentTeacher.ID;

            ConnectClass.db.SaveChanges();
            MessageBox.Show("Редактирование прошло успешно!");
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            GC.Collect();
        }
    }
}
