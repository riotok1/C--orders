using Microsoft.Win32;
using School_Application.Classes;
using School_Application.DB;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace School_Application.View.Pages.Competition.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для EditCompPage.xaml
    /// </summary>
    public partial class EditCompPage : Page
    {
        private PaintingCompetition selectedItem;
        public EditCompPage(PaintingCompetition selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;

            if (selectedItem.StudentsWorks.Image == null)
            {
                imgLoad.Source = null;
            }
            else
            {
                imgLoad.Source = new BitmapImage(new Uri(selectedItem.StudentsWorks.Image, UriKind.Relative));
            }

            workNameTxb.Text = selectedItem.StudentsWorks.WorkName;
            nominationTxb.Text = selectedItem.Nominations.NominationName;
            descriptionTxb.Text = selectedItem.StudentsWorks.Description;
            resultTxb.Text = selectedItem.Result;
            compNameTxb.Text = selectedItem.Nominations.Competition.CompName;
            locationTxb.Text = selectedItem.Nominations.Competition.Location;

            teacherCmb.ItemsSource = ConnectClass.db.Teachers.ToList();
            teacherCmb.SelectedItem = selectedItem.Teachers;

            studentsCmb.ItemsSource = ConnectClass.db.Students.ToList();
            studentsCmb.SelectedItem = selectedItem.StudentsWorks.Students;
        }

        OpenFileDialog imgFile = new OpenFileDialog();
        private void openBtn_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                imgFile.Filter = "Image (*.jpg; *.png; *jpeg;) | *.jpg; *.png; *.jpeg;";
                if (imgFile.ShowDialog() == true)
                {
                    imgLoad.Source = new BitmapImage(new Uri(imgFile.FileName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex);
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            GC.Collect();
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            var editCompetition = ConnectClass.db.PaintingCompetition.FirstOrDefault(item => item.ID == selectedItem.ID);

            editCompetition.StudentsWorks.WorkName = workNameTxb.Text;
            editCompetition.Nominations.NominationName = nominationTxb.Text;
            editCompetition.StudentsWorks.Description = descriptionTxb.Text;
            editCompetition.Result = resultTxb.Text;
            editCompetition.Nominations.Competition.CompName = compNameTxb.Text;
            editCompetition.Nominations.Competition.Location = locationTxb.Text;

            var currentTeacher = teacherCmb.SelectedItem as DB.Teachers;
            editCompetition.TeacherID = currentTeacher.ID;

            var currentStudents = studentsCmb.SelectedItem as DB.Students;
            editCompetition.StudentsWorks.StudentID = currentStudents.ID;

            editCompetition.StudentsWorks.Image = imgFile.FileName;

            ConnectClass.db.SaveChanges();

            MessageBox.Show("Данные были успешно изменены!");
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
