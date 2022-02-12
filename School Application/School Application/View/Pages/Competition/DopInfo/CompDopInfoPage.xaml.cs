using School_Application.DB;
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

namespace School_Application.View.Pages.Competition.DopInfo
{
    /// <summary>
    /// Логика взаимодействия для CompDopInfoPage.xaml
    /// </summary>
    public partial class CompDopInfoPage : Page
    {
        public PaintingCompetition cPainting { get; set; }
        public CompDopInfoPage(PaintingCompetition sPainting)
        {
            InitializeComponent();
            cPainting = sPainting;
            this.DataContext = this;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            GC.Collect();
        }

        private void pdfBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(mainGrid, "invoice");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }
        }
    }
}
