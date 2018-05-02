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
using System.IO;
using System.Xml.Linq;

namespace ClickerGame
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        public string UserName { get; set; }
        public string PassWord { get; set; }
        public bool Logged { get; set; }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin(this);
            frm.ShowDialog();
            if (Logged)
            {
                loginToolStripMenuItem.Checked = true;
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!loginToolStripMenuItem.Checked)
            {
                MessageBox.Show("Please login first!");
                return;
            }
            Game frm = new Game(UserName, PassWord);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
