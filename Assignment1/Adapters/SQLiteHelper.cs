using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using System.IO;
using Windows.Storage;

namespace Assignment1.Adapters
{
    class SQLiteHelper
    {
        private static SQLiteHelper sQLiteHelper;

        public static SQLiteHelper GetInstance()
        {
            if (sQLiteHelper == null)
            {
                sQLiteHelper = new SQLiteHelper();
            }
            return sQLiteHelper;
        }

        private SQLiteHelper()
        {
            string path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "t2004e.db");
            sQLiteConnection = new SQLiteConnection(path); // create database;
            CreateCartTable();
        }

        public SQLiteConnection sQLiteConnection { get; private set; }

        public void CreateCartTable() // create cart
        {
            var sql_txt = @"CREATE TABLE IF NOT EXISTS Cart(id integer primary key, name varchar(200), image varchar(200), price integer, qty integer)";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Step();
        }
    }

}