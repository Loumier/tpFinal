using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using tpfinal.Data;
using SQLite;

namespace tpfinal.Model
{
    class getConnection
    {
        //database = DependencyService.Get<ISQLite>().getConnection();
        //database.CreateTable<books>();

        #region Propriedades
        //[PrimaryKey, AutoIncrement]
        private int id;
        private String Name;
        private string Author;
        private string email;
        private string isbn;
        #endregion

        public string Name1 { get => Name; set => Name = value; }
        public string Author1 { get => Author; set => Author = value; }
        public string Email { get => email; set => email = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public int Id { get => id; set => id = value; }

        #region book Local Database
        private SQLiteConnection database;
        static object locker = new object();
        #endregion

    }
}