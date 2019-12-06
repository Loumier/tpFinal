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
        #region Propriedades
        [PrimaryKey, AutoIncrement]
        private int id;
        private String Name { get; set; }
        private string Author { get; set; }
        private string email { get; set; }
        private string isbn { get; set; }
        #endregion

        //public string Name { get => Name; set => Name = value; }
        //public string Author { get => Author; set => Author = value; }
        //public string Email { get => email; set => email = value; }
        //public string Isbn { get => isbn; set => isbn = value; }
        //public int Id { get => id; set => id = value; }

    }
}