using Microsoft.Win32;
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

namespace School_Application.View.Pages.Competition.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для EditCompPage.xaml
    /// </summary>
    public partial class EditCompPage : Page
    {
        public EditCompPage()
        {
            InitializeComponent();
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

        }
    }
}
