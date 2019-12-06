using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace tpfinal.Data
{
    public interface ISQLite
    {
        SQLiteConnection getConnection();
    }
}
