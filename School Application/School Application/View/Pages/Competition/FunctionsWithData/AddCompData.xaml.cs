using Microsoft.Win32;
using School_Application.Classes;
using School_Application.DB;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace School_Application.View.Pages.Competition.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для AddCompData.xaml
    /// </summary>
    public partial class AddCompData : Page
    {
        public AddCompData()
        {
            InitializeComponent();

            teacherCmb.ItemsSource = ConnectClass.db.Teachers.ToList();
            studentsCmb.ItemsSource = ConnectClass.db.Students.ToList();
        }

        OpenFileDialog imgFile = new OpenFileDialog();

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            GC.Collect();
        }

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

        private void addBtn_Click_1(object sender, RoutedEventArgs e)
        {
            PaintingCompetition newPainting = new PaintingCompetition();
            Nominations newNom = new Nominations();
            DB.Competition newComp = new DB.Competition();
            StudentsWorks newWork = new StudentsWorks();

            newPainting.Result = resultTxb.Text;
            newPainting.WorkID = newWork.ID;
            newPainting.NominationID = newNom.ID;

            newNom.NominationName = nominationTxb.Text;
            newNom.CompetitionID = newComp.ID;

            newComp.CompName = compNameTxb.Text;
            newComp.Location = locationTxb.Text;

            var currentTeacher = teacherCmb.SelectedItem as DB.Teachers;
            newPainting.TeacherID = currentTeacher.ID;

            var currentStudent = studentsCmb.SelectedItem as DB.Students;
            newWork.StudentID = currentStudent.ID;
            newWork.WorkName = workNameTxb.Text;
            newWork.Description = descriptionTxb.Text;
            newWork.Image = imgFile.FileName;

            ConnectClass.db.StudentsWorks.Add(newWork);
            ConnectClass.db.Competition.Add(newComp);
            ConnectClass.db.Nominations.Add(newNom);
            ConnectClass.db.PaintingCompetition.Add(newPainting);
            ConnectClass.db.SaveChanges();

            MessageBox.Show("Данные были успешно добавлены!");
            NavigationService.GoBack();
        }
    }
}
