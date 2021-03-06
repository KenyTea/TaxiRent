﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for AddUser_page.xaml
    /// </summary>
    public partial class AddUser_page : Page
    {
        Random r = new Random();
        public AddUser_page()
        {
            InitializeComponent();
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            string massage;
            Tdl_User user = new Tdl_User();
            user.Id = r.Next();
            user.Name = string.Format("{0}_{1}", tbFName.Text, tbLName.Text.Substring(0, 1));
            user.Password = r.Next().ToString();
            user.DateOfBirsday = (DateTime)dpDob.SelectedDate;
            user.Gender = (Gender)(ldGender.SelectedIndex);
            ServiceXml sx = new ServiceXml();
            if (!sx.AddUsers(user, out massage))
            {
                ErrorMessage.Foreground = new SolidColorBrush(Colors.Red);
                ErrorMessage.Content = massage;
                
            }
            else
            {
                ErrorMessage.Foreground = new SolidColorBrush(Colors.Green);
                ErrorMessage.Content = massage;
                Thread.Sleep(2000);
                AdminWindow.mf.Source = new Uri("Pages/ListUsers_page.xaml", UriKind.RelativeOrAbsolute);
                
            }
        }
    }
}
