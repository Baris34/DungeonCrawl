using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl
{
    class Knight:CharSelect
    {
        public Knight()
        {

        }
        public Knight(int health, int money, int damage, string charName, int Id) : base(health, money, damage, charName, Id)   
        {

        }
    }
}
