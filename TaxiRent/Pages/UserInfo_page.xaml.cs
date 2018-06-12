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
using TaxiRetnt.lib.Modules;

namespace TaxiRent.Pages
{
    /// <summary>
    /// Interaction logic for UserInfo_page.xaml
    /// </summary>
    public partial class UserInfo_page : Page
    {
        public List<Tdl_User> users { get; set; }
        public UserInfo_page()
        {
            InitializeComponent();
            ServiceXml sx = new ServiceXml();
            users = sx.getUserss();
        }


    }
}
