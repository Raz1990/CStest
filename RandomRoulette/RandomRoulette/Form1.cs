using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RandomRoulette
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        string Path = "numbers.xml";
        int count = 1;
        XElement main = new XElement("Numbers");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int num = rand.Next(1, 101);
            lblNum.Text = num.ToString();
            main.Add(new XElement("Num" + count++, num));
            main.Save(Path);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            int max = 0;
            XDocument doc = XDocument.Load(Path);
            XElement TheOne = null;
            main = doc.Root;
            IEnumerable<XElement> list = main.Elements();
            foreach (var ele in list)
            {
                int num = int.Parse(ele.Value);
                if (num > max)
                {
                    max = num;
                    TheOne = ele;
                }
            }
            //Another good option 
            //main.Element(TheOne.Name).Add(new XAttribute("Biggest", true));
            TheOne.Add(new XAttribute("Biggest", "True"));
            TheOne.Save("stam.xml");
            main.Save(Path);
            MessageBox.Show("The biggest number rolled was: " + max);
            Close();
        }
    }
}
