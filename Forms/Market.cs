using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace DungeonCrawl
{
    public partial class Market : Form
    {
        private int price;
        private int damage;
        private int health;
        private string name;
        Player player = new Player();
        DataBaseConnection conn = new DataBaseConnection();
        SafeVillage village = new SafeVillage();
        public Market()
        {
            InitializeComponent();
        }

        private void Market_Load(object sender, EventArgs e)
        {
            
            this.marketTableAdapter.Fill(this.marketDataSet.Market);
        }

        private void marketGeri_btn_Click(object sender, EventArgs e)
        {
            SafeVillage sv = new SafeVillage();
            sv.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            health = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
            damage = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            price = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            if (player.Money>price)
            {
            player.Damage += damage;
            player.NewHealth += health;
            player.Money -= price;
            MessageBox.Show($"{name} başarıyla satın alındı!!! Hasarın: +{damage}, Sağlığın: +{health}, Yeni Paran:{player.Money}");
                
            }
            else
            {
                MessageBox.Show("Satın alım başarısız paranız yetersiz");
            }
        }

        private void Yenile_btn_Click(object sender, EventArgs e)
        {
            marketHasar_lbl.Text = player.Damage.ToString();
            marketPara_lbl.Text = player.Money.ToString();
            marketSaglik_lbl.Text = player.NewHealth.ToString();
        }
    }
}
