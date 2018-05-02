using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClickerGame.Forms;
using ClickerGame.Classes;
using System.Xml.Linq;
using System.IO;

namespace ClickerGame.Forms
{
    public partial class Game : Form
    {
        Player p;
        Monster m;

        public Game(string name, string pass)
        {
            InitializeComponent();
            p = new Player(name, pass);
            m = new Monster();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            lblUserName.Text = p.User;
            picMonster.ImageLocation = m.IMG;
            lblLife.Text = m.Life + "/" + m.MaxLife;
        }

        private void picMonster_Click(object sender, EventArgs e)
        {
            m.Life--;
            lblLife.Text = m.Life + "/" + m.MaxLife;
            if (m.Life == 0)
            {
                lblKill.Visible = true;
                AddScore();
                tmrKill.Enabled = true;
                m = new Monster();
                picMonster.ImageLocation = m.IMG;
                lblLife.Text = m.Life + "/" + m.MaxLife;
            }
        }

        private void AddScore()
        {
            p.Score += m.MaxLife;
            lblScore.Text = p.Score.ToString();
        }

        private void tmrKill_Tick(object sender, EventArgs e)
        {
            lblKill.Visible = false;
            tmrKill.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
