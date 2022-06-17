using ServicesApplication.DB;
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

namespace ServicesApplication.View.Pages.User
{
    /// <summary>
    /// Логика взаимодействия для DopInfoPage.xaml
    /// </summary>
    public partial class DopInfoPage : Page
    {
        private Services selectedItem; 
        public DopInfoPage(Services selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;

            serviceTxb.Text = selectedItem.ServiceName;
            timingTxb.Text = selectedItem.ServiceTiming;
            priceTxb.Text = Convert.ToString(selectedItem.Price);
            descriptionTxb.Text = selectedItem.Description;
            dateDtp.Text = Convert.ToString(selectedItem.ServiceDate);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
            GC.Collect();
        }
    }
}
