using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taki
{
    public partial class Form1 : Form
    {
        int CardsInDeck = 5, total = 0, dealer, place = 1;
        Card klaf;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            GameEnded();
        }

        private void GameEnded()
        {
            Random rand = new Random();
            dealer = rand.Next(1, 31);
            lblDealer.Text += dealer.ToString();
            if (dealer > 21 || dealer <= total)
                MessageBox.Show("You Win");
            else
                MessageBox.Show("You Lose");
            Close();
        }

        private void picDeck_Click(object sender, EventArgs e)
        {
            if (total > 17)
            {
                DialogResult dr = MessageBox.Show("Your score is over 17, are you sure you want to draw?", "High Risk", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                    return;
            }
            klaf = new Card();
            switch (place)
            {
                case 1:
                    picCard1.ImageLocation = klaf.IMG;
                    break;
                case 2:
                    picCard2.ImageLocation = klaf.IMG;
                    break;
                case 3:
                    picCard3.ImageLocation = klaf.IMG;
                    break;
                case 4:
                    picCard4.ImageLocation = klaf.IMG;
                    break;
                case 5:
                    picCard5.ImageLocation = klaf.IMG;
                    break;
                default:
                    break;
            }
            place++;
            //lower amount
            CardsInDeck--;
            //show there is 1 card less in the deck
            lblAmount.Text = "X" + CardsInDeck;
            //show card
            total += klaf.Num;
            lblTotal.Text = "total: " + total;
            //if last card drawn, show deck is empty
            if (total > 21)
            {
                if (CardsInDeck == 0)
                    picDeck.Image = null;
                MessageBox.Show("You Lose");
                Close();
            }
            if (CardsInDeck == 0)
            {
                picDeck.Image = null;
                GameEnded();
            }
        }
    }
}
