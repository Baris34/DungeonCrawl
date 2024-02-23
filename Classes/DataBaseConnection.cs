using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace DungeonCrawl
{
    class DataBaseConnection
    {
        public OleDbConnection Connection()
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\DungeonCrawlDB.mdb;Persist Security Info=True");
            conn.Open();
            return conn;
        }
    }
}
//Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Barış\\OneDrive\\Masaüstü\\Yazılım\\Oyun\\DungeonCrawl\\DungeonCrawlDB.mdb