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
    public partial class DragonCave : Form
    {
        Enemies enemy=new Enemies();
        Player player = new Player();
        RoadMap map = new RoadMap();
        public DragonCave()
        {
            InitializeComponent();
            progressBar1.Maximum = player.NewHealth;
            progressBar1.Value = player.Health;
        }

        private void savas_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(player.Damage + "Hasar verdin!!! ve " + enemy.Damage + " Hasar yedin!!!");
            player.Health -= enemy.Damage;
            enemy.Health -= player.Damage;
            if (player.Health <= 0)
            {
                MessageBox.Show("Zor kaçtın dön ve canını doldur");
                map.Show();
                this.Hide();
            }
            else
            {
                progressBar1.Value = player.Health;

            }
            if (enemy.Health <= 0)
            {
                MessageBox.Show("Tebrikler " + enemy.Name + " Öldü!!!!");
                map.Ruin_btn.Enabled = true;
                
                map.Show();
                this.Hide();
            }
            else
            {
                progressBar2.Value = enemy.Health;
            }
        }

        private void kac_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kaçtın!!! Köyde canın doluyor...");
            SafeVillage safeVillage = new SafeVillage();
            safeVillage.Show();
            this.Hide();
        }
    }
}
