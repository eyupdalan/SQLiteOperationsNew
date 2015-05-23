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
            createConnection();
        }

        private void createConnection()
        {
            if (System.IO.File.Exists(dbPath))
            {
                Connection = new SQLiteConnection("DataSource=" + dbPath);
            }
            else
            {
                throw new SQLiteException("DB not exists");
            }
        }

        public void InsertData(string tableName, SQLiteParameter[] parameters)
        {
            try
            {
                string insertCommand = createInsertScript(tableName, parameters);

                Connection.Open();
                SQLiteCommand command = new SQLiteCommand(insertCommand, Connection);
                command.ExecuteNonQuery();                
            }
            catch (SQLiteException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        private string createInsertScript(string tableName, SQLiteParameter[] parameters)
        {
            StringBuilder stringBuilder1 = new StringBuilder();
            StringBuilder stringBuilder2 = new StringBuilder();

            stringBuilder1.Append("insert into " + tableName + " (");
            stringBuilder2.Append(" values (");

            foreach (SQLiteParameter item in parameters)
            {
                stringBuilder1.Append(item.ParameterName + ", ");
                stringBuilder2.Append(item.ParameterValue.ToString() + ", ");
            }

            string firstPart = stringBuilder1.ToString();
            firstPart = firstPart.Substring(0, firstPart.Length - 2) + ")";

            string secondPart = stringBuilder2.ToString();
            secondPart = secondPart.Substring(0, secondPart.Length - 2) + ")";

            return firstPart + secondPart;
        }
    }
}
