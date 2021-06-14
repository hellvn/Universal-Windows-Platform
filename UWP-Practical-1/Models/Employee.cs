using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Practical_1.Models
{
    class Employee
    {
        public List<EmployeeList> employee_list { get; set; }
    }
    public class EmployeeList
    {
        public string name { get; set; }
        public string role { get; set; }
        public int birthyear { get; set; }
    }
}
