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

namespace ClickerGame.Forms
{
    public partial class frmLogin : Form
    {
        frmMain main;

        public frmLogin(frmMain main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user, pass;
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Please enter information!");
                return;
            }
            user = txtUser.Text;
            pass = txtPass.Text;
            main.UserName = user;
            main.PassWord = pass;
            MessageBox.Show("Welcome, " + user);
            main.Logged = true;
            Close();
        }
    }
}
