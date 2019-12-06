using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using tpfinal.Data;

namespace tpfinal.Droid
{
    class databaseConnection : ISQLite
    {
        public SQLiteConnection getConnection()
        {
            throw new NotImplementedException();
        }
    }
}