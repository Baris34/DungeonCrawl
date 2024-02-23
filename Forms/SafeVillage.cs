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
    public partial class SafeVillage : Form
    {
        Player player = new Player();
        GameCharSelectScene gm = new GameCharSelectScene();
        public SafeVillage()
        {
            InitializeComponent();
        }

        private void SafeVillage_Load(object sender, EventArgs e)
        {
            
            this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);
           
            player.Health = player.NewHealth;




        }



        private void market_btn_Click(object sender, EventArgs e)
        {
            Market market = new Market();
            market.marketHasar_lbl.Text = player.Damage.ToString();
            market.marketSaglik_lbl.Text = player.Health.ToString();
            market.marketPara_lbl.Text = player.Money.ToString();
            this.Hide();
            market.ShowDialog();

        }

        private void yol_btn_Click(object sender, EventArgs e)
        {
            RoadMap road = new RoadMap();
            road.Show();
            this.Hide();
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            env_box.Visible = false;
            envanter_btn.Visible = true;
        }

        private void envanter_btn_Click(object sender, EventArgs e)
        {
            
            if (env_box.Visible == false)
            {
                SetEnvText(player);
                env_box.Visible = true;
                envanter_btn.Visible = false;
            }


        }

        private void orman_btn_Click(object sender, EventArgs e)
        {
            MysticForest forest = new MysticForest();
            this.Hide();
            forest.ShowDialog();
        }

        public void SetEnvText(Player character)
        {
            envSaglik_lbl.Text = character.Health.ToString();
            envHasar_lbl.Text = character.Damage.ToString();
            envPara_lbl.Text = character.Money.ToString();
        }





        #region Propertyler




        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
