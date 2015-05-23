using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteOperations
{
    public class SQLiteDB
    {

        private string dbPath { get; set; }

        private SQLiteConnection Connection { get; set; }

        public SQLiteDB(string dbPath)
        {
            this.dbPath = dbPath;
        }

        private void createConnection()
        {
            Connection = new SQLiteConnection("DataSource=" + dbPath);
        }

    }
}
