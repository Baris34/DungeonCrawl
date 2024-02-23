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
    public partial class GameCharSelectScene : Form
    {
        DataBaseConnection conn = new DataBaseConnection();
        CharSelect[] charSelects = new CharSelect[3];
       
        CharSelect character;
        Player player=new Player();

        public GameCharSelectScene()
        {
            InitializeComponent();
            this.Load += GameCharSelectScene_Load;
        }
        public void GameCharSelectScene_Load(object sender, EventArgs e)
        {


            charSelects = player.GetCharFromDB();

            foreach (CharSelect ch in charSelects)
            {
                switch (ch.ID)
                {
                    case 1:
                        savasciKarakterAdi_lbl.Text = ch.CharName;
                        savasciSaglik_lbl.Text = ch.Health.ToString();
                        savasciHasar_lbl.Text = ch.Damage.ToString();
                        savasciPara_lbl.Text = ch.Money.ToString();
                        break;
                    case 2:
                        okcuKarakterAdi_lbl.Text = ch.CharName;
                        okcuSaglik_lbl.Text = ch.Health.ToString();
                        okcuHasar_lbl.Text = ch.Damage.ToString();
                        okcuPara_lbl.Text = ch.Money.ToString();
                        break;
                    case 3:
                        buyucuKarakterAdi_lbl.Text = ch.CharName;
                        buyucuSaglık_lbl.Text = ch.Health.ToString();
                        buyucuHasar_lbl.Text = ch.Damage.ToString();
                        buyucuPara_lbl.Text = ch.Money.ToString();
                        break;
                    default:
                        break;
                }
            }


            
        }

        private void Savasci_btn_Click(object sender, EventArgs e)
        {
            character = charSelects[0];
            
            if (character.ID==1)
            {
                player.SetPlayerStats(6,20,12);
                Village(character);
            }
            else
            {
                MessageBox.Show("Hata ile karşılaşıldı tekrar deneyin");
            }
        }


        private void Okcu_btn_Click(object sender, EventArgs e)
        {
            character = charSelects[1];

            if (character.ID == 2)
            {
                player.SetPlayerStats(8,15,14);
                Village(character);
            }
            else
            {
                MessageBox.Show("Hata ile karşılaşıldı tekrar deneyin");
            }
        }

        private void Buyucu_btn_Click(object sender, EventArgs e)
        {
            character = charSelects[2];

            if (character.ID == 3)
            {
                player.SetPlayerStats(10,10,18);
                Village(character);
                
            }
            else
            {
                MessageBox.Show("Hata ile karşılaşıldı tekrar deneyin");
            }
        }
        private void Cikis_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Village(CharSelect character)
        {
            SafeVillage village = new SafeVillage();
            this.Hide();
            village.ShowDialog();
        }
       
    }
}
