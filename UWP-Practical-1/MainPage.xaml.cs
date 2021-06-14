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
using Newtonsoft.Json;
using System.Threading.Tasks;
using UWP_Practical_1.Models;
using UWP_Practical_1.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_Practical_1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       
        public MainPage()
        {
            this.InitializeComponent();
            Write_file();
        }
        private async void getEMP(object sender, RoutedEventArgs e)
        {
            ReadFile readFile = new ReadFile();
            Employee employee = await readFile.ReadJson("employee.json");
            if(employee != null)
            {
                EmpList.ItemsSource = employee.employee_list;
            }

        }
        private void Write_file()
        {
            string json = @"{
            'employee_list': [
        {
          'name': 'Peter Parker',
          'role': 'Developer',
          'birthyear': 1990
         },
        {
          'name': 'Tom Hank',
          'role': 'Tester',
          'birthyear': 1991
        },
        {
          'name': 'Mary Jane',
          'role': 'QA',
          'birthyear': 1994
    }
  ]
}";
            ReadFile.WriteFile("employee.json", json);
        }

       
    }
}
