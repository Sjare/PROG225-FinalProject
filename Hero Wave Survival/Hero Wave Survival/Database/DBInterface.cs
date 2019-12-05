using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace Hero_Wave_Survival.Database
{
    public class DBInterface
    {
        //private variables
        private string _dbName = "HighScores.sqlite";
        private string _connString = "Data source=HighScores.sqlite;Version=3";
        private string _query;

        //private objects
        private SQLiteConnection conn;
        private SQLiteCommand cmd;

        public DBInterface()
        {
            if (!File.Exists(_dbName))
            {
                try
                {
                    SQLiteConnection.CreateFile(_dbName);
                    conn = new SQLiteConnection(_connString);
                    MakeSchema();
                }
                catch
                {

                }
            }
            else
            {
                EstablishConnection();
            }
        }

        private void MakeSchema()
        {
            _query = @"
            create table HighScores 
            (HighScoreID integer primary key autoincrement, 
            PlayerName string, 
            HeroName string, 
            Wave integer, 
            Timestamp string);";


            cmd = new SQLiteCommand(_query, conn);

            try
            {
                conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void EstablishConnection()
        {
            try
            {
                conn = new SQLiteConnection(_connString);
            }
            catch
            {
                throw;
            }
        }

        public void InsertScore(string pName, string hName, int wave)
        {
            _query = @"
            insert into HighScores (PlayerName, HeroName, Wave, Timestamp) 
            values (@pName, @hName, @wave, @time);";

            cmd = new SQLiteCommand(_query, conn);

            cmd.Parameters.AddWithValue("@pName", pName);
            cmd.Parameters.AddWithValue("@hName", hName);
            cmd.Parameters.AddWithValue("@wave", wave);
            cmd.Parameters.AddWithValue("@time", DateTime.Now);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable GetScores()
        {
            DataTable retTable = new DataTable();

            _query = @"
            select * 
            from HighScores";

            cmd = new SQLiteCommand(_query,conn);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            try
            {
                conn.Open();

                adapter.Fill(retTable);
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return retTable;
        }
    }
}
