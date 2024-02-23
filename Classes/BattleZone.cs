using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class BattleZone
    {
        DataBaseConnection conn = new DataBaseConnection();
        Enemies enemy=new Enemies();
        Enemies[] enemyList = new Enemies[3];
        public Enemies[] GetEnemy()
        {
            OleDbCommand cmd = new OleDbCommand("Select * From Characters", conn.Connection());
            OleDbDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                string charID = reader["ID"].ToString();
                switch (charID)
                {
                    case "1":
                        enemy = new LegendaryBear();
                        enemy.Name = reader["Name"].ToString();
                        enemy.Health = Convert.ToInt32(reader["Health"]);
                        enemy.Damage = Convert.ToInt32(reader["Damage"]);
                        enemy.Id = Convert.ToInt32(reader["ID"]);
                        enemyList[0]=enemy;
                        break;
                    case "2":
                        enemy = new HauntedDragon();
                        enemy.Name = reader["Name"].ToString();
                        enemy.Health = Convert.ToInt32(reader["Health"]);
                        enemy.Damage = Convert.ToInt32(reader["Damage"]);
                        enemy.Id = Convert.ToInt32(reader["ID"]);
                        enemyList[1] = enemy;
                        break;
                    case "3":
                        enemy = new King();
                        enemy.Name = reader["Name"].ToString();
                        enemy.Health = Convert.ToInt32(reader["Health"]);
                        enemy.Damage = Convert.ToInt32(reader["Damage"]);
                        enemy.Id = Convert.ToInt32(reader["ID"]);
                        enemyList[2] = enemy;
                        break;
                    default:
                        break;


                }

            }
            conn.Connection().Close();
            return enemyList;
        }
    }
}
