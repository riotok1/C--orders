using School_Application.Classes;
using School_Application.View.Pages.Competition.FunctionsWithData;
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

namespace School_Application.View.Pages.Competition
{
    /// <summary>
    /// Логика взаимодействия для CompetitionMainPage.xaml
    /// </summary>
    public partial class CompetitionMainPage : Page
    {
        public CompetitionMainPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.PaintingCompetition.ToList();

            if (listDataView.SelectedItem != null)
            {
                listDataView.SelectedItem = null;
            }
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddCompData());
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            GC.Collect();
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            DB.PaintingCompetition editComp = (DB.PaintingCompetition)listDataView.SelectedItem;
            if (editComp != null)
            {
                NavigationService.Navigate(new EditCompPage(editComp));
            }
            else
            {
                MessageBox.Show("Выберите элемент для редактирования!");
            }
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.PaintingCompetition removeComp = (DB.PaintingCompetition)listDataView.SelectedItem;
                if (removeComp != null)
                {
                    if (MessageBox.Show("Вы точно хотите удалить выбранный элемент? Данные будут удалены навсегда!", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        ConnectClass.db.PaintingCompetition.Remove(removeComp);
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

        private void dopInfoBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.PaintingCompetition.Where(item => item.StudentsWorks.WorkName.Contains(searchTxb.Text) 
            || item.Nominations.Competition.CompName.Contains(searchTxb.Text) || item.Nominations.Competition.Location.Contains(searchTxb.Text)
            || item.Nominations.NominationName.Contains(searchTxb.Text)).ToList();
        }
    }
}
