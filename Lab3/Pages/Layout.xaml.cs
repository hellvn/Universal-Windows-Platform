using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Lab3.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Lab3.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Layout : Page
    {
        public Layout()
        {
            this.InitializeComponent();
        }

        private void MenuList_Loaded(object sender, RoutedEventArgs e)
        {
            MenuList.Items.Add(new MenuItem { Name = "Home", MenuPage = "home" });
            MenuList.Items.Add(new MenuItem { Name = "Contact", MenuPage = "contact" });
            MenuList.Items.Add(new MenuItem { Name = "Customer", MenuPage = "customer" });
            MenuList.Items.Add(new MenuItem { Name = "Mail", MenuPage = "mail" });

        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem menuItem = MenuList.SelectedItem as MenuItem;
            switch (menuItem.MenuPage)
            {
                default: MainFrame.Navigate(typeof(Pages.Home));
                    break;
                case "home": MainFrame.Navigate(typeof(Pages.Home));
                    break;
                case "contact": MainFrame.Navigate(typeof(Pages.Contact));
                    break;
                case "customer":MainFrame.Navigate(typeof(Pages.Customer));
                    break;
                case "mail":
                    MainFrame.Navigate(typeof(Pages.Mail));
                    break;
            }
        }

        private void MenuList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
