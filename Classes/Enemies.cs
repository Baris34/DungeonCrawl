using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
   public class Enemies
    {
        private static string name;
        private static int damage;
        private static int health;
        private int ID;
        Player player = new Player();
        
        public void setEnemyStats(string Name,int Damage,int Health)
        {
            name = Name;
            damage = Damage;
            health = Health;
        }




        #region Property Tanımları
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        #endregion
    }
}

