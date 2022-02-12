using Microsoft.Office.Interop.Excel;
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
using Exel = Microsoft.Office.Interop.Excel;

namespace School_Application.View.Pages.Circles.DopInfo
{
    /// <summary>
    /// Логика взаимодействия для CircDopInfo.xaml
    /// </summary>
    public partial class CircDopInfo : System.Windows.Controls.Page
    {
        private DB.Schedule selectedItem;
        public CircDopInfo(DB.Schedule selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dataView.ItemsSource = ConnectClass.db.Schedule.Where(item => item.CircleID == selectedItem.Circles.ID).ToList();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            GC.Collect();
        }

        private void exceBtn_Click(object sender, RoutedEventArgs e)
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
