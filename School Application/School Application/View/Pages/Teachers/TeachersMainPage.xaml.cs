using Microsoft.Office.Interop.Excel;
using School_Application.Classes;
using School_Application.View.Pages.Teachers.FunctionsWithData;
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

namespace School_Application.View.Pages.Teachers
{
    /// <summary>
    /// Логика взаимодействия для TeachersMainPage.xaml
    /// </summary>
    public partial class TeachersMainPage : System.Windows.Controls.Page
    {
        public TeachersMainPage()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            GC.Collect();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TeachAddOrEditPage(new DB.Teachers()));
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dataView.SelectedItem != null)
                {
                    NavigationService.Navigate(new TeachAddOrEditPage(dataView.SelectedItem as DB.Teachers));
                }
                else
                {
                    throw new Exception("Выберите элемент для редактирования!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.Teachers removeTeachers = (DB.Teachers)dataView.SelectedItem;
                if (removeTeachers != null)
                {
                    if (MessageBox.Show("Вы точно хотите удалить выбранный элемент? Данные будут удалены навсегда!", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        ConnectClass.db.Teachers.Remove(removeTeachers);
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

        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            dataView.ItemsSource = ConnectClass.db.Teachers.Where(item => item.Surname.Contains(searchTxb.Text) || item.Name.Contains(searchTxb.Text) || item.Patronymic.Contains(searchTxb.Text)).ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataView.ItemsSource = ConnectClass.db.Teachers.ToList();

            if (dataView.SelectedItem != null)
            {
                dataView.SelectedItem = null;
            }
        }

        private void wordBtn_Click(object sender, RoutedEventArgs e)
        {
            var word = new Microsoft.Office.Interop.Word.Application();

            try
            {
                var document = word.Documents.Add();
                var paragrah = word.ActiveDocument.Paragraphs.Add();
                var tableRange = paragrah.Range;
                var dishList = ConnectClass.db.Teachers.ToList();
                var table = document.Tables.Add(tableRange, dishList.Count, 3);
                table.Borders.Enable = 1;
                table.Cell(1, 1).Range.Text = "Фамилия";
                table.Cell(1, 2).Range.Text = "Имя";
                table.Cell(1, 3).Range.Text = "Отчество";

                int i = 2;
                foreach (var item in dishList)
                {
                    table.Cell(i, 1).Range.Text = item.Surname;
                    table.Cell(i, 2).Range.Text = item.Name;
                    table.Cell(i, 3).Range.Text = item.Patronymic;
                    i++;
                }
                document.SaveAs2(@"D:\workers.docx");
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

        private void exelBtn_Click(object sender, RoutedEventArgs e)
        {
            Exel.Application excel = new Exel.Application();
            excel.Visible = true; 
            Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];

            for (int j = 0; j < dataView.Columns.Count; j++) 
            {
                Range myRange = (Range)sheet1.Cells[1, j + 1];
                sheet1.Cells[1, j + 1].Font.Bold = true; 
                sheet1.Columns[j + 1].ColumnWidth = 15; 
                myRange.Value2 = dataView.Columns[j].Header;
            }
            for (int i = 0; i < dataView.Columns.Count; i++)
            { 
                for (int j = 0; j < dataView.Items.Count; j++)
                {
                    TextBlock b = dataView.Columns[i].GetCellContent(dataView.Items[j]) as TextBlock;
                    Exel.Range myRange = (Exel.Range)sheet1.Cells[j + 2, i + 1];
                    myRange.Value2 = b.Text;
                }
            }
        }
    }
}
