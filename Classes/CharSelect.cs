using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    public abstract class CharSelect 
    {
        private int health;
        private int money;
        private int damage;
        private string charName;
        private int Id;

        public CharSelect()
        {

        }
        public CharSelect(int health,int money,int damage,string charName,int Id)
        {
            this.health = health;
            this.money = money;
            this.damage = damage;
            this.charName = charName;
            this.Id = Id;
        }

        # region Propertyler Oluşturuldu.
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
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public string CharName
        {
            get { return charName; }
            set { charName = value; }
        }
        public int ID
        {
            get { return Id; }
            set { Id = value; }
        }
        #endregion 
    }
}
