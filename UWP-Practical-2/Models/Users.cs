using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Practicial_2.Models
{
    class Users
    {
        
        private string username;
        private string passord;

        public Users(string username, string password)
        {
           
            Username = username;
            Password = password;
        }

        

        public string Username // properties
        {
            get => username;
            set => username = value;
        }

        public string Password
        {
            get => passord;
            set => passord = value;
        }
    }
    
}
