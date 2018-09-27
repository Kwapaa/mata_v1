using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mata_v1
{
    class DbService
    {
        private static string db_path = string.Format("Data Source = {0}", MainSettings.Default.DatabasePath);

        public static int ExecuteCommand()
        {


            SQLiteConnection sqlConnection = new SQLiteConnection(db_path);

            sqlConnection.Open();

            string query = string.Format("select * from '4m_badania'");
            SQLiteCommand command = new SQLiteCommand(query, sqlConnection);

            SQLiteDataReader reader = command.ExecuteReader();

            Console.WriteLine(reader["bad_ID"]);

            return 1;
        }
    }
}
