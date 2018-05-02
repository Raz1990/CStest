using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taki
{
    class Card
    {
        string[] images = new string[] { "", @"..\..\images\1.jpeg", @"..\..\images\2.jpeg", @"..\..\images\3.jpeg", @"..\..\images\4.jpeg", @"..\..\images\5.jpeg", @"..\..\images\6.jpeg", @"..\..\images\7.jpeg", @"..\..\images\8.jpeg", @"..\..\images\9.jpeg" };
        public string IMG { get; set; }
        public int Num { get; set; }
        Random rand = new Random();

        public Card()
        {
            Num = rand.Next(1, 10);
            IMG = images[Num];
        }
    }
}
