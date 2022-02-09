using School_Application.Classes;
using School_Application.View.Pages.Circles.DopInfo;
using School_Application.View.Pages.Circles.DopInfo.FunctionsWithData;
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

namespace School_Application.View.Pages.Circles
{
    /// <summary>
    /// Логика взаимодействия для CirclesMainPage.xaml
    /// </summary>
    public partial class CirclesMainPage : Page
    {
        public CirclesMainPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataView.ItemsSource = ConnectClass.db.Schedule.ToList();
        }

        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            dataView.ItemsSource = ConnectClass.db.Schedule.Where(item => item.Circles.TypeOfCircle.Title.Contains(searchTxb.Text)
            || item.Circles.Teachers.Surname.Contains(searchTxb.Text) || item.Circles.Teachers.Name.Contains(searchTxb.Text)
            || item.Circles.Teachers.Patronymic.Contains(searchTxb.Text)).ToList();
        }

        private void visitsBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.Schedule visSchedule = (DB.Schedule)dataView.SelectedItem;
                if (visSchedule != null)
                {
                    NavigationService.Navigate(new CircDopInfo(visSchedule));
                }
                else
                {
                    throw new Exception("Выберите кружок для просмотра информации");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            GC.Collect();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            DB.Schedule editSchedule = (DB.Schedule)dataView.SelectedItem;
            if (editSchedule != null)
            {
                NavigationService.Navigate(new AddOrEditPage(editSchedule));
            }
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.Schedule removeSchdule = (DB.Schedule)dataView.SelectedItem;
                if (removeSchdule != null)
                {
                    if (MessageBox.Show("Вы точно хотите удалить выбранный элемент? Данные будут удалены навсегда!", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        ConnectClass.db.Schedule.Remove(removeSchdule);
                        ConnectClass.db.SaveChanges();
                        Page_Loaded(null, null);
                        MessageBox.Show("Удаление прошло успешно!");
                    }
                }
                else
                {
                    throw new Exception("Выберите элемент для удаления!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
