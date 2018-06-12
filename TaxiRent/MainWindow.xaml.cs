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
using TaxiRetnt.lib;

namespace TaxiRent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            //BaseGrid.Background = new ImageSource(new ImageSource()
        }

        private void btnLogOn_Click(object sender, RoutedEventArgs e)
        {
            ServiceXml service = new ServiceXml("user.xml");
            if(service.GetUser(txbLogin.Text, txbPassword.Password))
            {
                AdminWindow aw = new AdminWindow();
                aw.Show();
                this.Close();
            }
        }
    }
}
