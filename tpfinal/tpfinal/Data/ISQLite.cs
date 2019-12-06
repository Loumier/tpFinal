using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace tpfinal.Data
{
    interface ISQLite
    {
        SQLiteConnection getConnection();
    }
}
