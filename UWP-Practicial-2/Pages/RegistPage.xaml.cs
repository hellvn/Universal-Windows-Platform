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
using UWP_Practicial_2.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_Practicial_2.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegistPage : Page
    {
        public RegistPage()
        {
            this.InitializeComponent();
        }

        private void loginbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pages.LoginPage));
        }

        private void registbtn_Click(object sender, RoutedEventArgs e)
        {
            if (UsernameInput.Text == null || PasswordInput.Password == null)
            {
                alert.Text = "Please fill all the input field!";
            }
            else
            {
                alert.Text = string.Empty;
            }
            var newUser = UsernameInput.Text;
            var newPass = PasswordInput.Password;
            Users NewUsers = new Users(newUser, newPass);
            Register register = new Register();
            //register.Regist(NewUsers);
            if (register.Regist(NewUsers))
            {
                this.Frame.Navigate(typeof(Pages.LoginPage));
                alert.Text = "Registralation successfully!";
            }
            else
            {
                alert.Text = "Registralation failed!";
            }
            

        }

        private void UsernameInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (UsernameInput.Text == "Admin" || UsernameInput.Text == "admin")
            {
                alert.Text = "Please choose another user name!";
            }
            else
            {
                alert.Text = string.Empty;
            }
        }
    }
}
