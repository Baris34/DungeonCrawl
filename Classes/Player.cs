using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    public class Player
    {
        private static int damage;
        private static int health;
        private static int money;
        private static int newHealth=20;
        private CharSelect character;
        DataBaseConnection conn = new DataBaseConnection();
        CharSelect[] charSelects = new CharSelect[3];

        public CharSelect[] GetCharFromDB()
        {
            OleDbCommand cmd = new OleDbCommand("Select * From Characters", conn.Connection());
            OleDbDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                string charID = reader["ID"].ToString();

                switch (charID)
                {
                    case "1":
                        character = new Knight();
                        character.CharName = reader["Name"].ToString();
                        character.Damage = Convert.ToInt32(reader["Damage"]);
                        character.Health = Convert.ToInt32(reader["Health"]);
                        character.Money = Convert.ToInt32(reader["Money"]);
                        character.ID = Convert.ToInt32(reader["ID"]);
                        charSelects[0] = character;
                        

                        break;
                    case "2":
                        character = new Archer();
                        character.CharName = reader["Name"].ToString();
                        character.Damage = Convert.ToInt32(reader["Damage"]);
                        character.Health = Convert.ToInt32(reader["Health"]);
                        character.Money = Convert.ToInt32(reader["Money"]);
                        character.ID = Convert.ToInt32(reader["ID"]);
                        charSelects[1] = character;
                       
                        break;
                    case "3":
                        character = new Wizard();
                        character.CharName = reader["Name"].ToString();
                        character.Damage = Convert.ToInt32(reader["Damage"]);
                        character.Health = Convert.ToInt32(reader["Health"]);
                        character.Money = Convert.ToInt32(reader["Money"]);
                        character.ID = Convert.ToInt32(reader["ID"]);
                        charSelects[2] = character;
                        
                        break;
                    default:
                        break;


                }

            }
            conn.Connection().Close();

            return charSelects;
        }
        public void SetPlayerStats(int dmg,int hp,int mny)
        {
            damage = dmg;
            health = hp;
            money = mny;
        }


        #region Propertyler oluşturuldu.
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        public int NewHealth
        {
            get { return newHealth; }
            set { newHealth = value; }
        }


        #endregion


    }
}
