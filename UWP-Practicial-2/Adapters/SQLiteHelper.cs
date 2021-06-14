using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;

namespace UWP_Practicial_2.Adapters
{
    class SQLiteHelper
    {
        private readonly string dbName = "user.db";

        private static SQLiteHelper sQLiteHelper;

        public static SQLiteHelper GetInstance()
        {
            if (sQLiteHelper == null)
            {
                sQLiteHelper = new SQLiteHelper();
            }
            return sQLiteHelper;
        }

        public SQLiteHelper()
        {

            sQLiteConnection = new SQLiteConnection(dbName);
            CreateUsersTable();
        }

        public SQLiteConnection sQLiteConnection { get; private set; }

        public void CreateUsersTable()
        {
            var sql_txt = @"CREATE TABLE IF NOT EXISTS User(id integer primary key AUTOINCREMENT, username varchar(200), password varchar(200))";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Step();
        }
    }
}
