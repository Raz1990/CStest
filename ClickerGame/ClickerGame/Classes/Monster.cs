using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame.Classes
{
    class Monster
    {
        Random r = new Random();

        string[] images = new string[] { @"..\..\images\blue.png", @"..\..\images\dracula.jpg", @"..\..\images\stitch.png", @"..\..\images\wolf.jpg", @"..\..\images\purple.png", @"..\..\images\funny.jpg" };

        public Monster()
        {
            Life = r.Next(1, 21);
            MaxLife = Life;
            IMG = images[r.Next(1, 6)];
        }

        public string IMG { get; set; }

        public int Life { get; set; }

        public int MaxLife { get; set; }
    }
}
