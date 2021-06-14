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
using Assignment1.Models;
using System.Windows;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Layout : Page
    {
        public Layout()
        {
            this.InitializeComponent();

            MainFrame.Navigate(typeof(Pages.Home));
        }
        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            MN.Items.Add(new MenuItem { Name = "Home", MenuPage = "home", Icon = "Home"});
            MN.Items.Add(new MenuItem { Name = "Eat-In", MenuPage = "eat-in", Icon = "Emoji"});
            MN.Items.Add(new MenuItem { Name = "Collection", MenuPage = "collection", Icon = "AllApps" });
            MN.Items.Add(new MenuItem { Name = "Delivery", MenuPage = "delivery", Icon = "Bullets" });
            MN.Items.Add(new MenuItem { Name = "Take Away", MenuPage = "take-away", Icon = "Shop" });
            MN.Items.Add(new MenuItem { Name = "Driver Payment", MenuPage = "payment", Icon = "OpenPane" });
            MN.Items.Add(new MenuItem { Name = "Customers", MenuPage = "customers", Icon = "Contact"});
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem item = MN.SelectedItem as MenuItem; //object vua click
            switch (item.MenuPage)
            {
                case "home":
                    MainFrame.Navigate(typeof(Pages.Home));
                    break;
                case "eat-in":
                    MainFrame.Navigate(typeof(Pages.Eat_In));
                    break;
                case "collection":
                    MainFrame.Navigate(typeof(Pages.Collection));
                    break;
                case "delivery":
                    MainFrame.Navigate(typeof(Pages.Delivery));
                    break;
                case "take-away":
                    MainFrame.Navigate(typeof(Pages.Take_Away));
                    break;
                case "payment":
                    MainFrame.Navigate(typeof(Pages.Payment));
                    break;
                case "customers":
                    MainFrame.Navigate(typeof(Pages.Customers));
                    break;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Exit();

        }

        private void FacebookBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.social.facebook));
        }

        private void TwitterBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.social.twitter));
        }

        private void InstagramBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.social.instagram));
        }
    }
}
