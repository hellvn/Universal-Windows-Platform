using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP_Practicial_2.Adapters;
using UWP_Practicial_2.Models;
using SQLitePCL;

namespace UWP_Practicial_2.Models
{
    class Login
    {
        public List<Users> GetUsers()
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.sQLiteConnection;
            string sql_txt = "select * from User";
            var statement = sQLiteConnection.Prepare(sql_txt);
            List<Users> listUser = new List<Users>();
            while (SQLiteResult.ROW == statement.Step())
            {
                string username = (string)statement[0];
                string password = (string)statement[1];

                Users users = new Users(username, password);
                listUser.Add(users);
            }
            return listUser;
        }
    }
}
