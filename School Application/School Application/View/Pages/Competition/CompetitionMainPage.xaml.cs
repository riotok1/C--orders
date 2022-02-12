using Microsoft.Office.Interop.Excel;
using School_Application.Classes;
using School_Application.View.Pages.Competition.DopInfo;
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
using Exel = Microsoft.Office.Interop.Excel;

namespace School_Application.View.Pages.Competition
{
    /// <summary>
    /// Логика взаимодействия для CompetitionMainPage.xaml
    /// </summary>
    public partial class CompetitionMainPage : System.Windows.Controls.Page
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
            if (listDataView.SelectedItem != null)
            {
                NavigationService.Navigate(new CompDopInfoPage(listDataView.SelectedItem as DB.PaintingCompetition));
            }
        }

        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.PaintingCompetition.Where(item => item.StudentsWorks.WorkName.Contains(searchTxb.Text) 
            || item.Nominations.Competition.CompName.Contains(searchTxb.Text) || item.Nominations.Competition.Location.Contains(searchTxb.Text)
            || item.Nominations.NominationName.Contains(searchTxb.Text)).ToList();
        }

        private void wordBtn_Click(object sender, RoutedEventArgs e)
        {
            var word = new Microsoft.Office.Interop.Word.Application();

            try
            {
                var document = word.Documents.Add();
                var paragrah = word.ActiveDocument.Paragraphs.Add();
                var tableRange = paragrah.Range;
                var dishList = ConnectClass.db.PaintingCompetition.ToList();
                var table = document.Tables.Add(tableRange, dishList.Count, 4);
                table.Borders.Enable = 1;
                table.Cell(1, 1).Range.Text = "Название проекта";
                table.Cell(1, 2).Range.Text = "Область конкурса";
                table.Cell(1, 3).Range.Text = "Место проведения";
                table.Cell(1, 4).Range.Text = "Номинация";

                int i = 2;
                foreach (var item in dishList)
                {
                    table.Cell(i, 1).Range.Text = item.StudentsWorks.WorkName;
                    table.Cell(i, 2).Range.Text = item.Nominations.Competition.CompName;
                    table.Cell(i, 3).Range.Text = item.Nominations.Competition.Location;
                    table.Cell(i, 4).Range.Text = item.Nominations.NominationName;
                    i++;
                }
                document.SaveAs2(@"D:\competition.docx");
                document.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);
                word.Quit(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);
                MessageBox.Show("Сохранение прошло успешно!", "Сохранено!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " выдал исключение!", MessageBoxButton.OK, MessageBoxImage.Error);
                word.Quit(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges);
            }
        }

    }
}
