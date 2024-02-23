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
    public partial class MainScene : Form
    {
        public MainScene()
        {
            InitializeComponent();
        }

        private void MainScene_Load(object sender, EventArgs e)
        {


        }

        private void basla_btn_Click(object sender, EventArgs e)
        {
            GameCharSelectScene selectScene = new GameCharSelectScene();
            this.Hide();
            selectScene.ShowDialog();
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            InformationScene ınfo = new InformationScene();
            this.Hide();
            ınfo.ShowDialog();
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }




    }
}
