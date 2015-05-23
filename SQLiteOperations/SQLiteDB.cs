using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteOperations
{
    public class SQLiteDB
    {

        private string dbPath { get; set; }

        public SQLiteDB(string dbPath)
        {
            this.dbPath = dbPath;
        }


    }
}
