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
    public partial class RoyalsRuin : Form
    {
        Player player = new Player();
        Enemies enemy = new Enemies();
        RoadMap map = new RoadMap();
        public RoyalsRuin()
        {
            InitializeComponent();
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
                map.Cave_btn.Enabled = true;
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
