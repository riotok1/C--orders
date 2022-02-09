using Microsoft.Win32;
using School_Application.Classes;
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
        }

        OpenFileDialog imgFile = new OpenFileDialog();

        private void openBtn_Click(object sender, RoutedEventArgs e)
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

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            DB.StudentsWorks newWork = new DB.StudentsWorks();

            newWork.Image = imgFile.FileName;

            ConnectClass.db.StudentsWorks.Add(newWork);
            ConnectClass.db.SaveChanges();
            MessageBox.Show("Изображение добавлено!");

            NavigationService.GoBack();
        }
    }
}
