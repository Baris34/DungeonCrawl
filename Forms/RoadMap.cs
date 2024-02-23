using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawl
{
    public partial class RoadMap : Form
    {
        BattleZone zone=new BattleZone();
        Enemies enemy;
        Enemies[] enemyList = new Enemies[3];
        DataBaseConnection conn = new DataBaseConnection();
        public RoadMap()
        {
            
            InitializeComponent();
        }

        private void Geri_btn_Click(object sender, EventArgs e)
        {
            SafeVillage sv = new SafeVillage();
            sv.Show();
            this.Hide();
        }

        private void Mystic_btn_Click(object sender, EventArgs e)
        {
            enemy = enemyList[0];
            if (enemy.Id==1)
            {
                MysticForest mf = new MysticForest();
                enemy.setEnemyStats("Efsanevi Ayı",2,40);
                this.Hide();
                mf.Show();
               
            }
                
        }

        private void RoadMap_Load(object sender, EventArgs e)
        {
            enemyList = zone.GetEnemy();
        }

        private void Cave_btn_Click(object sender, EventArgs e)
        {
            enemy = enemyList[1];
            if (enemy.Id==2)
            {
            DragonCave cave = new DragonCave();
            enemy.setEnemyStats("Lanetli Ejder",4,30);
            cave.Show();
            this.Hide();
            }
        }

        private void Ruin_btn_Click(object sender, EventArgs e)
        {
            enemy = enemyList[2];
            if (enemy.Id == 3)
            {
                RoyalsRuin ruin = new RoyalsRuin();
                enemy.setEnemyStats("Lanetli Ejder", 4, 30);
                ruin.Show();
                this.Hide();
            }
        }
    }
}
