using UWP_Practical_1.Models;
using UWP_Practical_1.Services;
using Windows.UI.Xaml.Controls;

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
            getEMP();
        }
        private async void getEMP()
        {
            ReadFile readFile = new ReadFile();
            Employee employee = await readFile.ReadJson("employee.json");
            if (employee != null)
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
