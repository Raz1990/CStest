using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame.Classes
{
    class Player
    {
        public Player(string name, string pass)
        {
            User = name;
            Pass = pass;
        }

        public string User { get; set; }
        public string Pass { get; set; }
        public int Score { get; set; }
    }
}
